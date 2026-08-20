using System;
using System.Collections.Generic;
using System.Text;

namespace GestionLaMasia.Domain.LaMasiaEntities
{
    public class Equipo
    {
        public Guid Id { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string telefono_contacto { get; set; } = string.Empty;
        public Usuario? usuario { get; set; }
        public DateTimeOffset creadoEn { get; set; }
    }
}
