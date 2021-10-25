using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TpPav.Entities;

namespace TpPav.DataAccessLayer
{
    class PerfilDao
    {
        
        public IList<Perfil> GetAll()
        {
            List<Perfil> listadoPerfiles = new List<Perfil>();

            var strSql = "SELECT id_perfil, nombre from Perfiles where borrado=0";

            var resultadoConsulta = DataManager.GetInstance().ConsultaSql(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoPerfiles.Add(ObjectMapping(row));
            }

            return listadoPerfiles;
        }
       
        public IList<Perfil> GetByFilters(Dictionary<string, object> parametros)
        {
            List<Perfil> lst = new List<Perfil>();
            String strSql = string.Concat(" SELECT id_perfil, ",
                                              "    nombre  ",
                                              "   FROM Perfiles ",                                              
                                              "  WHERE borrado = 0");

            if (parametros.ContainsKey("idPerfil"))
                strSql += " AND (id_perfil = @idPerfil) ";


            if (parametros.ContainsKey("nombre"))
                strSql += " AND (nombre =@nombre) ";

            var resultado = DataManager.GetInstance().ConsultaSql(strSql, parametros);

            foreach (DataRow row in resultado.Rows)
                lst.Add(ObjectMapping(row));

            return lst;
        }
        public Perfil GetPermisoByID(int id)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String strSql = string.Concat(" SELECT id_perfil, ",
                                          "        nombre ",
                                          "   FROM Perfiles ",
                                          "  WHERE id_perfil =@id");

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_perfil", id);
            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DataManager.GetInstance().ConsultaSql(strSql, parametros);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }
        public Perfil GetPerfil(string nombrePerfil)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String strSql = string.Concat(" SELECT id_perfil, ",
                                          "        nombre ",
                                          "   FROM Perfiles ",
                                          "  WHERE nombre = @nombrePerfil");

            var parametros = new Dictionary<string, object>();
            parametros.Add("nombrePerfil", nombrePerfil);
            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DataManager.GetInstance().ConsultaSql(strSql, parametros);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }


        internal bool Create(Perfil oPerfil)
        {
            string str_sql = "     INSERT INTO Perfiles (nombre, borrado)" +
                             "     VALUES ( @nombre, 0)";

            var parametros = new Dictionary<string, object>();
            parametros.Add("nombre", oPerfil.Nombre);


            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE
            return (DataManager.GetInstance().EjecutarSql(str_sql, parametros) == 1);
        }

        internal bool Update(Perfil oPerfil)
        {
            string str_sql = "     UPDATE Perfiles " +
                             "     SET nombre=@nombre" +
                             "     WHERE id_perfil=@id_perfil";

            var parametros = new Dictionary<string, object>();
            parametros.Add("nombre", oPerfil.Nombre);
            parametros.Add("id_perfil", oPerfil.Id_Perfil);


            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE
            return (DataManager.GetInstance().EjecutarSql(str_sql, parametros) == 1);
        }

        internal bool Delete(Perfil oPerfil)
        {
            string str_sql = "  UPDATE Perfiles" +
                            "     SET borrado = 1" +
                            "     WHERE id_perfil=@id_perfil";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_perfil", oPerfil.Id_Perfil);

            // Si una fila es afectada por la actualización retorna TRUE. Caso contrario FALSE
            return (DataManager.GetInstance().EjecutarSql(str_sql, parametros) == 1);
        }

        private Perfil ObjectMapping(DataRow row)
        {
            Perfil operfil = new Perfil
            {
                Id_Perfil = Convert.ToInt32(row["id_perfil"].ToString()),
                Nombre = row["nombre"].ToString()
            };

            return operfil;
        }
    }
}
