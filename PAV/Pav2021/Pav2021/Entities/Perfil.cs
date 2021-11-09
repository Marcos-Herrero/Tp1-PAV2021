using System;
using System.Collections.Generic;
using System.Text;

namespace Pav2021.Entities
{    public class Perfil
    {
        public int Id_Perfil { get; set; }
        public string Nombre { get; set; }
        public bool borrado { get; set; }
        public IList<Permiso> DetallePermisos { get; set; }


        public override string ToString()
        {
            return Nombre;
        }
    }
}
