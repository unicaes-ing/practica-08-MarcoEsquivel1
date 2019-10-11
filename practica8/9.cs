using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica8
{
    class ejer2
    {
        public static decimal[][] notas;
        static void Main(string[] args)
        {
            int cMaterias, alumnos, op;
            Console.WriteLine("Ingrese la cantidad de materias que desea tener: ");
            cMaterias = Convert.ToInt32(Console.ReadLine());
            notas = new decimal[cMaterias][];
            Console.Clear();
            for (int j = 0; j < cMaterias; j++)
            {
                Console.WriteLine("Cuantos alumnos tiene el grupo {0}?", j + 1);
                alumnos = Convert.ToInt32(Console.ReadLine());
                notas[j] = new decimal[alumnos];
                Console.Clear();
            }
            do
            {
                Console.WriteLine("1-Ingresar notas");
                Console.WriteLine("2-Mostrar promedio de materia");
                Console.WriteLine("3-Salir");
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        capturar(cMaterias);
                        break;
                    case 2:
                        promedioM();
                        break;
                }
            } while (op != 3);

        }

        static void capturar(int c)
        {
            Console.Clear();
            for (int i = 0; i < c; i++)
            {
                Console.Clear();
                Console.WriteLine("Ingrese las notas del grupo {0}", i + 1);
                for (int j = 0; j < notas[i].Length; j++)
                {
                    Console.WriteLine("Ingrese la nota del alumno {0}", j + 1);
                    notas[i][j] = Convert.ToDecimal(Console.ReadLine());
                }

            }
            Console.WriteLine("Notas ingresadas presione enter");
            Console.ReadKey();
            Console.Clear();
        }

        static void promedioM()
        {
            Console.Clear();
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("El promedio de la materia {0} es: {1}", i + 1, notas[i].Average());
            }
            Console.WriteLine("presione enter para regresar al menú");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
