using GestionLaMasia.Domain.LaMasiaEnums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionLaMasia.Domain.LaMasiaEntities
{
    public class BusquedaRival
    {
        public Guid Id { get; set; }
        public Equipo? equipoCreador { get; set; }
        public Cancha? cancha { get; set; }
        public DateTimeOffset inicio { get; set; }
        public DateTimeOffset fin { get; set; }
        public EstadoBusquedaRival estado { get; set; }
        public Equipo? equipoRival { get; set; }
        public DateTimeOffset creadoEn { get; set; }
    }
}
