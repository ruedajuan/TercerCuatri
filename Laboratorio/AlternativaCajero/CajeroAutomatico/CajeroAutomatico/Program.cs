using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Threading.Channels;
using static CajeroAutomatico.Program;

namespace CajeroAutomatico // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc =1;
            List<Cajero> cajeros = new List<Cajero>();
            List<CuentaBancaria> cuentas = new List<CuentaBancaria>();

            Cajero cajero1 = new Cajero("Alvear 125", 112);
            cajeros.Add(cajero1);
            
            while (opc != 0) { 

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Menu del Cajero");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("1-Crear cuenta");
            Console.WriteLine("2-Depositar dinero");
            Console.WriteLine("3-Retirar dinero");
            Console.WriteLine("4-Pedir prestamo Especial");
            Console.WriteLine("0-Salir");

            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
               case 0:
                    {
                        break;
                    }

                case 1:
                    {
                        Console.WriteLine("Ingrese el la fecha de creacion de la cuenta, colocando dia-mes-año");
                        int dia = int.Parse(Console.ReadLine());
                        int mes = int.Parse(Console.ReadLine());
                        int año = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese nombre del dueño de la cuenta");
                        string name = Console.ReadLine();
                        Console.WriteLine("Ingrese direccion del dueño de la cuenta");
                        string adress = Console.ReadLine();
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
                        CuentaBancaria c1 = new CuentaBancaria(name, adress, job, dia, mes, año);


                        Console.WriteLine($"Cuenta creada exitosamente, su numero de cuenta es:{c1.getNumeroCuenta()}");
                        cuentas.Add(c1);
                        break;

                    }
                case 2:
                    {
                            Console.WriteLine("Escriba su numero de cuenta: ");
                            int busc = int.Parse(Console.ReadLine());
                            int aux = 0;
                            for (int i = 0; i < cuentas.Count; i++)
                            {
                                bool cond = cuentas[i].getNumeroCuenta().Equals(busc);
                                if (cond == true)
                                {
                                    Console.WriteLine("Ingrese el monto a depositar");
                                    double dep = double.Parse(Console.ReadLine());
                                    cuentas[i].depositar(dep);
                                    aux = 1;
                
                                }
                                
                            }
                            if(aux == 0)
                            {
                                Console.WriteLine("Cuenta no encontrada o inexistente");
                            }
                            
                            break;


                        }

                 case 3:
                        {
                            Console.WriteLine("Escriba su numero de cuenta: ");
                            int busc2 = int.Parse(Console.ReadLine());
                            int aux2 = 0;
                            for (int i = 0; i < cuentas.Count; i++)
                            {
                                bool cond = cuentas[i].getNumeroCuenta().Equals(busc2);
                                if (cond == true)
                                {
                                    Console.WriteLine("Ingrese el monto a retirar");
                                    double dep = double.Parse(Console.ReadLine());
                                    cuentas[i].retirar(dep);
                                    aux2 = 1;
                                }
                                 
                            }
                            if(aux2 == 0) 
                            {
                                Console.WriteLine("Cuenta no encontrada o inexistente");
                            }
                            

                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Escriba su numero de cuenta: ");
                            int busc3 = int.Parse(Console.ReadLine());
                            int aux3 = 0;
                            for (int i = 0; i < cuentas.Count; i++)
                            {
                                bool cond = cuentas[i].getNumeroCuenta().Equals(busc3);
                                if (cond == true)
                                {
                                    Console.WriteLine("Ingrese el monto del prestamo solicitado");
                                    double dep = double.Parse(Console.ReadLine());
                                    cuentas[i].prestamoEspecial(dep);
                                    aux3 = 1;
                                }
                                if (aux3 == 0)
                                {
                                    Console.WriteLine("Cuenta no encontrada o inexistente");
                                }
                                

                            }
                            break;
                        }



                    default:break;
                }





            }
        }
        public class CuentaBancaria{
            private double saldo;
            private int numeroCuenta;
            private DateTime fechaApertura;
            private String nombre;
            private String direccion;
            private bool esJubilado;

            
            
            public CuentaBancaria(String nombre, String direccion, bool esJubilado,int dia, int mes, int año)
            {
                this.saldo =0;
                this.fechaApertura = new DateTime(año,mes,dia);
                Random r = new Random();
                this.numeroCuenta = r.Next(0,1001);
                this.nombre= nombre;
                this.direccion = direccion;
                this.esJubilado = esJubilado;
            }
            public String getNombre() { return nombre; }
            public void setNombre(String nombre) { this.nombre = nombre; }
            public String getDireccion() { return direccion; }
            public void setDireccion(String direccion) { this.direccion = direccion; }
            public bool getesJubilado() { return esJubilado; }
            public void setesJubilado(bool esJubilado) { this.esJubilado = esJubilado; }
            public int getNumeroCuenta() { return numeroCuenta; }

            public void depositar(double dinero)
            {
                this.saldo = dinero+this.saldo;
                string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
                Console.WriteLine("Fecha: {0}", date);
                string time = DateTime.Now.ToString("h:mm:ss tt");
                Console.WriteLine("Hora: {0}", time);
                Console.WriteLine($"Se deposito {dinero} pesos en su cuenta");
                Console.WriteLine($"Posee un saldo de {this.saldo} pesos");
            }
            public void retirar (double dinero) {
                int limite;
                if (esJubilado == false)
                {
                    limite = -20000;
                }
                else limite = -10000;
                if (dinero - this.saldo >= limite)
                {
                    this.saldo = this.saldo - dinero;
                    string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
                    Console.WriteLine("Fecha: {0}", date);
                    string time = DateTime.Now.ToString("h:mm:ss tt");
                    Console.WriteLine("Hora: {0}", time);
                    Console.WriteLine($"Se realizó la extracción de {dinero} pesos de su cuenta");
                    Console.WriteLine($"Posee un saldo de {this.saldo} pesos");
                }
                else Console.WriteLine("No puede retirar esa cantidad, supero el limite permitido");
            }
            public void prestamoEspecial(double dinero) {
                DateTime hoy = DateTime.Now;
                hoy = hoy.AddDays(-60);
                int limite;
                int result = DateTime.Compare(hoy, fechaApertura);
                if (result > 0 && saldo >= 20000)
                {
                    limite = -80000;
                    if (dinero - this.saldo >= limite)
                    {
                        this.saldo = this.saldo - dinero;
                        string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
                        Console.WriteLine("Fecha: {0}", date);
                        string time = DateTime.Now.ToString("h:mm:ss tt");
                        Console.WriteLine("Hora: {0}", time);
                        Console.WriteLine($"Se realizó la extracción de {dinero} pesos de su cuenta");
                        Console.WriteLine($"Posee un saldo de {this.saldo} pesos");
                    }
                    else Console.WriteLine("No puede retirar esa cantidad, supero el limite permitido");
                }
                else Console.WriteLine("No puede solicitar el prestamo especial");
                

            }

        }

        public class Cajero
        {
            private String direccion;
            private int nroCajero;
            

            public Cajero(String direccion,int nroCajero)
            {
                this.direccion= direccion;
                this.nroCajero = nroCajero;
            }
            public String getDireccion() { return direccion; }
            public void setDireccion(String direccion) { this.direccion = direccion; }
            public int getNroCajero() {  return nroCajero; }
            public void setNroCajero(int nroCajero) { this.nroCajero=nroCajero; }


            public String identificar()
            {
                return "Cajero #" + this.nroCajero + " - " + this.direccion; ;
            }

        }
    }
}
