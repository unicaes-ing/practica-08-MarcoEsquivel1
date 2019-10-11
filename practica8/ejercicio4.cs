using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica8
{
    class ejercicio4
    {
        //Marco René Esquivel Juárez
        //25-sep-2019
        public enum tipoPago
        {
            Efectivo = 1, TargetaDebito = 2, TargetaCredito = 3
        }
        public void ejer4()
        {
            decimal pagar;
            int metodo;
            Console.WriteLine("Ingrese el precio a pagar");
            pagar = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo de pago");
            Console.WriteLine("1- Efectivo \n2- Targeta de debito \n3- Targeta de credito");
            metodo = Convert.ToInt32(Console.ReadLine());

            switch ((tipoPago)metodo)
            {
                case tipoPago.Efectivo:
                    pagar = pagar - (pagar * 0.15m);
                    break;
                case tipoPago.TargetaDebito:
                    pagar = pagar - (pagar * 0.15m);
                    break;
                case tipoPago.TargetaCredito:
                    pagar = pagar - (pagar * 0.15m);
                    break;
            }
            Console.WriteLine("Total a pagar: {0:c2}", pagar);
            Console.ReadKey();
        }
    }
}
