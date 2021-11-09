using System;
using System.Collections.Generic;
using System.Text;

namespace Pav2021.Entities
{
    public class HistoricoAsignaciones
    {
        public int IdHistoricoAsignaciones { get; set; }        
        public DateTime FechaHistorico { get; set; }
        public Perfil Perfil { get; set; }

    }
}
