using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica8
{
    class ejercicio1
    {
        //Marco René Esquivel Juárez
        //25-sep-2019
        public struct Estudiantes
        {
            public string nombre;
            public string carnet;
            public string carrera;
            private decimal cum;

            public void setCum(decimal cum)
            {
                if (cum >= 0 && cum <= 10)
                {
                    this.cum = cum;
                }
            }

            public decimal getCum()
            {
                return cum;
            }
        }
        public void ejer1()
        {
            Estudiantes estudiante = new Estudiantes();
            Console.WriteLine("Nombre del estudiante: ");
            estudiante.nombre = Console.ReadLine();
            Console.WriteLine("Carnet : ");
            estudiante.carnet = Console.ReadLine();
            Console.WriteLine("Carrera : ");
            estudiante.carrera = Console.ReadLine();
            Console.WriteLine("CUM: ");
            estudiante.setCum(Convert.ToDecimal(Console.ReadLine()));
            Console.Clear();

            Console.WriteLine("Estudiante: " + estudiante.nombre);
            Console.WriteLine("Carnet: " + estudiante.carnet);
            Console.WriteLine("Carrera: " + estudiante.carrera);
            Console.WriteLine("CUM: " + estudiante.getCum());
            Console.ReadKey();
        }
    }
}
