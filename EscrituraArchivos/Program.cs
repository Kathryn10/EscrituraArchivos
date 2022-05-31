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
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            //Si el archivo no existe, creará el elemento 
            //Si ya existe, escribirá en el 
            //True es para agregar y no sobreescribir


            string[] lines = new string[3];
            
            for (int i =0; i<3; i++)
            {
                Console.WriteLine("Escribe 3 nombres: ");
                lines[i] = Console.ReadLine();
            }

            //Recorrer el arreglo
            foreach (string line in lines)
            {
                sw.WriteLine(line); //Escribe en el archivo
            }
            sw.Close();   //Se debe cerrar el archivo

            Console.WriteLine("Escribiendo en el archivo...");
            Console.ReadLine();
        }
    }
}
