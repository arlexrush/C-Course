using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video51_Interfaces1
{
    class AvisosTrafico : InAvisos
    {
        // Constructores
        public AvisosTrafico()
        {
            remitente = "DDGT";
            mensaje = "Sanción Cometida, Cancele antes de 3 dias y se beneficiará de un descuento del 10%";
            fecha ="";
        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }

        //fin constructores
        public string GetFecha()
        {
            return fecha;
        }

        public void MostrarAviso()
        {
            Console.WriteLine("Mensaje {0} ha sido enviado por {1} el dia {2}", mensaje, remitente, fecha); ;
        }

        private string remitente;
        private string mensaje;
        private string fecha;

       


    }
}
