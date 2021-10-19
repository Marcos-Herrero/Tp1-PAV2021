using System;
using System.Collections.Generic;
using System.Text;
using TpPav.DataAccessLayer;
using TpPav.Entities;

namespace TpPav.BusinessLayer
{
    class UsuarioService
    {
        private UsuarioDao oUsuarioDao;
        public UsuarioService()
        {
            oUsuarioDao = new UsuarioDao();
        }

        public IList<Usuario> getUsuariosList()
        {
            return oUsuarioDao.GetUsuarios();
        }
        public Usuario ValidarUsuarioAdm(string usuario, string password)
        {
            var usr = oUsuarioDao.GetUser(usuario);

            if (usr.Password != null && usr.Password.Equals(password))
            {
                return usr;
            }

            return null;
        }

        public IList<string> ObtenerEstados()
        {
            return oUsuarioDao.GetEstado();
        }

        internal object ObtenerUsuario(string usuario)
        {

            return oUsuarioDao.GetUser(usuario);
        }

        internal bool CrearUsuario(Usuario oUsuario)
        {
            return oUsuarioDao.Create(oUsuario);
        }

        internal bool ActualizarUsuario(Usuario oUsuarioSelected)
        {
            return oUsuarioDao.Update(oUsuarioSelected);
        }

        internal bool EliminarUsuario(Usuario oUsuarioSelected)
        {
            return oUsuarioDao.Delete(oUsuarioSelected);
        }

        public IList<Usuario> ConsultarUsuarioConFiltros(Dictionary<string, object> parametros)
        {
            return oUsuarioDao.GetUsuariosByFilters(parametros);
        }
    }
}
