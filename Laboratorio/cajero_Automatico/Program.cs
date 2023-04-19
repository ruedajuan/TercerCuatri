using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Threading.Tasks.Dataflow;

namespace cajero_Automatico
{

    class cajero
    {
        private string direccion;
        private int numCajero;

        public cajero(string direccion, int numCajero)
        {
            this.direccion = direccion;
            this.numCajero = numCajero;
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
        private DateTime fecha;

        public cuenta (string nombre, string apellido, bool esJubilado,int dia, int mes, int año)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.esJubilado = esJubilado;
            this.fecha =new DateTime(año,mes,dia);
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
            Console.WriteLine("Fecha de creación de la cuenta: "+this.fecha.ToShortDateString());
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

        public void SacarPrestamo(double prestamo)
        {
            DateTime hoy = DateTime.Now;

            int limite = 0, result = DateTime.Compare(hoy, this.fecha);

            if (result > 0 && this.saldo >=20000) {
                limite = -80000;
                if(this.saldo-prestamo >= limite)
                {
                    this.saldo = this.saldo - prestamo;

                    Console.WriteLine("Dinero retirado");
                    Console.WriteLine("Informacion de la transaccion");
                    
                    Console.WriteLine("Total en la cuenta: $" + this.saldo);
                   
                    Console.WriteLine("Fecha y hora de la operacion: " + hoy);

                }
                else
                {
                    Console.WriteLine("No puede retirar esa cantidad, supero el limite permitido");
                }
            }
            else
            {
                Console.WriteLine("No puede solicitar el prestamo especial");
            }
        }
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc = 0, salir = 1;
            List<cajero> cajeros = new List<cajero>();
            List<cuenta> cuentas = new List<cuenta>();

            cajeros.Add(new cajero("Av A 131", 00345));
            cajeros.Add(new cajero("Av B 102", 00346));
            cajeros.Add(new cajero("Av A 145", 00347));

            Console.WriteLine(cajeros[0].Identificar());
            

            cuentas.Add(new cuenta("Tomás", "Latyn", false,05,06,2012));
            cuentas.Add(new cuenta("Mariel", "Vera", true,09,08,2015));
            cuentas.Add(new cuenta("Gonzalo", "Enz", false,21,07,2022));

            cuentas[0].Depositar(10000);
            cuentas[1].Depositar(25000);
            cuentas[2].Depositar(50000);
             

            while (salir!=0)
            {

                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("                  Menu del Cajero");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("1-Crear cuenta");
                Console.WriteLine("2-Depositar dinero");
                Console.WriteLine("3-Retirar dinero");
                Console.WriteLine("4-Pedir prestamo especial");
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

                            Console.WriteLine("Ingrese la fecha de creacion de la cuenta (DD/MM/AAAA)");
                            int dia = int.Parse(Console.ReadLine());
                            int mes = int.Parse(Console.ReadLine());
                            int año = int.Parse(Console.ReadLine());

                            cuenta c1 = new cuenta(name, sname, job,dia,mes,año);
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
                            DateTime hoy = DateTime.Now;
                            Console.WriteLine("Fecha y hora de la operacion: "+hoy);

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Seleccione un cajero ");
                            int i = 1;
                            foreach (cajero b in cajeros)
                            {
                                Console.WriteLine(i + "-" + b.Identificar());
                                i++;
                            }

                            int num = int.Parse(Console.ReadLine());

                            Console.WriteLine("Seleccione su cuenta");
                             i = 1;
                            foreach (cuenta c in cuentas)
                            {
                                Console.WriteLine(i + "-" + c.TraerNombre());
                                i++;
                            }

                             num = int.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese la cantidad a retirar");
                            double retiro = double.Parse(Console.ReadLine());

                            if (cuentas[num - 1].TraerEstado() == false)
                            {
                                if (retiro > 20000)
                                {
                                    Console.WriteLine("El adelanto de sueldo no puede ser mayor a $20.000, reintente la operación con un monto menor");
                                }
                                else {
                                    cuentas[num - 1].Retirar(retiro);
                                    Console.WriteLine("Dinero retirado");
                                    Console.WriteLine("Informacion de la transaccion");
                                    cajeros[num - 1].Identificar();
                                    Console.WriteLine("Total en la cuenta: $" + cuentas[num - 1].TraerSaldo());
                                    DateTime hoy = DateTime.Now;
                                    Console.WriteLine("Fecha y hora de la operacion: " + hoy);
                                }
                            }
                            else
                            {
                                if (retiro > 10000)
                                {
                                    Console.WriteLine("El adelanto de sueldo no puede ser mayor a $10.000, reintente la operación con un monto menor");
                                }
                                else
                                {
                                    cuentas[num - 1].Retirar(retiro);
                                    Console.WriteLine("Dinero retirado");
                                    Console.WriteLine("Total restante en la cuenta: $" + cuentas[num - 1].TraerSaldo());
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Seleccione un cajero ");
                            int i = 1;
                            foreach (cajero b in cajeros)
                            {
                                Console.WriteLine(i + "-" + b.Identificar());
                                i++;
                            }

                            int num = int.Parse(Console.ReadLine());

                            Console.WriteLine("Seleccione su cuenta");
                            i = 1;
                            foreach (cuenta c in cuentas)
                            {
                                Console.WriteLine(i + "-" + c.TraerNombre());
                                i++;
                            }

                            num = int.Parse(Console.ReadLine());

                            int dinero = 0;

                            Console.WriteLine("Ingrese monto del prestamo");
                            dinero=int.Parse(Console.ReadLine());   

                            cuentas[num-1].SacarPrestamo(dinero);

                            cajeros[num - 1].Identificar();



                            break;
                        }
                }

                Console.WriteLine("Salir? Si=0/No=1");
                salir=int.Parse(Console.ReadLine());
            }
            
        }
    }
}