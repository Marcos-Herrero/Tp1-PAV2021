using System;
using System.Collections.Generic;
using System.Text;
using TpPav.DataAccessLayer;
using TpPav.Entities;

namespace TpPav.BusinessLayer
{
    public class PerfilService
    {
        private PerfilDao oPerfilDao;
        public PerfilService()
        {
            oPerfilDao = new PerfilDao();
        }
        public Perfil ObtenerPerfilPorID(int id)
        {
            return oPerfilDao.GetPermisoByID(id);
        }
        public IList<Perfil> ObtenerTodos()
        {
            return oPerfilDao.GetAll();
        }
        internal bool CrearPerfil(Perfil oPerfil)
        {
            return oPerfilDao.Create(oPerfil);
        }
        internal bool ActualizarPerfil(Perfil oPerfil)
        {
            return oPerfilDao.Update(oPerfil);
        }

        internal bool EliminarPerfil(Perfil oPerfil)
        {
            return oPerfilDao.Delete(oPerfil);
        }
        internal object ObtenerPErfil(string nombre)
        {

            return oPerfilDao.GetPerfil(nombre);
        }

        public IList<Perfil> ObtenerPerfilesFiltro(Dictionary<string, object> filtros)
        {
            return oPerfilDao.GetByFilters(filtros);
        }
    }
}
