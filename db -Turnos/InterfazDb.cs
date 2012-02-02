﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using dbTurnos.Excepciones;
using dbTurnos.DataSQL;
using System.IO;
using System.Diagnostics;
using System.Configuration;

namespace dbTurnos
{
    public static class InterfazDb
    {
        static Log2File _log;

        /// <exception cref="dbTurnos.LoadingLog2FileException">Ocurre cuando el no se puede iniciar el sistema de log de eventos. Encapsula el error original.</exception>
        public static void Iniciar(string AppStartUpPath, Log2File traceListener)
        {
            //si no hay una configuracion determinada, carga el appStartupPath durante la ejecucion actual.
            if (Properties.Settings.Default.dbTurnosConnectionString == "") //HACK: por si desea agregar funcionalidad de configuacio (ubicacion DB. usuario y password.)
            {
                //HACK: cifrar cadena de conxecion para prevenir ing inversa del MCIL.
                Properties.Settings.Default.dbTurnosConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"" + AppStartUpPath + "\\Bar Turnos.accdb\";Persist Security Info=True;Jet OLEDB:Database Password=We34*tr9";
            }
            AutoGeneratedDataTable.CadenaConexion = Properties.Settings.Default.dbTurnosConnectionString;
            SQLNoConsulta.CadenaConexion = Properties.Settings.Default.dbTurnosConnectionString;
            _log = traceListener;
            _log.WriteLine("InterfazDb iniciada.");
            _log.Flush();
        }
        /// <exception cref="dbTurnos.LoadingLog2FileException">Ocurre cuando el no se puede iniciar el sistema de log de eventos. Encapsula el error original.</exception>
        public static void Iniciar(string AppStartUpPath)
        {
            Iniciar(AppStartUpPath, new Log2File(AppStartUpPath + "\\dbEvents.log", false));
        }

        /// <summary>Devuelve un dataTable con los turnos abiertos en la db.</summary>
        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.Data.OleDb.OleDbException"></exception>
        public static DataTable TurnosGetAbiertos()
        {
            try
            {
                return new AutoGeneratedDataTable("SELECT Usuarios.usuario, Usuarios.nombre, Turnos.fechaInicio, Usuarios.id FROM Usuarios INNER JOIN Turnos ON Usuarios.id = Turnos.idUsuario WHERE Turnos.fechaFin is Null");
            }
            catch (Exception ex)
            {
                log(ex);
                throw ex;
            }
        }

        /// <summary>Abre un turno para un usuario, con le fecha especifica, siempre cuando no exista uno ya abierto.</summary>
        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.Data.OleDb.OleDbException"></exception>
        /// <exception cref="dbTurnos.Excepciones.YaTieneTurnoAbiertoException"></exception>
        public static void AbrirTurno(int idUsuario, DateTime inicio)
        {
            try
            {
                //HACK: filtrar campos contra SQL inyection.
                DataTable turnos = new AutoGeneratedDataTable("SELECT fechaInicio FROM Turnos WHERE idUsuario = " + idUsuario + " AND fechaFin Is Null");
                if (turnos.Rows.Count != 0)
                    throw new YaTieneTurnoAbiertoException(Convert.ToDateTime(turnos.Rows[0]["fechaInicio"]));
                new SQLNoConsulta("INSERT INTO Turnos (idUsuario, fechaInicio) VALUES ('" + idUsuario + "', #" + inicio.ToString("yyyy/MM/dd HH:mm:ss") + "#)");
            }
            catch (Exception ex)
            {
                log(ex);
                throw ex;
            }
        }

        /// <summary>Cierra el turno abierto para un usuario especifico.</summary>
        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.Data.OleDb.OleDbException"></exception>
        /// <exception cref="System.FormatException"></exception>
        /// <exception cref="System.InvalidCastException"></exception>
        /// <exception cref="dbTurnos.Excepciones.NoHayTurnoAbiertoException"></exception>
        /// <exception cref="dbTurnos.Excepciones.InicioTurnoMayorQueFinException"></exception>
        public static void CerrarTurno(int idUsuario, DateTime fin)
        {
            try
            {            
                //HACK: filtrar campos contra SQL inyection.
                AutoGeneratedDataTable turnoAbierto = new AutoGeneratedDataTable("SELECT idUsuario, fechaInicio FROM Turnos WHERE (idUsuario = " + idUsuario + " AND fechaFin Is Null)");
                if (turnoAbierto.Rows.Count == 0)
                    throw new NoHayTurnoAbiertoException("No tiene ningún turno abierto que cerrar.");
                DateTime inicio = Convert.ToDateTime(turnoAbierto.Rows[0]["fechaInicio"]);
                if (inicio > fin)
                    throw new InicioTurnoMayorQueFinException(inicio , fin );
                new SQLNoConsulta("UPDATE Turnos SET fechaFin = #" + fin.ToString("yyyy/MM/dd HH:mm:ss") + "# WHERE (idUsuario  = " + idUsuario + ") AND (fechaFin IS NULL)");
            }
            catch (Exception ex)
            {
                log(ex);
                throw ex;
            }
        }

