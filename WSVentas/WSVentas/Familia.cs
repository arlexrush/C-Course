using System;


namespace WSVentas
{
    public class Familia
    {
        public int id { get; set; }

        public string Padre { get; set; }

        public string Madre { get; set; }

        public int Patrimonio_Usd { get; set; }

        public int Patrimonio_Ves => Patrimonio_Usd * 2700000;
    }
}
