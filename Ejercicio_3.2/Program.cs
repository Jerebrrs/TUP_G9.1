namespace Ejercicio_32
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vNum = new int[100];
            Random rnd = new Random();
            string[] nombres = { "Noemí", "Noelía", "Andrés", "Emilio", "Norberto", "Estefanía", "Daniela", "Valeria" };


            for (int i = 0; i < vNum.Length; i++)
            {
                vNum[i] = rnd.Next(1, 100);
            }

            int posAzar = rnd.Next(100);
        }

    }

}