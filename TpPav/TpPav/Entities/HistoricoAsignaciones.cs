﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TpPav.Entities
{
    class HistoricoAsignaciones
    {
        public int IdHistoricoAsignaciones { get; set; }        
        public DateTime FechaHistorico { get; set; }
        public Perfil Perfil { get; set; }

    }
}