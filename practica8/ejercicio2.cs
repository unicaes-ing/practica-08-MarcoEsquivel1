using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica8
{
    class ejercicio2
    {
        //Marco René Esquivel Juárez
        //25-sep-2019
        public struct Productos
        {
            public string nombre;
            private int cant;
            private decimal precio;

            public void setCantidad(int cant)
            {
                if (cant > 0)
                {
                    this.cant = cant;
                }
                else
                {
                    this.cant = 0;
                }
            }
            public int getCantidad()
            {
                return cant;
            }

            //----------------------------------------------------------

            public void setPrecio(decimal precio)
            {
                if (precio > 0)
                {
                    this.precio = precio;
                }
                else
                {
                    this.precio = 5.00m;
                }
            }
            public decimal getPrecio()
            {
                return precio + (precio * 0.13m);
            }
        }

        public void ejer2()
        {
            bool isInt;
            int cant;
            decimal total = 0;
            do
            {
                Console.WriteLine("¿Cuantos productos desea comprar?");
                isInt = int.TryParse(Console.ReadLine(), out cant);
            } while (isInt == false || cant < 1);

            Productos[] productos = new Productos[cant];

            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine("Nombre del producto {0}", i+1);
                productos[i].nombre = Console.ReadLine();
                Console.WriteLine("Cantidad del producto {0}", i +1);
                productos[i].setCantidad(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Precio del producto {0}",  i +1);
                productos[i].setPrecio(Convert.ToDecimal(Console.ReadLine()));
                Console.Clear();
                total = total + productos[i].getCantidad() * productos[i].getPrecio();
            }

            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine("Nombre del producto {0}: {1}", i+1, productos[i].nombre);
                Console.WriteLine("Cantidad del producto {0}: {1}", i + 1, productos[i].getCantidad());
                Console.WriteLine("Precio del producto {0}: {1:c2}", i + 1, productos[i].getPrecio());
                Console.WriteLine("======================================================");
            
            }

            Console.WriteLine("Total a pagar: "+ total.ToString("c2"));
            Console.ReadKey();
        }
    }
}
