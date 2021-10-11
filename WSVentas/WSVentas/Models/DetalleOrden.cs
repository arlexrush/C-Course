using System;
using System.Collections.Generic;

#nullable disable

namespace WSVentas.Models
{
    public partial class DetalleOrden
    {
        public long IdDetalle { get; set; }
        public long IdOrden { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal SubTotal { get; set; }
        public int IdProducto { get; set; }

        public virtual Orden IdOrdenNavigation { get; set; }
        public virtual InventarioProducto IdProductoNavigation { get; set; }
    }
}
