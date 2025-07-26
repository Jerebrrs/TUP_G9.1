namespace Ejercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vNum = new int[100];
            Random rnd = new Random();
            string[] nombres = { "Noemí", "Noelía", "Andrés", "Emilio", "Norberto", "Estefanía", "Daniela", "Valeria" };
            string[] nombresAleatorio = new string[100];

            for (int i = 0; i < vNum.Length; i++)
            {
                vNum[i] = rnd.Next(1, 100);
                int numRnd = rnd.Next(0, nombres.Length);
                nombresAleatorio[i] = nombres[numRnd];
            }
            Console.WriteLine("=== Listado original ===");
            MostrarListado(vNum, nombresAleatorio);

            int[] vNumBurbuja = new int[vNum.Length];
            string[] nombresBurbuja = new string[nombresAleatorio.Length];

            int[] vNumQuick = new int[vNum.Length];
            string[] nombresQuick = new string[nombresAleatorio.Length];

            for (int i = 0; i < vNum.Length; i++)
            {
                vNumBurbuja[i] = vNum[i];
                nombresBurbuja[i] = nombresAleatorio[i];

                vNumQuick[i] = vNum[i];
                nombresQuick[i] = nombresAleatorio[i];
            }

            Burbuja(vNumBurbuja, nombresBurbuja);
            Console.WriteLine("\n=== Ordenado con Burbuja ===");
            MostrarListado(vNumBurbuja, nombresBurbuja);


            QuickSort(vNumQuick, nombresQuick, 0, vNumQuick.Length - 1);
            Console.WriteLine("\n=== Ordenado con QuickSort ===");
            MostrarListado(vNumQuick, nombresQuick);
        }
        static void MostrarListado(int[] numeros, string[] nombres)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Inidice :{i} , Numero: {numeros[i]} , Nombre: {nombres[i]} .");

            }
        }

        #region Ordenamiento Burubuja Quiksort
        static void Burbuja(int[] numeros, string[] nombres)
        {
            int n = numeros.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        // Intercambiar números
                        int tempNum = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = tempNum;

                        // Intercambiar nombres correspondientes
                        string tempNom = nombres[j];
                        nombres[j] = nombres[j + 1];
                        nombres[j + 1] = tempNom;
                    }
                }
            }
        }

        static void QuickSort(int[] numeros, string[] nombres, int inc, int fin)
        {
            if (inc < fin)
            {
                int pivote = Particionar(numeros, nombres, inc, fin);
                QuickSort(numeros, nombres, inc, pivote - 1);
                QuickSort(numeros, nombres, pivote + 1, fin);
            }
        }

        private static int Particionar(int[] numeros, string[] nombres, int inc, int fin)
        {
            int pivote = numeros[fin];
            int cont = inc - 1;

            for (int i = inc; i < fin; i++)
            {
                if (numeros[i] <= pivote)
                {
                    cont++;

                    int tempNum = numeros[cont];
                    numeros[cont] = numeros[i];
                    numeros[i] = tempNum;

                    // Intercambiar nombres
                    string tempNom = nombres[cont];
                    nombres[cont] = nombres[i];
                    nombres[i] = tempNom;
                }
            }
            int tempNumPivot = numeros[cont + 1];
            numeros[cont + 1] = numeros[fin];
            numeros[fin] = tempNumPivot;

            string tempNomPivot = nombres[cont + 1];
            nombres[cont + 1] = nombres[fin];
            nombres[fin] = tempNomPivot;

            return cont + 1;
        }
        #endregion
    }

}