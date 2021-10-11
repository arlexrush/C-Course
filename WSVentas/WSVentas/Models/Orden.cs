using System;
using System.Collections.Generic;

#nullable disable

namespace WSVentas.Models
{
    public partial class Orden
    {
        public Orden()
        {
            DetalleOrdens = new HashSet<DetalleOrden>();
        }

        public long IdOrden { get; set; }
        public long IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

        public virtual ClienteOrden IdClienteNavigation { get; set; }
        public virtual ICollection<DetalleOrden> DetalleOrdens { get; set; }
    }
}
