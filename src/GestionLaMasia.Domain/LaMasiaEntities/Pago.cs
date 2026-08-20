using GestionLaMasia.Domain.LaMasiaEnums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionLaMasia.Domain.LaMasiaEntities
{
    public class Pago
    {
        public Guid Id { get; set; }
        public Reserva? reserva { get; set; }
        public decimal monto { get; set; }
        public MetodoPago metodoPago { get; set; }
        public EstadoPagoTransaccion estado { get; set; }
        public string? referenciaExterna { get; set; }
        public DateTimeOffset? pagadoEn { get; set; }
        public DateTimeOffset creadoEn { get; set; }
    }
}
