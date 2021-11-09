using System;
using System.Collections.Generic;
using System.Text;

namespace Pav2021.Entities
{
    public class Formulario
    {
        public int Id_Formulario { get; set; }
        public string Nombre { get; set; }
        public bool borrado { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
