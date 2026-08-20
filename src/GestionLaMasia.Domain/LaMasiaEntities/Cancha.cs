using System;
using System.Collections.Generic;
using System.Text;

namespace GestionLaMasia.Domain.LaMasiaEntities
{
    public class Cancha
    {
        public Guid Id { get; set; }
        public string nombre { get; set; } = string.Empty;
        public short capacidadJugadores { get; set; }
        public decimal precioPorHora { get; set; }
        public string descripcion { get; set; } = string.Empty;
        public bool activa { get; set; }
        public DateTimeOffset creadoEn { get; set; }
    }
}
