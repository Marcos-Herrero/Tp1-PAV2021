using System;
using System.Collections.Generic;
using System.Text;

namespace TpPav.Entities
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public Perfil Perfil { get; set; }
        public string UsuarioNombre { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public char Estado { get; set; }
        public bool Borrado{ get; set; }

        public override string ToString()
        {
            return UsuarioNombre;
        }
    }
}
