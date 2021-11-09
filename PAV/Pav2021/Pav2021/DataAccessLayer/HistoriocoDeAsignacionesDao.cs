using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Pav2021.Entities;

namespace Pav2021.DataAccessLayer
{
    class HistoriocoDeAsignacionesDao
    {
        public IList<HistoricoAsignaciones> GetAll()
        {
            List<HistoricoAsignaciones> listadoHistoricoDeAsignacioneses = new List<HistoricoAsignaciones>();
            var strSql = string.Concat(" SELECT p.IdHistoricoAsignaciones, p.nombre, f.nombre ",
                                       "   FROM Formulario f  INNER JOIN Permisos per ON f.id_formulario = per.id_formulario ",
                                        "   INNER JOIN HistoricoDeAsignacioneses p ON per.IdHistoricoAsignaciones=p.IdHistoricoAsignaciones",
                                        " WHERE p.borrado=0");


            var resultadoConsulta = DataManager.GetInstance().ConsultaSql(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoHistoricoDeAsignacioneses.Add(ObjectMapping(row));
            }

            return listadoHistoricoDeAsignacioneses;
        }

        public IList<HistoricoAsignaciones> GetByFilters(Dictionary<string, object> parametros)
        {
            List<HistoricoAsignaciones> lst = new List<HistoricoAsignaciones>();
            var strSql = string.Concat(" SELECT p.IdHistoricoAsignaciones, p.nombre, f.nombre ",
                                        "   FROM Formulario f  INNER JOIN Permisos per ON f.id_formulario = per.id_formulario ",
                                         "   INNER JOIN HistoricoDeAsignacioneses p ON per.IdHistoricoAsignaciones=p.IdHistoricoAsignaciones",
                                         "where p.borrado=0");

            if (parametros.ContainsKey("idHistoricoDeAsignaciones"))
                strSql += " AND (IdHistoricoAsignaciones = @idHistoricoDeAsignaciones) ";


            if (parametros.ContainsKey("nombre"))
                strSql += " AND (nombre =@nombre) ";

            var resultado = DataManager.GetInstance().ConsultaSql(strSql, parametros);

            foreach (DataRow row in resultado.Rows)
                lst.Add(ObjectMapping(row));

            return lst;
        }
        public HistoricoAsignaciones GetPermisoByID(int id)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String strSql = string.Concat(" SELECT IdHistoricoAsignaciones, ",                                          
                                          "   FROM HistoricoDeAsignacioneses ",
                                          "  WHERE IdHistoricoAsignaciones =@id");

            var parametros = new Dictionary<string, object>();
            parametros.Add("IdHistoricoAsignaciones", id);
            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DataManager.GetInstance().ConsultaSql(strSql, parametros);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }
        public HistoricoAsignaciones GetHistoricoDeAsignaciones(string nombreHistoricoDeAsignaciones)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String strSql = string.Concat(" SELECT IdHistoricoAsignaciones, ",
                                          "        nombre ",
                                          "   FROM HistoricoDeAsignacioneses ",
                                          "  WHERE nombre = @nombreHistoricoDeAsignaciones");

            var parametros = new Dictionary<string, object>();
            parametros.Add("nombreHistoricoDeAsignaciones", nombreHistoricoDeAsignaciones);
            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DataManager.GetInstance().ConsultaSql(strSql, parametros);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }



        internal bool Update(HistoricoAsignaciones oHistoricoDeAsignaciones)
        {
            string str_sql = "     UPDATE HistoricoDeAsignacioneses " +
                             "     SET nombre=@nombre" +
                             "     WHERE IdHistoricoAsignaciones=@IdHistoricoAsignaciones";

            var parametros = new Dictionary<string, object>();           
            parametros.Add("IdHistoricoAsignaciones", oHistoricoDeAsignaciones.IdHistoricoAsignaciones);


            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE
            return (DataManager.GetInstance().EjecutarSql(str_sql, parametros) == 1);
        }



        internal bool Delete(HistoricoAsignaciones oHistoricoDeAsignaciones)
        {
            string str_sql = "  UPDATE HistoricoDeAsignacioneses" +
                            "     SET borrado = 1" +
                            "     WHERE IdHistoricoAsignaciones=@IdHistoricoAsignaciones";

            var parametros = new Dictionary<string, object>();
            parametros.Add("IdHistoricoAsignaciones", oHistoricoDeAsignaciones.IdHistoricoAsignaciones);

            // Si una fila es afectada por la actualización retorna TRUE. Caso contrario FALSE
            return (DataManager.GetInstance().EjecutarSql(str_sql, parametros) == 1);
        }

        private HistoricoAsignaciones ObjectMapping(DataRow row)
        {
            HistoricoAsignaciones oHistoricoDeAsignaciones = new HistoricoAsignaciones
            {
                IdHistoricoAsignaciones = Convert.ToInt32(row["IdHistoricoAsignaciones"].ToString()),                
                FechaHistorico = Convert.ToDateTime(row["fecha_historico"].ToString())
        };

            return oHistoricoDeAsignaciones;
        }
    }
}

