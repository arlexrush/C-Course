using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace User.API.Models.Responses
{
    public class ResponseType
    {
        public int Exito { get; set; }
        public string Mensaje { get; set; }
        public Object Data { get; set; }

        public ResponseType()
        {
            this.Exito = 0;
        }
    }
}
