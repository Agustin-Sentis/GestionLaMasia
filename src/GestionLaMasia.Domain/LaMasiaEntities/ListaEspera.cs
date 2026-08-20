using GestionLaMasia.Domain.LaMasiaEnums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionLaMasia.Domain.LaMasiaEntities
{
    public class ListaEspera
    {
        public Guid Id { get; set; }
        public Cancha? cancha { get; set; }
        public Equipo? equipo { get; set; }
        public Usuario? usuario { get; set; }
        public DateTimeOffset inicioSolicitado { get; set; }
        public DateTimeOffset finSolicitado { get; set; }
        public int posicion { get; set; }
        public EstadoListaEspera estado { get; set; }
        public DateTimeOffset? venceOfertaEn { get; set; }
        public DateTimeOffset creadoEn { get; set; }
    }
}
