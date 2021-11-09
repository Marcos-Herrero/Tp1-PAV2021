using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Pav2021.Entities;

namespace Pav2021.DataAccessLayer
{
    class PermisoDao
    {
        public IList<Permiso> GetAll()
        {
            List<Permiso> listadoPermisos = new List<Permiso>();

            var strSql = string.Concat(" SELECT f.nombre, ",
                                              "    p.nombre  ",
                                              "   FROM Formularios f INNER JOIN Permisos per ON f.id_formulario = per.id_formulario ",
                                              "   INNER JOIN Perfiles p ON per.id_perfil=p.id_perfil");
                                              

            var resultadoConsulta = DataManager.GetInstance().ConsultaSql(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoPermisos.Add(ObjectMapping(row));
            }

            return listadoPermisos;
        }

        public Permiso GetPermiso(int idFormulario, int idPerfil)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            var strSql = string.Concat(" SELECT f.nombre, ",
                                              "    p.nombre  ",
                                              "   FROM Formularios f INNER JOIN Permisos per ON f.id_formulario = per.id_formulario ",
                                              "   INNER JOIN Perfiles p ON per.id_perfil=p.id_perfil",
                                              "Where per.id_formulario=@idFormulario AND per.id_perfil=@idPerfil");

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_formulario", idFormulario);
            parametros.Add("id_perfil", idPerfil);
            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DataManager.GetInstance().ConsultaSql(strSql, parametros);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }

        public IList<Permiso> GetByFilters(Dictionary<string, object> parametros)
        {
            List<Permiso> lst = new List<Permiso>();
            String strSql = string.Concat(" SELECT f.nombre, ",
                                              "    p.nombre  ",
                                              "   FROM Formularios f INNER JOIN Permisos per ON f.id_formulario = per.id_formulario ",
                                              "   INNER JOIN Perfiles p ON per.id_perfil=p.id_perfil",
                                              "   WHERE 1=1");

            if (parametros.ContainsKey("idFormulario"))
                strSql += " AND (id_formulario = @idFormulario) ";


            if (parametros.ContainsKey("id_formulario"))
                strSql += " AND (id_perfil =@idPerfil) ";

            var resultado = DataManager.GetInstance().ConsultaSql(strSql, parametros);

            foreach (DataRow row in resultado.Rows)
                lst.Add(ObjectMapping(row));

            return lst;
        }


        internal bool Create(Permiso oPermiso)
        {
            string str_sql = "     INSERT INTO Permisos (id_formulario,id_perfil, borrado)" +
                             "     VALUES (@id_formulario, @id_perfil, 0)";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_formulario", oPermiso.Formulario.Id_Formulario);
            parametros.Add("id_perfil", oPermiso.Perfil.Id_Perfil);
           

            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE
            return (DataManager.GetInstance().EjecutarSql(str_sql, parametros) == 1);
        }

        internal bool Update(Permiso oPermiso)
        {
            string str_sql = "     UPDATE Permisos" +
                             "     SET id_formulario =@id_formulario, id_perfil=@id_perfil)"+
                             "     WHERE id_formulario =@id_formulario && id_perfil=@id_perfil";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_formulario", oPermiso.Formulario.Id_Formulario);
            parametros.Add("id_perfil", oPermiso.Perfil.Id_Perfil);


            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE
            return (DataManager.GetInstance().EjecutarSql(str_sql, parametros) == 1);
        }
        internal bool Delete(Permiso oPermiso)
        {
            string str_sql = "  UPDATE Permisos" +
                            "     SET borrado = 1" +
                            "  WHERE id_formulario =@id_formulario && id_perfil=@id_perfil";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_formulario", oPermiso.Formulario.Id_Formulario);
            parametros.Add("id_perfil", oPermiso.Perfil.Id_Perfil);

            // Si una fila es afectada por la actualización retorna TRUE. Caso contrario FALSE
            return (DataManager.GetInstance().EjecutarSql(str_sql, parametros) == 1);
        }

        private Permiso ObjectMapping(DataRow row)
        {
            Permiso oPermiso = new Permiso();
            oPermiso.Perfil = new Perfil();
            oPermiso.Perfil.Nombre = row["nombre"].ToString();
            oPermiso.Formulario = new Formulario();
            oPermiso.Formulario.Nombre = row["nombre"].ToString();
            return oPermiso;
        }           
        
    }
}
