﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace dbTurnos.DataSQL
{
    /// <summary>DataTable que se cargar con lo datos obtenidos a partir de una sentencia SQL.</summary>
    public class AutoGeneratedDataTable : DataTable
    {
        //TODO: extraer cadena conexin para abstraer clase

        private string _consulta;
        public string ConsultaSQL { get { return _consulta; } set { _consulta = value; Refrescar(); } }
        public AutoGeneratedDataTable(string consulta)
            : base()
        {
            _consulta = consulta;
            Refrescar();
        }
        public void Refrescar()
        {
            using (SqlConnection conexion = new SqlConnection(new Properties.Settings().Bar_TurnosConnectionString))
            {
                SqlCommand comandoSql = new SqlCommand(_consulta, conexion);
                try
                {
                    conexion.Open();
                    SqlDataAdapter da = new SqlDataAdapter(comandoSql);
                    da.Fill(this);
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
