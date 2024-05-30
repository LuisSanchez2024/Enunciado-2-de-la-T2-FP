using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enunciado_2_de_la_T2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> números = new List<int>();

            // Insertar números aleatorios en la lista
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                int numero_Aleatorio = rand.Next(1, 101); // números entre 1 y 100
                números.Add(numero_Aleatorio);
            }

            Console.WriteLine("Números insertados en la lista:");
            foreach (var número in números)
            {
                Console.Write(número + " ");
            }
            Console.WriteLine();

            // Ordenar de forma ascendente
            números.Sort();
            Console.WriteLine("Números ordenados de manera ascendente:");
            foreach (var número in números)
            {
                Console.Write(número + " ");
            }
            Console.WriteLine();

            // Ordenar de forma descendente
            números.Reverse();
            Console.WriteLine("Números ordenados de manera descendente:");
            foreach (var número in números)
            {
                Console.Write(número + " ");
            }
            Console.WriteLine();

            // Buscar un elemento en la lista
            Console.Write("Ingresa un número para buscar en la lista: ");
            int numero_Buscado = Convert.ToInt32(Console.ReadLine());
            if (números.Contains(numero_Buscado))
            {
                Console.WriteLine($"El número {numero_Buscado} está en la lista.");
            }
            else
            {
                Console.WriteLine($"El número {numero_Buscado} no está en la lista.");
            }

            // Eliminar un número y mostrar la lista actualizada
            Console.Write("Ingresa un número para eliminar de la lista: ");
            int numero_Eliminar = Convert.ToInt32(Console.ReadLine());
            if (números.Remove(numero_Eliminar))
            {
                Console.WriteLine($"El número {numero_Eliminar} se eliminó de la lista.");
            }
            else
            {
                Console.WriteLine($"El número {numero_Eliminar} no estaba en la lista.");
            }

            Console.WriteLine("Lista actualizada:");
            foreach (var número in números)
            {
                Console.Write(número + " ");
            }
            Console.WriteLine();
        }
    }
}
