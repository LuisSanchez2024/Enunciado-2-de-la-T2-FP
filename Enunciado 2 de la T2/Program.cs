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

            List<int> numeros = new List<int>();

            // Insertar números aleatorios en la lista
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                int numeroAleatorio = rand.Next(1, 101); // Genera números entre 1 y 100
                numeros.Add(numeroAleatorio);
            }

            Console.WriteLine("Números insertados en la lista:");
            foreach (var numero in numeros)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();

            // Ordenar de forma ascendente
            numeros.Sort();
            Console.WriteLine("Números ordenados de forma ascendente:");
            foreach (var numero in numeros)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();

            // Ordenar de forma descendente
            numeros.Reverse();
            Console.WriteLine("Números ordenados de forma descendente:");
            foreach (var numero in numeros)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();

            // Buscar un elemento en la lista
            Console.Write("Ingresa un número para buscar en la lista: ");
            int numeroBuscado = Convert.ToInt32(Console.ReadLine());
            if (numeros.Contains(numeroBuscado))
            {
                Console.WriteLine($"El número {numeroBuscado} está en la lista.");
            }
            else
            {
                Console.WriteLine($"El número {numeroBuscado} no está en la lista.");
            }

            // Eliminar un número y mostrar la lista actualizada
            Console.Write("Ingresa un número para eliminar de la lista: ");
            int numeroEliminar = Convert.ToInt32(Console.ReadLine());
            if (numeros.Remove(numeroEliminar))
            {
                Console.WriteLine($"El número {numeroEliminar} se eliminó de la lista.");
            }
            else
            {
                Console.WriteLine($"El número {numeroEliminar} no estaba en la lista.");
            }

            Console.WriteLine("Lista actualizada:");
            foreach (var numero in numeros)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
        }
    }
}
