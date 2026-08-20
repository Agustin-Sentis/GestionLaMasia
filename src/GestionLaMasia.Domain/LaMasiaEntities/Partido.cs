using GestionLaMasia.Domain.LaMasiaEnums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionLaMasia.Domain.LaMasiaEntities
{
    public class Partido
    {
        public Guid Id { get; set; }
        public Cancha? cancha { get; set; }
        public Reserva? reserva { get; set; }
        public Equipo? equipoLocal { get; set; }
        public Equipo? equipoVisitante { get; set; }
        public DateTimeOffset inicio { get; set; }
        public DateTimeOffset fin { get; set; }
        public short? golesLocal { get; set; }
        public short? golesVisitante { get; set; }
        public EstadoPartido estado { get; set; }
        public Usuario? cargadoPor { get; set; }
        public DateTimeOffset creadoEn { get; set; }
    }
}
