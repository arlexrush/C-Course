using System;
using System.Collections.Generic;

#nullable disable

namespace WSVentas.Models
{
    public partial class ClienteOrden
    {
        public ClienteOrden()
        {
            Ordens = new HashSet<Orden>();
        }

        public long IdCliente { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Orden> Ordens { get; set; }
    }
}
