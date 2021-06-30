using System;

namespace Video51_Interfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico Av1 = new AvisosTrafico();
            Av1.MostrarAviso();
            AvisosTrafico Av2 = new AvisosTrafico("Policia de Transito de Guayaquil", "Multa de Exceso de Velocidad por 500 EUR", "03/06/2021");
            Av2.MostrarAviso();
        }
    }
}
