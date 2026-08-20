using System;
using System.Collections.Generic;
using System.Text;

namespace GestionLaMasia.Domain.LaMasiaEntities
{
    public class HorarioCancha
    {
        public Guid Id { get; set; }
        public Cancha? cancha { get; set; }
        public short diaSemana { get; set; }
        public TimeSpan horaApertura { get; set; }
        public TimeSpan horaCierre { get; set; }
    }
}
