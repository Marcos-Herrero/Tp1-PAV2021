using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Pav2021.Entities;

namespace Pav2021.DataAccessLayer
{
    class UsuarioDao
    {   
        public Usuario GetUsuarioByID(int id_usuario)
         {
            string consulta = "Select TOP 1 *  FROM Usuarios U JOIN Perfiles P ON U.id_perfil = P.id_perfil "
                       + " WHERE U.borrado = 0 AND id_usuario = " + id_usuario.ToString();            
            var parametros = new Dictionary<string, object>();
            parametros.Add("id_usuario", id_usuario.ToString());
            DataTable fila = DataManager.GetInstance().ConsultaSql(consulta);
            if (fila.Rows.Count > 0)
                return MappingUsuario(fila.Rows[0]);
            else
                return null;

        }


        public IList<Usuario> GetUsuarios()
        {
            List<Usuario> listadoUsuarios = new List<Usuario>();
            string consulta = "SELECT TOP 20 id_usuario, P.nombre, P.id_perfil, usuario,email,estado,password " +
                    " FROM Usuarios U JOIN Perfiles P ON U.id_perfil = P.id_perfil " +
                    " WHERE U.borrado = 0 " +
                    " ORDER BY id_usuario DESC";
            var resultadoConsulta = (DataRowCollection)DataManager.GetInstance().ConsultaSql(consulta).Rows;
            foreach (DataRow row in resultadoConsulta)
            {
                listadoUsuarios.Add(MappingUsuario(row));
            }


            return listadoUsuarios;

        }
        public IList<string> GetEstado()
        {
            List<string> listadoEstados = new List<string>();
            string consulta = "SELECT DISTINCT estado " +
                    "FROM Usuarios";
            var resultadoConsulta = (DataRowCollection)DataManager.GetInstance().ConsultaSql(consulta).Rows;
            foreach (DataRow row in resultadoConsulta)
            {
                listadoEstados.Add(row.ToString());
            }
            return listadoEstados;

        }

        public Usuario GetUser(string nombreUsuario)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String strSql = string.Concat(" SELECT id_usuario, ",
                                          "        usuario, ",
                                          "        email, ",
                                          "        password, ",
                                          "        estado,",
                                          "        p.id_perfil , ",
                                          "        p.nombre",
                                          "   FROM Usuarios u",
                                          "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil ",
                                          "  WHERE usuario = @usuario");

            var parametros = new Dictionary<string, object>();
            parametros.Add("usuario", nombreUsuario);
            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DataManager.GetInstance().ConsultaSql(strSql, parametros);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return MappingUsuario(resultado.Rows[0]);
            }

