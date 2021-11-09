using System;
using System.Collections.Generic;
using System.Text;
using Pav2021.DataAccessLayer;
using Pav2021.Entities;

namespace Pav2021.BusinessLayer
{
    class FormularioService
    {
        private FormularioDao oFormularioDao;
        public FormularioService()
        {
            oFormularioDao = new FormularioDao();
        }
        public IList<Formulario> ObtenerTodos()
        {
            return oFormularioDao.GetAll();
        }
        internal bool CrearFormulario(Formulario oFormulario)
        {
            return oFormularioDao.Create(oFormulario);
        }
        public Formulario ObtenerFormPorID(int id)
        {
            return oFormularioDao.GetFormularioByID(id);
        }
        internal bool ActualizarFormulario(Formulario oFormulario)
        {
            return oFormularioDao.Update(oFormulario);
        }

        internal bool EliminarFormulario(Formulario oFormulario)
        {
            return oFormularioDao.Delete(oFormulario);
        }
        internal object ObtenerFormulario(string nombre)
        {

            return oFormularioDao.GetFormulario(nombre);
        }

        public IList<Formulario> ObtenerFormularioesFiltro(Dictionary<string, object> filtros)
        {
            return oFormularioDao.GetByFilters(filtros);
        }
    }
}
