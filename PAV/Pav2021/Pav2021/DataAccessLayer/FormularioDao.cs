using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Pav2021.Entities;

namespace Pav2021.DataAccessLayer
{
    class FormularioDao
    {
        public IList<Formulario> GetAll()
        {
            List<Formulario> listadoFormularios = new List<Formulario>();

            var strSql = "SELECT id_formulario, nombre from Formularios where borrado=0";

            var resultadoConsulta = DataManager.GetInstance().ConsultaSql(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoFormularios.Add(ObjectMapping(row));
            }

            return listadoFormularios;
        }
        public IList<Formulario> GetByFilters(Dictionary<string, object> parametros)
        {
            List<Formulario> lst = new List<Formulario>();
            String strSql = string.Concat(" SELECT id_formulario, ",
                                              "    nombre  ",
                                              "   FROM Formularios ",
                                              "  WHERE borrado = 0");

            if (parametros.ContainsKey("idFormulario"))
                strSql += " AND (id_formulario = @idFormulario) ";


            if (parametros.ContainsKey("nombre"))
                strSql += " AND (nombre = @nombre) ";

            var resultado = DataManager.GetInstance().ConsultaSql(strSql, parametros);

            foreach (DataRow row in resultado.Rows)
                lst.Add(ObjectMapping(row));

            return lst;
        }

        public Formulario GetFormulario(string nombreFormulario)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String strSql = string.Concat(" SELECT id_formulario, ",
                                          "        nombre ",
                                          "   FROM Formularios ",
                                          "  WHERE nombre LIKE '@nombreFormulario'");

            var parametros = new Dictionary<string, object>();
            parametros.Add("nombre", nombreFormulario);
            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DataManager.GetInstance().ConsultaSql(strSql, parametros);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }
        public Formulario GetFormularioByID(int id)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String strSql = string.Concat(" SELECT id_formulario, ",
                                          "        nombre ",
                                          "   FROM Formularios ",
                                          "  WHERE id_formulario = @id");

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_formulario", id);
            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DataManager.GetInstance().ConsultaSql(strSql, parametros);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }

        internal bool Create(Formulario oFormulario)
        {


            /*
             * string str_max = "     SELECT MAX id_formulario" +
                             "     From Formularios";
            var max= DataManager.GetInstance().EjecutarSql(str_max) ;if (max. > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }
            */
            string str_sql = "     INSERT INTO Formularios (nombre, borrado)" +
                             "     VALUES ( @nombre, 0)";

            var parametros = new Dictionary<string, object>();
            parametros.Add("nombre", oFormulario.Nombre);
            

            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE
            return (DataManager.GetInstance().EjecutarSql(str_sql, parametros) == 1);
        }

        internal bool Update(Formulario oFormulario)
        {
            string str_sql = "     UPDATE Formularios " +
                             "     SET nombre=@nombre"+
                             "     WHERE id_formulario=@id_formulario";

            var parametros = new Dictionary<string, object>();
            parametros.Add("nombre", oFormulario.Nombre);
            parametros.Add("id_formulario", oFormulario.Id_Formulario);


            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE
            return (DataManager.GetInstance().EjecutarSql(str_sql, parametros) == 1);
        }
        internal bool Delete(Formulario oFormulario)
        {
            string str_sql = "  UPDATE Formularios" +
                            "     SET borrado = 1" +
                            "     WHERE id_formulario=@id_formulario";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_formulario", oFormulario.Id_Formulario);

            // Si una fila es afectada por la actualización retorna TRUE. Caso contrario FALSE
            return (DataManager.GetInstance().EjecutarSql(str_sql, parametros) == 1);
        }


        private Formulario ObjectMapping(DataRow row)
        {
            Formulario oFormulario = new Formulario
            {
                Id_Formulario = Convert.ToInt32(row["id_formulario"].ToString()),
                Nombre = row["nombre"].ToString()
            };

            return oFormulario;
        }
    }
}
