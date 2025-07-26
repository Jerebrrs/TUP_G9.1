namespace Ejercicio_21
{
    class Program
    {
        static int[] num = new int[100];
        static void Main(string[] args)
        {
            Console.Write("");

            Random rnd = new Random();

            for (int i = 0; i < num.Length; i++)
            {
                int numRnadom = rnd.Next(0, 200);
                num[i] = numRnadom;
            }

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($" - {i + 1}:{num[i]}");
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Listado ordenado de Mayor a menor:");

            ordenarBurbuja(num);
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($" - {num[i]}");
            }

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Listado ordenada Quicksort de Menor a mayor:");

            QuickSort(num, 0, num.Length - 1);
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($" - {num[i]}");
            }

            int numBuscado = rnd.Next(0, 200);

            Console.WriteLine($"Numero a buscar: {numBuscado}");
            int numEncontrado = Busqueda(num, numBuscado);

            if (numEncontrado != -1)
            {

                Console.WriteLine($"El numero se encuentra en la posicion: {numEncontrado}");
            }
            else
            {
                Console.WriteLine($"El numero no se encontro.");
            }

            Console.ReadKey();
        }
        #region Metodos de ordenamiento
        static void ordenarBurbuja(int[] vector)
        {
            for (int i = 0; i < vector.Length - 1; i++)
            {
                for (int j = i + 1; j < vector.Length; j++)
                {
                    if (vector[i] < vector[j])
                    {
                        int aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }

                }

            }
        }

        static void QuickSort(int[] vector, int inicio, int fin)
        {
            if (inicio >= fin)
                return;

            int pivote = vector[inicio];
            int izquierda = inicio + 1;
            int derecha = fin;

            while (izquierda <= derecha)
            {
                while (izquierda <= fin && vector[izquierda] < pivote)
                    izquierda++;

                while (derecha > inicio && vector[derecha] >= pivote)
                    derecha--;

                if (izquierda < derecha)
                {
                    int temp = vector[izquierda];
                    vector[izquierda] = vector[derecha];
                    vector[derecha] = temp;
                }
            }

            // Intercambio del pivote con el valor en 'derecha'
            vector[inicio] = vector[derecha];
            vector[derecha] = pivote;

            // Llamadas recursivas
            QuickSort(vector, inicio, derecha - 1);
            QuickSort(vector, derecha + 1, fin);
        }
        #endregion

        static int Busqueda(int[] vector, int vBuscado)
        {
            int pos = -1;
            int cont = 0;
            while (pos == -1 && cont < vector.Length)
            {
                if (vector[cont] == vBuscado)
                {
                    pos = cont;
                }
                cont++;
            }
            return pos;

        }
    }

}