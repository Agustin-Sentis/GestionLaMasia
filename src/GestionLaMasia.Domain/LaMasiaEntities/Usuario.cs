using GestionLaMasia.Domain.LaMasiaEnums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionLaMasia.Domain.LaMasiaEntities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string telefono { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public Rol rol { get; set; }
        public DateTimeOffset creadoEn { get; set; }
    }
}
