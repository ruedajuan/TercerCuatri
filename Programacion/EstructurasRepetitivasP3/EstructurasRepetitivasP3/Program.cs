using System;

namespace EstructurasRepetitivasP3 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] alturas = new int[10];
            Console.WriteLine("Ingrese las alturas en cm de las 10 personas");
            for(int i = 0; i < alturas.Length; i++)
            {
                alturas[i] = int.Parse(Console.ReadLine());
            }
            //Media
            double aux = 0;
            for (int i = 0; i < alturas.Length; i++)
            {
               aux = alturas[i]+aux;
            }
            double media = aux / alturas.Length;
            //Desvio
            double aux2 = 0;
            for (int i = 0; i < alturas.Length; i++)
            {
                aux2 =  Math.Pow((alturas[i]-media),2) + aux2;

            }

            double desvio = Math.Sqrt(aux2 / alturas.Length);
            Console.WriteLine($"La media de las alturas ingresadas es: {media}");
            Console.WriteLine($"El desvio estandar de las alturas ingresadas es: {desvio}");

            Console.WriteLine("Se muestran las alturas por encima de la media");
            for( int i = 0;i < alturas.Length; i++)
            {
                if (alturas[i] > media)
                {
                    Console.WriteLine(alturas[i]);
                }
            }
            Console.WriteLine("Se muestran las alturas por debajo de la media");
            for (int i = 0; i < alturas.Length; i++)
            {
                if (alturas[i] < media)
                {
                    Console.WriteLine(alturas[i]);
                }
            }
            Console.WriteLine("Se muestran las alturas dentro del rango definido por el desvio");
            for (int i = 0; i < alturas.Length; i++)
            {
                if (alturas[i] < media+desvio && alturas[i]>media-desvio)
                {
                    Console.WriteLine(alturas[i]);
                }
            }

        }
    }
}