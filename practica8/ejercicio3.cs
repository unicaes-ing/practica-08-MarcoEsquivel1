using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica8
{
    class ejercicio3
    {
        //Marco René Esquivel Juárez
        //25-sep-2019
        public struct Materia
        {
            public string nombre;
            private decimal nota;

            public void setNota(decimal nota)
            {
                if (nota >= 0 && nota <=10)
                {
                    this.nota = nota;
                }
                else
                {
                    setNota(Convert.ToInt32(Console.ReadLine()));
                }
            }
            public decimal getNota()
            {
                return nota;
            }  
            
            public string Resultado()
            {
                string res;
                if (nota > 6)
                {
                    res = "Aprobado";
                }
                else
                {
                    res = "Reprobado";
                }
                return res;
            }
        }
        public struct Alumnos
        {
            public string carnet;
            public string nombre;
            public string carrera;
            public Materia materia1;
            public Materia materia2;
            public Materia materia3;
            public Materia materia4;
        }

        public void ejer3()
        {
            int nAlumnos;
            Console.WriteLine("Ingrese la cantidad de alumnos");
            nAlumnos = Convert.ToInt32(Console.ReadLine());
            Alumnos[] alumnos = new Alumnos[nAlumnos];
            Console.Clear();
            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del alumno {0}", i+1);
                alumnos[i].nombre = Console.ReadLine();
                Console.WriteLine("Carnet del alumno {0}", i+1);
                alumnos[i].carnet = Console.ReadLine();
                Console.WriteLine("Carrera del alumno {0}", i+1);
                alumnos[i].carrera = Console.ReadLine();
                Console.WriteLine("Nombre de la materia 1");
                alumnos[i].materia1.nombre = Console.ReadLine();
                Console.WriteLine("Nota de la materia 1");
                alumnos[i].materia1.setNota(Convert.ToDecimal(Console.ReadLine()));
                Console.WriteLine("Nombre de la materia 2");
                alumnos[i].materia2.nombre = Console.ReadLine();
                Console.WriteLine("Nota de la materia 2");
                alumnos[i].materia2.setNota(Convert.ToDecimal(Console.ReadLine()));
                Console.WriteLine("Nombre de la materia 3");
                alumnos[i].materia3.nombre = Console.ReadLine();
                Console.WriteLine("Nota de la materia 3");
                alumnos[i].materia3.setNota(Convert.ToDecimal(Console.ReadLine()));
                Console.WriteLine("Nombre de la materia 4");
                alumnos[i].materia4.nombre = Console.ReadLine();
                Console.WriteLine("Nota de la materia 4");
                alumnos[i].materia4.setNota(Convert.ToDecimal(Console.ReadLine()));
                Console.Clear();
            }

            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine("Nombre del alumno {0}: {1}", i + 1, alumnos[i].nombre);
                Console.WriteLine("{0}: nota: {1} resultado: {2}", alumnos[i].materia1.nombre, alumnos[i].materia1.getNota(), alumnos[i].materia1.Resultado());
                Console.WriteLine("{0}: nota: {1} resultado: {2}", alumnos[i].materia2.nombre, alumnos[i].materia2.getNota(), alumnos[i].materia2.Resultado());
                Console.WriteLine("{0}: nota: {1} resultado: {2}", alumnos[i].materia3.nombre, alumnos[i].materia3.getNota(), alumnos[i].materia3.Resultado());
                Console.WriteLine("{0}: nota: {1} resultado: {2}", alumnos[i].materia4.nombre, alumnos[i].materia4.getNota(), alumnos[i].materia4.Resultado());
                Console.WriteLine("------------------------------------------------------------------------------------------");

            }
            Console.ReadKey();
        }
    }
}
