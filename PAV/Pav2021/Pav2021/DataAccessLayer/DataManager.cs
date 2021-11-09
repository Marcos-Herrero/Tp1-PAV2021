using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Pav2021
{
    class DataManager
    {
        private SqlConnection dbConnection;
        
        private static DataManager instance;

        public DataManager()
        {
            dbConnection = new SqlConnection();
            var string_conexion = "Data Source=DESKTOP-82E3KBS\\SQLEXPRESS;Initial Catalog=DB_TP;Integrated Security=true;"; 
            dbConnection.ConnectionString = string_conexion;

        }

        public static DataManager GetInstance()
        {
            if (instance == null)
                instance = new DataManager();

            instance.Open();

            return instance;
        }

        public void Open()
        {
            if (dbConnection.State != System.Data.ConnectionState.Open)
                dbConnection.Open();
        }

        public void Close()
        {
            if (dbConnection.State != System.Data.ConnectionState.Closed)
                dbConnection.Close();
        }

        public DataTable ConsultaSql(string strSql, Dictionary<string, object> prs = null)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                cmd.Connection = dbConnection;
                cmd.CommandText = strSql;

                if (prs != null)
                {
                    foreach (var item in prs)
                    {
                        cmd.Parameters.AddWithValue(item.Key, item.Value);
                    }
                }
                tabla.Load(cmd.ExecuteReader());
                return tabla;

            }
            catch(Exception ex)
            {
                throw (ex);
            }
        }

        public int EjecutarSql(string strsql, Dictionary<string, object> prs = null)
        {
            SqlCommand cmd = new SqlCommand();

            int rtdo = 0;

            // Try Catch Finally
            // Trata de ejecutar el código contenido dentro del bloque Try - Catch
            // Si hay error lo capta a través de una excepción
            // Si no hubo error
            try
            {
                cmd.Connection = dbConnection;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strsql;

                //Agregamos a la colección de parámetros del comando los filtros recibidos
                if (prs != null)
                {
                    foreach (var item in prs)
                    {
                        cmd.Parameters.AddWithValue(item.Key, item.Value);
                    }
                }

                // Retorna el resultado de ejecutar el comando
                rtdo = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rtdo;
        }
    


        public object ConsultaSqlScalar(string strSql)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = dbConnection;
                cmd.CommandType = CommandType.Text;

                return cmd.ExecuteScalar();
            }
            catch(SqlException ex)
            {
                throw (ex);
            }
        }



    }   
}
