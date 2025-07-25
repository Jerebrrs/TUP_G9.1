namespace Ejercicio_1
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[100];
            int contador = 0, numero, may, men, sumaNumeros = 0,posMenor=0,posMayor =0;
            double promedio;
            string? op;

            Console.WriteLine("Por favor ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            numeros[contador] = numero;
            may = numero;
            men = numero;
            contador++;

            Console.WriteLine("Quiere seguir ingresando numeros? (S/N)");
            op = Console.ReadLine();

            while (op == "s" && contador > 0)
            {
                Console.WriteLine("Por favor ingrese un numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                numeros[contador] = numero;
           

                if (numero > may)
                {
                    may = numero;
                    posMayor = contador;
                }
                else if (numero < men)
                {
                    men = numero;
                    posMenor = contador;
                }

                contador++;
                Console.WriteLine("Quiere seguir ingresando numeros? (S/N)");
                op = Console.ReadLine();
            }

            for (int i = 0; i < contador; i++)
            {
                sumaNumeros += numeros[i];
                Console.WriteLine($"Numero:Posicion --> {numeros[i]}:{i}");
            }
              promedio = (double)sumaNumeros / contador;
            Console.WriteLine($"La cantidad de numeros ingresados es: {contador}");
            Console.WriteLine($"El mayor numero ingresado es: {may} en la posicion:{posMayor} y el menor numero ingresado es: {men} en la posicion:{posMenor} ");
            Console.WriteLine($"El promedio de numeros ingresados es: {promedio}");
        }
    }
    
}