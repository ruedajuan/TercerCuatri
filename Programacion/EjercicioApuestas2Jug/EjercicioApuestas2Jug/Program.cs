using EjercicioApustas2Jug;
using System;

namespace EjercicioApustas2Jug // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Jugadores j1 = new Jugadores("Francia");
            Jugadores j2 = new Jugadores("Simon");
            Apuestas a1 = new Apuestas();
            bool retirada=false;

            while(retirada==false)
            {
                Console.WriteLine("Quien va a jugar?: \n 1-Francia \n 2-Simon");
                x= int.Parse(Console.ReadLine());
                switch(x)
                {
                    case 1:
                        {
                            Console.WriteLine("Ingrese el monto que desea apostar");
                            int apuestaj= int.Parse(Console.ReadLine());
                            if (apuestaj <= j1.saldo)
                            {
                                a1.ModoApuesta(j1, apuestaj);

                            }
                            else Console.WriteLine("Esta apostando mas de lo que tiene");
                            break;
                        }
                        case 2:
                        {
                            Console.WriteLine("Ingrese el monto que desea apostar");
                            int apuestaj = int.Parse(Console.ReadLine());
                            if (apuestaj <= j2.saldo)
                                a1.ModoApuesta(j2, apuestaj);
                            else Console.WriteLine("Esta apostando mas de lo que tiene");
                            break;

                        }
                        default:
                        {
                            Console.WriteLine("Error en la eleccion de jugador");
                            break;
                        }
                }
                Console.WriteLine("¿Desea seguir jugando? \n 1-SI \n 2-NO");
                int salida = int.Parse(Console.ReadLine());
                if (salida == 2) retirada = true;
                else if (j1.saldo <= 0)
                {
                    Console.WriteLine("Lo siento, el jugador 1 no posee mas saldo");
                    retirada = true;
                }
                else if (j2.saldo <= 0)
                {
                    Console.WriteLine("Lo siento, el jugador 2 no posee mas saldo");
                    retirada = true;
                }

                else if (a1.pozo <= 0)
                {
                    Console.WriteLine("Lo siento, no hay mas dinero en el pozo");
                    retirada = true;
                }

            }
            
        }
    }
    class dado
    {
        public int numero;
        public bool resultado;

        public dado()
        {
            Random rnd = new Random();
            this.numero = rnd.Next(1, 3);
        }

        public bool tirar_Dado()
        {
           
            Console.WriteLine("Ingrese numero del 1 al 12:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Dado: " + this.numero);

            if (this.numero == num)
            {
                Console.WriteLine("Acertado");
                resultado = true;
            }
            else
            {
                Console.WriteLine("No acertado");
                resultado = false;
            }
            return resultado;
        }
        }
    }
class Jugadores
{
    public String nombre;
    public int saldo;
    public Jugadores(String nombre)
    {
        this.nombre = nombre;
        this.saldo = 100;

    }
}
class Apuestas
{
    public int pozo;
    
    public Apuestas()
    {
        this.pozo = 10000;
    }
    public void ModoApuesta(Jugadores jugador,int monto)
    {
        Console.WriteLine("Seleccione el modo que desea apostar, seleccionando: \n 1-Conservador\n 2-Arriesgado \n 3-Desesperado");
        int eleccion= int.Parse(Console.ReadLine());
        dado juego = new dado();
        juego.tirar_Dado();
        bool apuesta = juego.resultado;
        

        switch (eleccion)
        {
            case 1:
                {
                    if(apuesta==true) 
                    {
                        jugador.saldo = jugador.saldo+monto * 2;
                        pozo = pozo - monto * 2;
                        Console.WriteLine($"El saldo de {jugador.nombre} es {jugador.saldo}");
                    }
                    else
                    {
                        jugador.saldo = jugador.saldo - monto;
                        pozo = pozo + monto;
                        Console.WriteLine($"El saldo de {jugador.nombre} es {jugador.saldo}");
                    }
                    
                    break;
                }
            case 2:
                {
                    if (apuesta == true)
                    {
                        jugador.saldo = jugador.saldo + monto * 5;
                        pozo = pozo - monto * 5;
                        Console.WriteLine($"El saldo de {jugador.nombre} es {jugador.saldo}");
                    }
                    else
                    {
                        jugador.saldo = jugador.saldo - monto*2;
                        pozo = pozo + monto*2;
                        Console.WriteLine($"El saldo de {jugador.nombre} es {jugador.saldo}");
                    }

                    break;
                }
                case 3:
                {
                    if (apuesta == true)
                    {
                        jugador.saldo = jugador.saldo + monto * 15;
                        pozo = pozo - monto * 15;
                        Console.WriteLine($"El saldo de {jugador.nombre} es {jugador.saldo}");
                    }
                    else
                    {
                        jugador.saldo = jugador.saldo - monto * 4;
                        pozo = pozo + monto * 4;
                        Console.WriteLine($"El saldo de {jugador.nombre} es {jugador.saldo}");
                    }
                    break;
                }
            default: {
                    Console.WriteLine("No ingreso ningun modo valido");
                    break; }
        }
    }
}