using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace dbTurnos
{
    /// <summary>Objeto que ejecuta una sentencia SQL que no devuelve datos de por si (SqlCommand.ExecuteNonQuery).</summary>
    class SQLNoConsulta
    {
        //TODO: extraer cadena conexin para abstraer clase

        private string _sentencia;
        public SQLNoConsulta(string sentencia)
        {
            _sentencia = sentencia;
        }
        public int Ejecutar()
        {
            using (SqlConnection conexion = new SqlConnection(new Properties.Settings().Bar_TurnosConnectionString))
            {
                SqlCommand comandoSql = new SqlCommand(_sentencia, conexion);
                try
                {
                    conexion.Open();
                    return comandoSql.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }
    }
}

