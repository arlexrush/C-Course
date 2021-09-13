using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Video110_Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria CuentaFamilia = new CuentaBancaria(2000);
            Thread[] hilosPersonas = new Thread[15];
            for(int i = 0; i < 15; i++)
            {
                Thread T = new Thread(CuentaFamilia.VamosRetirarEfectivo);
                T.Name = i.ToString();
                hilosPersonas[i] = T;
                
            }
            for (int i = 0; i < 15; i++)
            {
                hilosPersonas[i].Start();
                hilosPersonas[i].Join();                
            }

        }


    }

    class CuentaBancaria
    {
        double saldo { set; get; }
        public CuentaBancaria(double saldo)
        {
            this.saldo = saldo;
        }

        private Object objetoRetiroEfectivo = new object();
        public double RetirarEfectivo(double cantidad)
        {
            if (saldo - cantidad < 0)
            {
                Console.WriteLine("En la Hilo = {0}. Sin saldo suficiente para terminar esta Operación",(Thread.CurrentThread.Name));
                Console.WriteLine($"El Monto disponible en la cuenta es: {saldo}.");
            }

            lock(objetoRetiroEfectivo) {
                if (saldo >= cantidad)
                {
                    Console.WriteLine("Has retirado: {0} y te queda: {1} en la cuenta, este es un reporte para el Hilo = {2}", cantidad, (saldo - cantidad), (Thread.CurrentThread.Name));
                    saldo -= cantidad;
                }
                return saldo;
            }
        }

        public void VamosRetirarEfectivo()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Estas Intentando retirar dinero a traves del Hilo {0}",(Thread.CurrentThread.Name));
                RetirarEfectivo(500);
            }
        }
    }
}
