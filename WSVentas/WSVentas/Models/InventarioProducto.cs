using System;
using System.Collections.Generic;

#nullable disable

namespace WSVentas.Models
{
    public partial class InventarioProducto
    {
        public InventarioProducto()
        {
            DetalleOrdens = new HashSet<DetalleOrden>();
        }

        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Costo { get; set; }

        public virtual ICollection<DetalleOrden> DetalleOrdens { get; set; }
    }
}
