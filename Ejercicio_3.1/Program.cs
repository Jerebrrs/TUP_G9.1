using System.Xml.Schema;

namespace Ejercicio_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vNum = new int[100];
            Random rnd = new Random();

            for (int i = 0; i < vNum.Length; i++)
            {
                vNum[i] = rnd.Next(100);
                Console.Write($" Pos:Num-{i}:{vNum[i]} ");
            }
            Console.WriteLine("----------------------------------------------");
            int numAzar = rnd.Next(0, 101);
            Console.WriteLine($"Numero al Azar Seleccionado: {numAzar}");
            int posEncontrada = BusquedaSecuencial(vNum, numAzar);
            if (posEncontrada != -1)
            {
                Console.WriteLine($"El numero {numAzar} se encuentra en la posicion: {posEncontrada}");
            }
            else
            {
                Console.WriteLine("El numero generado al azar no se encontro");
            }

            QuikSort(vNum, 0, vNum.Length - 1);

            Console.WriteLine("------Arreglo ordenado-------");
            for (int i = 0; i < vNum.Length; i++)
            {
                Console.Write($" Pos:Num-{i}:{vNum[i]} ");
            }

            int numeroEncontrado = BusquedaBinaria(vNum, numAzar, vNum.Length);
            if (numeroEncontrado != -1)
            {
                Console.WriteLine($"El numero {numAzar} se encuentra en la posicion: {numeroEncontrado}");
            }
            else
            {
                Console.WriteLine("El numero generado al azar no se encontro");
            }

            Console.ReadKey();
        }

        #region Metodos de busqueda
        static int BusquedaSecuencial(int[] vec, int numEnc)
        {
            int pos = -1, i = 0;

            while (pos == -1 && i < vec.Length)
            {
                if (vec[i] == numEnc)
                {
                    pos = i;
                }
                i++;
            }
            return pos;
        }

        static void QuikSort(int[] vect, int inicio, int fin)
        {
            if (inicio < fin)
            {
                int pivote = Particionar(vect, inicio, fin);
                QuikSort(vect, inicio, pivote - 1);
                QuikSort(vect, pivote + 1, fin);
            }


        }

        private static int Particionar(int[] vect, int inicio, int fin)
        {
            int pivote = vect[fin];
            int cont = inicio - 1;

            for (int i = inicio; i < fin; i++)
            {
                if (vect[i] <= pivote)
                {
                    cont++;

                    int aux = vect[cont];
                    vect[cont] = vect[i];
                    vect[i] = aux;
                }
            }
            int numPivot = vect[cont + 1];
            vect[cont + 1] = vect[fin];
            vect[fin] = numPivot;

            return cont + 1;
        }

        static int BusquedaBinaria(int[] vect, int numV, int tamaño)
        {
            int inicio = 0;
            int fin = tamaño;
            int centro, pos = -1;

            while (inicio <= fin && pos < 0)
            {
                centro = (inicio + fin) / 2;
                if (vect[centro] == numV)
                {
                    pos = centro;
                }
                else
                {
                    if (numV > vect[centro])
                    {
                        inicio = centro + 1;
                    }
                    else
                    {
                        fin = centro - 1;
                    }
                }

            }
            return pos;

        }
        #endregion
    }

}