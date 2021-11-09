using System;
using System.Collections.Generic;
using System.Text;
using Pav2021.DataAccessLayer;
using Pav2021.Entities;

namespace Pav2021.BusinessLayer
{
    class PermisoService
    {
        private PermisoDao oPermisoDao;
        public PermisoService()
        {
            oPermisoDao = new PermisoDao();
        }
        public IList<Permiso> ObtenerTodos()
        {
            return oPermisoDao.GetAll();
        }
        internal bool CrearPermiso(Permiso oPermiso)
        {
            return oPermisoDao.Create(oPermiso);
        }
        internal bool ActualizarPermiso(Permiso oPermiso)
        {
            return oPermisoDao.Update(oPermiso);
        }

        internal bool EliminarPermiso(Permiso oPermiso)
        {
            return oPermisoDao.Delete(oPermiso);
        }
        internal object ObtenerPermiso(int idFormulario, int idPerfil)
        {

            return oPermisoDao.GetPermiso(idFormulario, idPerfil);
        }

        public IList<Permiso> ObtenerPermisoesFiltro(Dictionary<string, object> filtros)
        {
            return oPermisoDao.GetByFilters(filtros);
        }
    }
}
