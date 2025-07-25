using System.Diagnostics.Contracts;

namespace Ejercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] libretas = new int[100];
            int[] notas = new int[100];
            string[] nombres = new string[100];
            int libreta,mayor=0,menor=0;
            int cont = 0,sumaNotas=0;
            double promedio;


            do
            {
                
                Console.WriteLine("Ingrese el numero de libreta del alumno:");
                libreta = Convert.ToInt32(Console.ReadLine());
                if (libreta != -1)
                {
                    libretas[cont] = libreta;
                    Console.WriteLine("Ingrese el nombre del alumno:");
                    nombres[cont] = Console.ReadLine();
                    Console.WriteLine("Ingrese la nota del alumno:");
                    notas[cont] = Convert.ToInt32(Console.ReadLine());
                    cont++;
                }
            } while (libreta != -1);

            if (cont > 0)
            {
                for (int i = 0; i < cont; i++)
                {
                    sumaNotas += notas[i];
                }
                promedio = (double)sumaNotas / cont;
                Console.WriteLine($"El promedio de las notas es:{promedio}");


                for (int i = 0; i < cont; i++)
                {
                    if (notas[i] > notas[mayor])
                        mayor = i;

                    if (notas[i] < notas[menor])
                        menor = i;
                }

                Console.WriteLine("\nAlumno con la MAYOR nota:");
                Console.WriteLine($"Nombre: {nombres[mayor]} - Libreta: {libretas[mayor]} - Nota: {notas[mayor]}");

                Console.WriteLine("\nAlumno con la MENOR nota:");
                Console.WriteLine($"Nombre: {nombres[menor]} - Libreta: {libretas[menor]} - Nota: {notas[menor]}");
            }
            else
            {
                Console.WriteLine("No se ingresaron alumnos.");
            }

            
        }
    }
}