            return null;
        }


        public IList<Usuario> GetUsuariosByFilters(Dictionary<string, object> parametros)
        {
            List<Usuario> listadoUsuarios = new List<Usuario>();
            string consulta = "SELECT id_usuario, P.nombre,P.id_perfil, usuario,email,estado,password " +
            " FROM Usuarios U JOIN Perfiles P ON U.id_perfil = P.id_perfil " +
            " where id_usuario > 0 AND U.borrado = 0 ";
            if (parametros.ContainsKey("usuario"))
                consulta += " AND (usuario=@usuario) ";
            if (parametros.ContainsKey("nombre"))
                consulta += " AND (P.nombre=@nombre) ";
            if (parametros.ContainsKey("estado"))
                consulta += " AND (estado=@estado) ";
            if (parametros.ContainsKey("email"))
                consulta += " AND (email=@email) ";
            var resultadoConsulta = (DataRowCollection)DataManager.GetInstance().ConsultaSql(consulta, parametros).Rows;

            foreach (DataRow row in resultadoConsulta)
            {
                listadoUsuarios.Add(MappingUsuario(row));
            }

            return listadoUsuarios;
        }

        internal bool Create(Usuario oUsuario)
        {
            var string_conexion = "Data Source=NBAR15232;Initial Catalog=DB_TP;Integrated Security=true;";

            SqlConnection dbConnection = new SqlConnection();
            SqlTransaction dbTransaction = null;

            try
            {
                dbConnection.ConnectionString = string_conexion;
                dbConnection.Open();
                dbTransaction = dbConnection.BeginTransaction();

                SqlCommand insertUsuario = new SqlCommand();

                insertUsuario.Connection = dbConnection;
                insertUsuario.CommandType = CommandType.Text;
                insertUsuario.Transaction = dbTransaction;

                insertUsuario.CommandText = " INSERT INTO Usuarios (usuario, password, email, id_perfil, borrado,estado)" +
                             "     VALUES (@usuario, @password, @email, @id_perfil, 0, @estado);";
                insertUsuario.Parameters.AddWithValue("usuario", oUsuario.UsuarioNombre);
                insertUsuario.Parameters.AddWithValue("password", oUsuario.Password);
                insertUsuario.Parameters.AddWithValue("email", oUsuario.Email);
                insertUsuario.Parameters.AddWithValue("estado", oUsuario.Estado);
                insertUsuario.Parameters.AddWithValue("id_perfil", oUsuario.Perfil.Id_Perfil);
                insertUsuario.ExecuteNonQuery();              

                //obtención ultimo id usuario

                SqlCommand consultaIDUsuario = new SqlCommand();
                consultaIDUsuario.Connection = dbConnection;
                consultaIDUsuario.CommandType = CommandType.Text;
                insertUsuario.CommandText = " SELECT @@IDENTITY";
                var newId = insertUsuario.ExecuteScalar();
                oUsuario.Id_Usuario = Convert.ToInt32(newId);



                // insert historico
                SqlCommand insertHistorico = new SqlCommand();
                insertHistorico.Connection = dbConnection;
                insertHistorico.CommandType = CommandType.Text;   
                insertHistorico.Transaction = dbTransaction;
                insertHistorico.CommandText = " INSERT INTO [dbo].[HistoricoDeAsignaciones] "+
                                                        "           ( [fecha_historico]         "+
                                                        "           ,[id_perfil],[id_usuario])             " +
                                                        " VALUES ((select convert(date, GETDATE()))    " +
                                                        "           ,@id_perfil, @id_usuario)               ;";

                
                insertHistorico.Parameters.AddWithValue("id_perfil", oUsuario.Perfil.Id_Perfil);
                insertHistorico.Parameters.AddWithValue("id_usuario", oUsuario.Id_Usuario);
                insertHistorico.ExecuteNonQuery();               
                dbTransaction.Commit();
                
            }
            catch (Exception ex)
            {
                dbTransaction.Rollback();
                throw ex;
            }
            return true;

        }

        internal bool ModificarPerfil(Usuario oUsuario)
        {
            var string_conexion = "Data Source=DESKTOP-82E3KBS\\SQLEXPRESS;Initial Catalog=DB_TP;Integrated Security=true;";

            SqlConnection dbConnection = new SqlConnection();
            SqlTransaction dbTransaction = null;

            try
            {
                dbConnection.ConnectionString = string_conexion;
                dbConnection.Open();
                dbTransaction = dbConnection.BeginTransaction();

                SqlCommand insertUsuario = new SqlCommand();

                insertUsuario.Connection = dbConnection;
                insertUsuario.CommandType = CommandType.Text;
                insertUsuario.Transaction = dbTransaction;            

                insertUsuario.CommandText = "  UPDATE Usuarios" +
                                      "     SET usuario = @usuario," +
                                      "         password = @password, " +
                                      "         email = @email, " +
                                      "         id_perfil = @id_perfil," +
                                      "         estado = @estado " +
                                      "   WHERE id_usuario = @id_usuario;";
                insertUsuario.Parameters.AddWithValue("usuario", oUsuario.UsuarioNombre);
                insertUsuario.Parameters.AddWithValue("password", oUsuario.Password);
                insertUsuario.Parameters.AddWithValue("email", oUsuario.Email);
                insertUsuario.Parameters.AddWithValue("estado", oUsuario.Estado);
                insertUsuario.Parameters.AddWithValue("id_perfil", oUsuario.Perfil.Id_Perfil);
                insertUsuario.Parameters.AddWithValue("id_usuario", oUsuario.Id_Usuario);
                insertUsuario.ExecuteNonQuery();
                        



                // insert historico
                SqlCommand insertHistorico = new SqlCommand();
                insertHistorico.Connection = dbConnection;
                insertHistorico.CommandType = CommandType.Text;
                insertHistorico.Transaction = dbTransaction;
                insertHistorico.CommandText = " INSERT INTO [dbo].[HistoricoDeAsignaciones] " +
                                                        "           ( [fecha_historico]         " +
                                                        "           ,[id_perfil],[id_usuario])             " +
                                                        " VALUES ((select convert(date, GETDATE()))    " +
                                                        "           , @id_perfil, @id_usuario)  ;";


                insertHistorico.Parameters.AddWithValue("id_perfil", oUsuario.Perfil.Id_Perfil);
                insertHistorico.Parameters.AddWithValue("id_usuario", oUsuario.Id_Usuario);
                insertHistorico.ExecuteNonQuery();


                
                dbTransaction.Commit();

            }
            catch (Exception ex)
            {
                dbTransaction.Rollback();
                throw ex;
            }
            return true;


        }


        internal bool Update(Usuario oUsuario)
        {
            string str_sql = "  UPDATE Usuarios" +
                            "     SET usuario = @usuario," +
                            "         password = @password, " +
                            "         email = @email, " +
                            "         id_perfil = @id_perfil," +
                            "         estado = @estado" +
                            "   WHERE id_usuario = @id_usuario";

            var parametros = new Dictionary<string, object>();
            parametros.Add("usuario", oUsuario.UsuarioNombre);
            parametros.Add("password", oUsuario.Password);
            parametros.Add("email", oUsuario.Email);
            parametros.Add("estado", oUsuario.Estado);
            parametros.Add("id_perfil", oUsuario.Perfil.Id_Perfil);
            parametros.Add("id_usuario", oUsuario.Id_Usuario);

            // Si una fila es afectada por la actualización retorna TRUE. Caso contrario FALSE
            return (DataManager.GetInstance().EjecutarSql(str_sql, parametros) == 1);
        }

        internal bool Delete(Usuario oUsuario)
        {
            string str_sql = "  UPDATE Usuarios" +
                            "     SET borrado = 1" +
                            "   WHERE id_usuario = @id_usuario";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_usuario", oUsuario.Id_Usuario);

            // Si una fila es afectada por la actualización retorna TRUE. Caso contrario FALSE
            return (DataManager.GetInstance().EjecutarSql(str_sql, parametros) == 1);
        }




        private Usuario MappingUsuario(DataRow row)
        {
            Usuario oUsuario = new Usuario
            {
                Id_Usuario = Convert.ToInt32(row["id_Usuario"].ToString()),
                UsuarioNombre = row["usuario"].ToString(),
                Email = row["email"].ToString(),
                Estado = row["estado"].ToString(),
                Password = row.Table.Columns.Contains("password") ? row["password"].ToString() : null,
                Perfil = new Perfil()
                {   
                    Id_Perfil= Convert.ToInt32(row["id_perfil"].ToString()),
                    Nombre = row["nombre"].ToString(),
                }

            };


            return oUsuario;
        }

        
    }
}