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
            public string Pelicula;
            public int Año;

            public Peliculas(string Pelicula, int  Año)
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

            string Pelicula;
            int Año;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Escribe el nombre de película: ");
                Pelicula = Console.ReadLine();
                Console.WriteLine("Escriba el año de la película: ");
                Año = int.Parse(Console.ReadLine());

                Console.Clear();

                Peliculas Peli = new Peliculas(Pelicula, Año);

                sw.WriteLine(Peli.Pelicula + "\t" + Peli.Año);
            }
            sw.Close();   //Se debe cerrar el archivo

            Console.WriteLine("\nEscribiendo en el archivo...");
            Console.ReadKey();
        }
    }
}
