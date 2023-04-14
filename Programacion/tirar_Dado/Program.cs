using System;

namespace tirar_Dado
{
    class dado
    {
        public int numero;

        public dado() {
            Random rnd = new Random();
            this.numero = rnd.Next(1, 7);
        }

        public void tirar_Dado()
        {
            Console.WriteLine("Ingrese numero:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Dado: "+this.numero);

            if(this.numero == num)
            {
                Console.WriteLine("Acertado");
            }
            else
            {
                Console.WriteLine("No acertado");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            dado d1 = new dado();

            d1.tirar_Dado();
        }
    }
}