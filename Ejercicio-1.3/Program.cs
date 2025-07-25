using System;

namespace Ejercicio_135
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numAleatorios = new int[30];
            Random rnd = new Random();

            for (int i = 0; i < 30; i++)
            {
                numAleatorios[i] = i + 1;
            }

            int cantidad = 30;

            for (int i = 0; i < 10; i++)
            {
                int indice = rnd.Next(0, cantidad);
                int valorExtraido = numAleatorios[indice];

                Console.WriteLine($"Extracción {i + 1}: número en índice {indice} = {valorExtraido}");

                numAleatorios[indice] = numAleatorios[cantidad - 1];
                cantidad--;
            }

          
        }
    }
}