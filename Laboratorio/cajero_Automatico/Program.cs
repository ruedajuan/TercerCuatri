using System.ComponentModel;
using System.Net.Http.Headers;
using System.Threading.Tasks.Dataflow;

namespace cajero_Automatico
{

    class cajero
    {
        public string direccion;
        public int numCajero;

        public cajero(string direccion, int numCajero)
        {
            direccion = this.direccion;
            numCajero = this.numCajero;
        }

        public string Identificar()
        {
            return "Cajero #"+this.numCajero+" - "+this.direccion;
        }
    }

    class cuenta 
    {
        private string nombre;
        private string apellido;
        private double saldo;
        private bool esJubilado;

        public cuenta (string nombre, string apellido, bool esJubilado)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.esJubilado = esJubilado;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("Nombre del titular: "+this.nombre+" "+this.apellido);
            Console.WriteLine("Saldo disponible: " + this.saldo + "$");
            if (this.esJubilado==true)
            {
                Console.WriteLine("Jubilado");
            }
            else
            {
                Console.WriteLine("Persona en actividad laboral");
            }
        }

        public string TraerNombre()
        {
            return this.nombre+" "+this.apellido;
        }

        public double TraerSaldo()
        {
            return this.saldo;
        }

        public bool TraerEstado()
        {
            return this.esJubilado;
        }

        public void Depositar(double dinero)
        {
            this.saldo = this.saldo + dinero;
        }

        public void Retirar(double dinero)
        {
            this.saldo = this.saldo - dinero;
        }

    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc = 0, salir = 1;
            List<cajero> cajeros = new List<cajero>();
            List<cuenta> cuentas = new List<cuenta>();

            cuentas.Add(new cuenta("Tommy", "Latyn", false));
            cuentas.Add(new cuenta("Margarita", "Latyn", true));
            cuentas.Add(new cuenta("Marcelo", "Latyn", false));

            cajeros.Add(new cajero("Av A 131", 00345));
            cajeros.Add(new cajero("Av B 102", 00346));
            cajeros.Add(new cajero("Av A 145", 00347));



            while (salir!=0)
            {

                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Menu del Cajero");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("1-Crear cuenta");
                Console.WriteLine("2-Depositar dinero");
                Console.WriteLine("3-Retirar dinero");
                Console.WriteLine("0-Salir");

                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        {
                            Console.WriteLine("Ingrese nombre del dueño de la cuenta");
                            string name = Console.ReadLine();
                            Console.WriteLine("Ingrese apellido del dueño de la cuenta");
                            string sname = Console.ReadLine();
                            Console.WriteLine("Indique si se encuentra en actividad laboral o es jubilado");
                            Console.WriteLine("1-Actividad laboral   2-Jubilado");
                            int num = int.Parse(Console.ReadLine());
                            bool job = false;
                            if (num == 1)
                            {
                                job = false;
                            }
                            else
                            {
                                if (num == 2)
                                {
                                    job = true;
                                }
                            }

                            cuenta c1 = new cuenta(name, sname, job);
                            cuentas.Add(c1);

                            Console.WriteLine("Cuenta creada exitosamente");

                            c1.MostrarInfo();

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Seleccione un cajero ");
                            int i = 1;
                            foreach (cajero b in cajeros)
                            {
                                Console.WriteLine(i + "-" + b.Identificar());
                                i++;
                            }

                            int num=int.Parse(Console.ReadLine()); 



                            Console.WriteLine("Seleccione su cuenta");
                             i = 1;
                            foreach (cuenta c in cuentas)
                            {
                                Console.WriteLine(i + "-" + c.TraerNombre());
                                i++;
                            }

                            int num2 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese la cantidad a depositar");
                            double deposito = double.Parse(Console.ReadLine());

                            cuentas[num2 - 1].Depositar(deposito);

                            Console.WriteLine("Dinero depositado");
                            Console.WriteLine("Informacion de la transaccion");
                            cajeros[num - 1].Identificar();
                            Console.WriteLine("Total en la cuenta: $" + cuentas[num - 1].TraerSaldo());

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Seleccione su cuenta");
                            int i = 1;
                            foreach (cuenta c in cuentas)
                            {
                                Console.WriteLine(i + "-" + c.TraerNombre());
                                i++;
                            }

                            int num = int.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese la cantidad a retirar");
                            double retiro = double.Parse(Console.ReadLine());

                            if (cuentas[num - 1].TraerEstado() == false)
                            {
                                if (retiro > 20000)
                                {
                                    Console.WriteLine("El adelanto de sueldo no puede ser mayor a $20.000");
                                }
                                else {
                                    cuentas[num - 1].Retirar(retiro);
                                    Console.WriteLine("Dinero retirado");
                                    Console.WriteLine("Total restante en la cuenta: $" + cuentas[num - 1].TraerSaldo())
                                }
                            }
                            else
                            {
                                if (retiro > 10000)
                                {
                                    Console.WriteLine("El adelanto de sueldo no puede ser mayor a $10.000");
                                }
                                else
                                {
                                    cuentas[num - 1].Retirar(retiro);
                                    Console.WriteLine("Dinero retirado");
                                    Console.WriteLine("Total restante en la cuenta: $" + cuentas[num - 1].TraerSaldo())
                                }
                            }

                            

                            
                            break;
                        }
                }



                Console.WriteLine("Salir? Si=0/No=1");
                salir=int.Parse(Console.ReadLine());
            }
            
        }
    }
}