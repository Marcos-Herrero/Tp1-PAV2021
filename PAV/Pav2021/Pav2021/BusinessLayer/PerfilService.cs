using System;
using System.Collections.Generic;
using System.Text;
using Pav2021.DataAccessLayer;
using Pav2021.Entities;

namespace Pav2021.BusinessLayer
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
        internal object ObtenerPerfil(string nombre)
        {

            return oPerfilDao.GetPerfil(nombre);
        }

        public IList<Perfil> ObtenerPerfilesFiltro(Dictionary<string, object> filtros)
        {
            return oPerfilDao.GetByFilters(filtros);
        }
        internal bool ValidarDatos(Perfil per)
        {
            if (per.DetallePermisos.Count == 0)
            {
               throw new Exception("Debe selecionar al menos un formulario para el perfil.");
            }
            Perfil validacion= (Perfil)ObtenerPerfil(per.Nombre);
            if(validacion!=null)
            {
                throw new Exception("El nombre del perfil ya existe.");
            }

            return true;
        }
    }
}
