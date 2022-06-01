using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace EscrituraArchivos
{
    class Program
    {
        public class Peliculas
        {
            public string[] Pelicula = new string[3];
            public int[] Año = new int[3];


            public Peliculas(string [] Pelicula, int [] Año)
            {
                this.Pelicula = Pelicula;
                this.Año = Año;
            }
        }
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            //Si el archivo no existe, creará el elemento 
            //Si ya existe, escribirá en el 
            //True es para agregar y no sobreescribir

            string[] Pelicula = new string[3];
            int[] Año = new int[3];

            for (int i = 0; i<3; i++)
            {
                Console.WriteLine("Escribe el nombre de película: ");
                Pelicula[i] = Console.ReadLine();

                Console.WriteLine("Escriba el año de la película: ");
                Año[i] = int.Parse(Console.ReadLine());
            }

            foreach (var kw in Pelicula.Zip(Año,Tuple.Create))  //Ahorrar llaves y otro foreach usando Tuple
            {
                    sw.WriteLine(kw.Item1 + " del año " + kw.Item2);
            }

            sw.Close();   //Se debe cerrar el archivo

            Console.WriteLine("\nEscribiendo en el archivo...");
            Console.ReadKey();
        }
    }
}
