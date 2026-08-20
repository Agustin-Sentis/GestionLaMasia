using GestionLaMasia.Domain.LaMasiaEnums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionLaMasia.Domain.LaMasiaEntities
{
    public class Reserva
    {
        public Guid Id { get; set; }
        public Cancha? cancha { get; set; }
        public Equipo? equipo { get; set; }
        public Usuario? usuario { get; set; }
        public DateTimeOffset inicio { get; set; }
        public DateTimeOffset fin { get; set; }
        public EstadoReserva estado { get; set; }
        public MetodoPago metodoPago { get; set; }
        public EstadoPago estadoPago { get; set; }
        public DateTimeOffset creadoEn { get; set; }
    }
}