        /// <summary>Cambia la contraseña de un usuario espefcifico.</summary>
        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.Data.OleDb.OleDbException"></exception>
        /// <exception cref="dbTurnos.Excepciones.ContraseñaNoPuedeSerNula"></exception>
        public static void CambiarContraseña(int idUsuario, string nuevaContraseña)
        {
            try
            {
                if (nuevaContraseña == "") throw new ContraseñaNoPuedeSerNula();
            //HACK: YA cifrar contraseña
            new SQLNoConsulta("UPDATE Usuarios SET Usuarios.contraseñaSHA = '"+nuevaContraseña+"' WHERE Usuarios.id="+idUsuario);

            }
            catch (Exception ex)
            {
                log(ex);
                throw ex;
            }
        }

        /// <summary>Devuelve el id del usuario que coincide con  el par usuario/contraseña.</summary>
        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.Data.OleDb.OleDbException"></exception>
        /// <exception cref="dbTurnos.Excepciones.ParUsuarioContraseñaIncorrectoException"></exception>
        /// <exception cref="System.FormatException"></exception>
        /// <exception cref="System.InvalidCastException"></exception>
        /// <exception cref="System.OverflowException"></exception>
        public static int Identificar(string usuario, string contraseña)
        {
            DataTable idTable;
            //HACK: YA cifrar contraseña
            //HACK: filtar caracteres especiales usuario, cifrar contraseña.
            try
            {
                idTable = new AutoGeneratedDataTable("SELECT TOP 1 Usuarios.id, Usuarios.estaHabilitado FROM Usuarios WHERE (((Usuarios.usuario)='" + usuario + "') AND ((Usuarios.contraseñaSHA)='" + contraseña + "'))");
                if (!Convert.ToBoolean(idTable.Rows[0]["estaHabilitado"]))
                    throw new UsuarioSuspendidoException(usuario);
                else
                    return Convert.ToInt32(idTable.Rows[0][0]);
            }
            catch (IndexOutOfRangeException)
            {
                Exception ex =  new ParUsuarioContraseñaIncorrectoException();
                log(ex);
                throw ex;
            }
            catch (Exception ex)
            {
                log(ex);
                throw ex;
            }
        }

        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.Data.OleDb.OleDbException"></exception>
        public static DataTable UsuariosGetAll()
        {
            try
            {           
                return new AutoGeneratedDataTable("SELECT id, usuario, nombre, esAdmin FROM Usuarios");
            }
            catch (Exception ex)
            {
                log(ex);
                throw ex;
            }
        }

        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.Data.OleDb.OleDbException"></exception>
        public static void UsuarioEliminar(int idUsuario)
        {
            try
            {
                new SQLNoConsulta("DELETE idUsuario FROM Turnos WHERE idUsuario = " + idUsuario);
            new SQLNoConsulta("DELETE usuario FROM Usuarios WHERE (id="+idUsuario+")");
            }
            catch (Exception ex)
            {
                log(ex);
                throw ex;
            }
        }

        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.Data.OleDb.OleDbException"></exception>
        public static object TurnosGetCumplen(string _filtroSQLwhere)
        {
            try
            {            
                return new AutoGeneratedDataTable("SELECT Usuarios.nombre AS Nombre, Turnos.fechaInicio AS Inicio, Turnos.fechaFin AS Fin FROM (Turnos INNER JOIN Usuarios ON Turnos.idUsuario = Usuarios.id) " + _filtroSQLwhere);
            }
            catch (Exception ex)
            {
                log(ex);
                throw ex;
            }
        }

        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.Data.OleDb.OleDbException"></exception>
        public static void UsuarioEditar(int idUsuarioACambiar, string usuario, string nombre, string contraseña, bool requiereCambio, bool habilitado, bool esAdmin)
        {
            try
            {            
                new SQLNoConsulta("UPDATE Usuarios SET usuario = '"+ usuario +"', nombre = '"+nombre+"', contraseñaSHA = '"+contraseña+"', requiereCambio = "+ requiereCambio.ToString() +", estaHabilitado = "+habilitado.ToString()+", esAdmin = "+esAdmin.ToString()+" WHERE (id="+idUsuarioACambiar+")");
            }
            catch (Exception ex)
            {
                log(ex);
                throw ex;
            }
        }

        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.Data.OleDb.OleDbException"></exception>
        public static void UsuarioEditar(int idUsuarioAcambiar, string usuario, string nombre, bool requiereCambio, bool habilitado, bool esAdmin)
        {
            try
            {            
                new SQLNoConsulta("UPDATE Usuarios SET usuario = '" + usuario + "', nombre = '" + nombre + "', requiereCambio = " + requiereCambio.ToString() + ", estaHabilitado = " + habilitado.ToString() + ", esAdmin = " + esAdmin.ToString() + " WHERE (id=" + idUsuarioAcambiar + ")");
            }
            catch (Exception ex)
            {
                log(ex);
                throw ex;
            }
        } 

        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.Data.OleDb.OleDbException"></exception>
        public static void UsuarioNuevo(string usuario, string nombre, string contraseña, bool requiereCambio, bool habilitado, bool esAdmin)
        {
            try
            {           
                new SQLNoConsulta("INSERT INTO Usuarios(usuario, nombre, contraseñaSHA, requiereCambio, estaHabilitado, esAdmin) Values ('" + usuario + "', '" + nombre + "', '" + contraseña + "', " + requiereCambio.ToString() + ", " + habilitado.ToString() + ", " + esAdmin.ToString() + ")");
            }
            catch (Exception ex)
            {
                log(ex);
                throw ex;
            }
         }

        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.Data.OleDb.OleDbException"></exception>
        /// <exception cref="System.IndexOutOfRangeException"></exception>
        public static string UsuarioGetNombre(int idUsuario)
        {
            try
            {            
                return new AutoGeneratedDataTable("SELECT nombre FROM Usuarios WHERE id = " + idUsuario).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                log(ex);
                throw ex;
            }
        }

        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.Data.OleDb.OleDbException"></exception>
        /// <exception cref="System.IndexOutOfRangeException"></exception>
        public static string UsuarioGetUsuario(int idUsuario)
        {
            try
            {            
                return new AutoGeneratedDataTable("SELECT usuario FROM Usuarios WHERE id = " + idUsuario).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                log(ex);
                throw ex;
            }
        }

        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.Data.OleDb.OleDbException"></exception>
        /// <exception cref="System.IndexOutOfRangeException"></exception>
        public static string UsuarioGetContraseña(int idUsuario)
        {
            try
            {
                return new AutoGeneratedDataTable("SELECT contraseñaSHA FROM Usuarios WHERE id = " + idUsuario).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                log(ex);
                throw ex;
            }
        }

        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.Data.OleDb.OleDbException"></exception>
        /// <exception cref="dbTurnos.Excepciones.NoExisteUsuarioException"></exception>
        /// <exception cref="System.FormatException"></exception>
        /// <exception cref="System.InvalidCastException"></exception>
        /// <exception cref="System.OverflowException"></exception>
        public static int UsuarioGetId(string usuario)
        {
            try
            {
                return Convert.ToInt32(new AutoGeneratedDataTable("SELECT id FROM Usuarios WHERE usuario = '" + usuario + "'").Rows[0][0]);
            }
            catch (IndexOutOfRangeException)
            {
                Exception ex = new NoExisteUsuarioException();
                log(ex);
                throw ex;
            }
            catch (Exception ex)
            {
                log(ex);
                throw ex;
            }
        }

        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.Data.OleDb.OleDbException"></exception>
        /// <exception cref="System.IndexOutOfRangeException"></exception>
        /// <exception cref="System.FormatException"></exception>
        /// <exception cref="System.InvalidCastException"></exception>
        public static bool UsuarioGetHabilitado(int idUsuario)
        {
            try
            {            
                return Convert.ToBoolean(new AutoGeneratedDataTable("SELECT estaHabilitado FROM Usuarios WHERE id = " + idUsuario).Rows[0][0]);
            }
            catch (Exception ex)
            {
                log(ex);
                throw ex;
            }
        }

        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.Data.OleDb.OleDbException"></exception>
        /// <exception cref="System.IndexOutOfRangeException"></exception>
        /// <exception cref="System.FormatException"></exception>
        /// <exception cref="System.InvalidCastException"></exception>
        public static bool UsuarioGetAdmin(int idUsuario)
        {
            try
            {            
                return Convert.ToBoolean(new AutoGeneratedDataTable("SELECT esAdmin FROM Usuarios WHERE id = " + idUsuario).Rows[0][0]);
            }
            catch (Exception ex)
            {
                log(ex);
                throw ex;
            }
        }

        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.Data.OleDb.OleDbException"></exception>
        /// <exception cref="System.IndexOutOfRangeException"></exception>
        /// <exception cref="System.FormatException"></exception>
        /// <exception cref="System.InvalidCastException"></exception>
        public static bool UsuarioGetRequiereCambio(int idUsuario)
        {
            try
            {           
                return Convert.ToBoolean(new AutoGeneratedDataTable("SELECT requiereCambio FROM Usuarios WHERE id = " + idUsuario).Rows[0][0]);
            }
            catch (Exception ex)
            {
                log(ex);
                throw ex;
            }
        }

        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.Data.OleDb.OleDbException"></exception>
        public static void UsuarioSetRequiereCambio(int idUsuario, bool nuevoValor)
        {
            try
            {
                new SQLNoConsulta("UPDATE Usuarios SET requiereCambio = " + nuevoValor.ToString() + " WHERE (id=" + idUsuario + ")");
            }
            catch (Exception ex)
            {
                log(ex);
                throw ex;
            }
        }

        private static void log(Exception ex) 
        {
            _log.TraceException(ex, "interfazDB");
        }
    }
}
