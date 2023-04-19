using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace calendario
{
    internal class Program
    {
        static List<Materia> mateMain = new List<Materia>();
        static List<Dia> dias = new List<Dia>();
        static void Main(string[] args)
        {
            int opciones,opM,opD,op;
            
            Dia lunes=new Dia("Lunes");
            Dia martes = new Dia("Martes");
            Dia miercoles = new Dia("Miercoles");
            Dia jueves = new Dia("Jueves");
            Dia viernes = new Dia("Viernes");
            Dia sabado = new Dia("Sabado");
            dias.Add(lunes);
            dias.Add(martes);
            dias.Add(miercoles);
            dias.Add(jueves);
            dias.Add(viernes);
            dias.Add(sabado);


            Console.WriteLine("Bienvenido al sistema de calendario semanal");            
            do {
                Console.WriteLine("<--------------MENU-------------->");
                Console.WriteLine("1)Dias de la semana");
                Console.WriteLine("2)Materias");
                Console.WriteLine("3)Salir");
                Console.WriteLine("Seleccione una opcion: ");
                opciones = int.Parse(Console.ReadLine());
                switch (opciones)
                {
                    case 1:Console.WriteLine("<-----Dias de la semana----->");
                        do
                        {
                            Console.WriteLine("1)Lunes");
                            Console.WriteLine("2)Martes");
                            Console.WriteLine("3)Miercoles");
                            Console.WriteLine("4)Jueves");
                            Console.WriteLine("5)Viernes");
                            Console.WriteLine("6)Sabado");
                            Console.WriteLine("7)Volver a menu principal");
                            Console.WriteLine("Seleccione una opcion:");
                            opD= int.Parse(Console.ReadLine());
                            switch(opD) {
                                case 1:Console.WriteLine("<-----Lunes----->");
                                    do {
                                        Console.WriteLine("1)Agregar materia");
                                        Console.WriteLine("2)Ver materias");
                                        Console.WriteLine("3)Editar materia");
                                        Console.WriteLine("4)Eliminar materia");
                                        Console.WriteLine("5)Volver al menu principal");
                                        Console.WriteLine("Seleccione una opcion:");
                                        op = int.Parse(Console.ReadLine());
                                        switch (op)
                                        {
                                            case 1:Console.WriteLine("<-----Agregar materia----->");
                                                lunes.cargarMateria();
                                                break;
                                            case 2:Console.WriteLine("<-----Ver materias----->");
                                                lunes.verMaterias();
                                                break;
                                            case 3: Console.WriteLine("<-----Editar materia----->");
                                                lunes.editarMateria();
                                                break;
                                            case 4:Console.WriteLine("<-----Eliminar materia----->");
                                                lunes.eliminarMateria();
                                                break;
                                            case 5:Console.WriteLine("<-----Volver al menu principal----->");
                                                break;
                                            default: Console.WriteLine("Error");
                                                break;
                                        }

                                    } while (op!=5);
                                    break;
                                case 2:Console.WriteLine("<-----Martes----->");
                                    do
                                    {
                                        Console.WriteLine("1)Agregar materia");
                                        Console.WriteLine("2)Ver materias");
                                        Console.WriteLine("3)Editar materia");
                                        Console.WriteLine("4)Eliminar materia");
                                        Console.WriteLine("5)Volver al menu principal");
                                        Console.WriteLine("Seleccione una opcion:");
                                        op = int.Parse(Console.ReadLine());
                                        switch (op)
                                        {
                                            case 1:
                                                Console.WriteLine("<-----Agregar materia----->");
                                                martes.cargarMateria();
                                                break;
                                            case 2:
                                                Console.WriteLine("<-----Ver materias----->");
                                                martes.verMaterias();
                                                break;
                                            case 3:
                                                Console.WriteLine("<-----Editar materia----->");
                                                martes.editarMateria();
                                                break;
                                            case 4:
                                                Console.WriteLine("<-----Eliminar materia----->");
                                                martes.eliminarMateria();
                                                break;
                                            case 5:
                                                Console.WriteLine("<-----Volver al menu principal----->");
                                                break;
                                            default:
                                                Console.WriteLine("Error");
                                                break;
                                        }

                                    } while (op != 5);
                                    break;
                                case 3:Console.WriteLine("<-----Miercoles----->");
                                    do
                                    {
                                        Console.WriteLine("1)Agregar materia");
                                        Console.WriteLine("2)Ver materias");
                                        Console.WriteLine("3)Editar materia");
                                        Console.WriteLine("4)Eliminar materia");
                                        Console.WriteLine("5)Volver al menu principal");
                                        Console.WriteLine("Seleccione una opcion:");
                                        op = int.Parse(Console.ReadLine());
                                        switch (op)
                                        {
                                            case 1:
                                                Console.WriteLine("<-----Agregar materia----->");
                                                miercoles.cargarMateria();
                                                break;
                                            case 2:
                                                Console.WriteLine("<-----Ver materias----->");
                                                miercoles.verMaterias();
                                                break;
                                            case 3:
                                                Console.WriteLine("<-----Editar materia----->");
                                                miercoles.editarMateria();
                                                break;
                                            case 4:
                                                Console.WriteLine("<-----Eliminar materia----->");
                                                miercoles.eliminarMateria();
                                                break;
                                            case 5:
                                                Console.WriteLine("<-----Volver al menu principal----->");
                                                break;
                                            default:
                                                Console.WriteLine("Error");
                                                break;
                                        }

                                    } while (op != 5);
                                    break;
                                case 4:Console.WriteLine("<-----Jueves----->");
                                    do
                                    {
                                        Console.WriteLine("1)Agregar materia");
                                        Console.WriteLine("2)Ver materias");
                                        Console.WriteLine("3)Editar materia");
                                        Console.WriteLine("4)Eliminar materia");
                                        Console.WriteLine("5)Volver al menu principal");
                                        Console.WriteLine("Seleccione una opcion:");
                                        op = int.Parse(Console.ReadLine());
                                        switch (op)
                                        {
                                            case 1:
                                                Console.WriteLine("<-----Agregar materia----->");
                                                jueves.cargarMateria();
                                                break;
                                            case 2:
                                                Console.WriteLine("<-----Ver materias----->");
                                                jueves.verMaterias();
                                                break;
                                            case 3:
                                                Console.WriteLine("<-----Editar materia----->");
                                                jueves.editarMateria();
                                                break;
                                            case 4:
                                                Console.WriteLine("<-----Eliminar materia----->");
                                                jueves.eliminarMateria();
                                                break;
                                            case 5:
                                                Console.WriteLine("<-----Volver al menu principal----->");
                                                break;
                                            default:
                                                Console.WriteLine("Error");
                                                break;
                                        }

                                    } while (op != 5);
                                    break;
                                case 5:Console.WriteLine("<-----Viernes----->");
                                    do
                                    {
                                        Console.WriteLine("1)Agregar materia");
                                        Console.WriteLine("2)Ver materias");
                                        Console.WriteLine("3)Editar materia");
                                        Console.WriteLine("4)Eliminar materia");
                                        Console.WriteLine("5)Volver al menu principal");
                                        Console.WriteLine("Seleccione una opcion:");
                                        op = int.Parse(Console.ReadLine());
                                        switch (op)
                                        {
                                            case 1:
                                                Console.WriteLine("<-----Agregar materia----->");
                                                viernes.cargarMateria();
                                                break;
                                            case 2:
                                                Console.WriteLine("<-----Ver materias----->");
                                                viernes.verMaterias();
                                                break;
                                            case 3:
                                                Console.WriteLine("<-----Editar materia----->");
                                                viernes.editarMateria();
                                                break;
                                            case 4:
                                                Console.WriteLine("<-----Eliminar materia----->");
                                                viernes.eliminarMateria();
                                                break;
                                            case 5:
                                                Console.WriteLine("<-----Volver al menu principal----->");
                                                break;
                                            default:
                                                Console.WriteLine("Error");
                                                break;
                                        }

                                    } while (op != 5);
                                    break;
                                case 6:Console.WriteLine("<-----Sabado----->");
                                    do
                                    {
                                        Console.WriteLine("1)Agregar materia");
                                        Console.WriteLine("2)Ver materias");
                                        Console.WriteLine("3)Editar materia");
                                        Console.WriteLine("4)Eliminar materia");
                                        Console.WriteLine("5)Volver al menu principal");
                                        Console.WriteLine("Seleccione una opcion:");
                                        op = int.Parse(Console.ReadLine());
                                        switch (op)
                                        {
                                            case 1:
                                                Console.WriteLine("<-----Agregar materia----->");
                                                sabado.cargarMateria();
                                                break;
                                            case 2:
                                                Console.WriteLine("<-----Ver materias----->");
                                                sabado.verMaterias();
                                                break;
                                            case 3:
                                                Console.WriteLine("<-----Editar materia----->");
                                                sabado.editarMateria();
                                                break;
                                            case 4:
                                                Console.WriteLine("<-----Eliminar materia----->");
                                                sabado.eliminarMateria();
                                                break;
                                            case 5:
                                                Console.WriteLine("<-----Volver al menu principal----->");
                                                break;
                                            default:
                                                Console.WriteLine("Error");
                                                break;
                                        }

                                    } while (op != 5);
                                    break;
                                case 7:Console.WriteLine("<-----Volver al menu principal----->");
                                    break;
                                default: Console.WriteLine("Error");
                                    break;

                            }
                        } while (opD != 7);
                        break;
                    case 2:Console.WriteLine("<-----Materias----->");
                        do {
                            Console.WriteLine("1)Actualizar materia");
                            Console.WriteLine("2)Ver materias");
                            Console.WriteLine("3)Volver al menu");
                            opM = int.Parse(Console.ReadLine());
                            switch (opM) { 
                                case 1:Console.WriteLine("<-----Actualizar materias----->");
                                    
                                    foreach (Dia dia in dias)
                                    {
                                        foreach (Materia materiaDia in dia.getList())
                                        {
                                            mateMain.Add(materiaDia);
                                        }
                                    }
                                    break;
                                case 2:Console.WriteLine("<-----Ver materias----->");
                                    verMaterias();
                                    break;
                                    case 3:Console.WriteLine("<-----volver al menu principal----->");
                                    break;
                                    default:Console.WriteLine("Error");
                                    break;
                            }
                        } while (opM!=3);


                        break;
                    case 3:Console.WriteLine("<-----Salir----->");
                        break;
                    default:Console.WriteLine("Error");
                        break;

                }
            } while (opciones != 3);



            Console.ReadKey();
        }
        static void actualizarMaterias()
        {
            bool nombre;
            foreach (Dia dia in dias) {
                foreach (Materia materiaDia in dia.getList()) {
                    foreach (Materia materiaMain in mateMain) { 
                        nombre=materiaMain.getNombre().Equals(materiaDia.getNombre());
                        if (!nombre) {
                            mateMain.Add(materiaDia);
                        }

                    }
                }
            }
   
        }
        static void verMaterias() {
            int cont = 0;
                Console.WriteLine("¿Que materia desea ver?");
                String nombre=Console.ReadLine();     

                foreach (Materia materia in mateMain) {
                    if (materia.getNombre().Equals(nombre))
                    {
                        foreach (Dia dia in dias)
                        {
                            Console.WriteLine("<----------" + dia.getNombre() + "---------->");
                            foreach (Materia materia1 in dia.getList())
                            {
                                if (materia.getNombre().Equals(materia1.getNombre()))
                                {
                                Console.WriteLine(materia1.getNombre());
                                Console.WriteLine("Hora de entrada: " + materia1.getHorEntrada() + ":" + materia1.getMinEntrada());
                                Console.WriteLine("Hora de salida: " + materia1.getHorSalida() + ":" + materia1.getMinSalida());

                                }
                            }
                        }
                        cont++;
                        break;
                    }   
                    
                    
                    
                }
                if (cont == 0) {
                Console.WriteLine("No se encontro ninguna materia con ese nombre");
                }

        }


    }
    public class Dia {
        private String nombre;
        private List<Materia> materiaList;
        
        
        public Dia(String nombre) {
            this.nombre = nombre;
            materiaList = new List<Materia>();
        }
        public List<Materia> getList() { 
            return materiaList;
        }
        public String getNombre() { 
            return nombre;
        }

        public void cargarMateria() {
            int cont1 = 0;
            Console.WriteLine("Ingrese nombre de la materia:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hora de entrada");
            Console.WriteLine("<--------------------------->");
            Console.WriteLine("Introduzca la hora a la que comienza la clase (Solo la hora de las 7 a las 20)");
            int horEntrada = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca los minutos en los que comenzara la clase");
            int minEntrada = int.Parse(Console.ReadLine());
            Console.WriteLine("<--------------------------->");
            Console.WriteLine("Hora de salida");
            Console.WriteLine("<--------------------------->");
            Console.WriteLine("Introduzca la hora a la que termina la clase (Solo la hora de las 7 a las 20)");
            int horSalida = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca los minutos en los que terminara la clase");
            int minSalida = int.Parse(Console.ReadLine());
            Console.WriteLine("<--------------------------->");
            Materia materia = new Materia(nombre, horEntrada, horSalida, minEntrada, minSalida);
            
            foreach (Materia materia1 in materiaList) {
                if (horEntrada == materia1.getHorEntrada())
                {
                    cont1++;
                }
                else if (horEntrada == materia1.getHorSalida())
                {
                    if (minEntrada < materia1.getMinSalida())
                    {
                        cont1++;
                    }

                }
                else {
                    continue;
                }
            }

            if (cont1 == 0 && horEntrada>= 7 && horSalida <20 && minEntrada<60 && minSalida<60)
            {
                materiaList.Add(materia);
            }
            else {
                Console.WriteLine("No se pudo añadir materia porque hay almenos una coincidencia en horarios con materias ya existentes en este dia");
            }


        }
        public void editarMateria()
        {
            int cont = 0;
            if (materiaList.Count == 0)
            {
                Console.WriteLine("No se an encontrado materias");
            }
            else
            {
                Console.WriteLine("¿Que materia desea editar?");
                foreach (Materia materia in materiaList)
                {
                    cont++;
                    Console.WriteLine(cont + ") " + materia.getNombre());
                }
                Console.WriteLine("introduzco su indice: ");
                int indice = int.Parse(Console.ReadLine());
                if (indice > materiaList.Count)
                {
                    Console.WriteLine("item invalido");
                }
                else
                {
                    cont = 0;
                    foreach (Materia materia in materiaList)
                    {
                        if (cont == (indice-1))
                        {
                            Console.WriteLine("Nombre:");
                            String nombre = Console.ReadLine();
                            materia.setNombre(nombre);
                            Console.WriteLine("Hora de entrada");
                            Console.WriteLine("<--------------------------->");
                            Console.WriteLine("Introduzca la hora a la que comienza la clase (Solo la hora de las 7 a las 20)");
                            int horEntrada = int.Parse(Console.ReadLine());
                            Console.WriteLine("Introduzca los minutos en los que comenzara la clase");
                            int minEntrada = int.Parse(Console.ReadLine());
                            materia.setHorEntrada(horEntrada);
                            materia.setMinEntrada(minEntrada);
                            Console.WriteLine("<--------------------------->");
                            Console.WriteLine("Hora de salida");
                            Console.WriteLine("<--------------------------->");
                            Console.WriteLine("Introduzca la hora a la que termina la clase (Solo la hora de las 7 a las 20)");
                            int horSalida = int.Parse(Console.ReadLine());
                            Console.WriteLine("Introduzca los minutos en los que terminara la clase");
                            int minSalida = int.Parse(Console.ReadLine());
                            materia.setHorSalida(horSalida);
                            materia.setMinSalida(minSalida);
                            Console.WriteLine("<--------------------------->");
                        }
                        cont++;
                    }

                }
            }
        }
        public void eliminarMateria()
        {
            int op,cont=0;
            Console.WriteLine("¿Que materia desea eliminar?");
            foreach (Materia materia in materiaList) {
                cont++;
                Console.WriteLine(cont+")"+materia.getNombre());
            }
            Console.WriteLine("99)Cancelar");
            Console.WriteLine("Introduzca el indise");
            op=int.Parse(Console.ReadLine());
            cont = 0;
            foreach (Materia materia in materiaList) {
                if (cont == (op - 1)) { 
                    materiaList.RemoveAt(cont);
                    break;
                }
                cont++;
            }           
            
        }
        public void verMaterias() {
            foreach (Materia materia in materiaList) {
                if (materiaList.Count==0) {
                    Console.WriteLine("No se encontraron materias");
                }
                else {
                    Console.WriteLine("<----------------------->");
                    Console.WriteLine(materia.getNombre());
                    Console.WriteLine("Hora de entreda:" + materia.getHorEntrada() + ":" + materia.getMinEntrada());
                    Console.WriteLine("Hora de salida:" + materia.getHorSalida() + ":" + materia.getMinSalida());
                    Console.WriteLine("<----------------------->");
                }
            }
        }


    }

    public class Materia {
        private String nombre;
        private List<String> Dias;
        private int horEntrada, horSalida, minEntrada, minSalida;

        public Materia(String nombre,int horEntrda,int horSalida,int minEntrada,int minSalida) { 
            this.nombre = nombre;
            this.horEntrada = horEntrda;
            this.horSalida = horSalida;
            this.minEntrada = minEntrada;
            this.minSalida = minSalida;
            Dias = new List<String>();
        }
        public Materia(String nombre)
        {
            this.nombre = nombre;
        }

        public List<String> getDias()
        {
            return Dias;
        }
        public void setDias(String horario) {
            this.Dias.Add(horario);
        }
        public String getNombre() { 
            return nombre;
        }
        public int getHorEntrada()
        {
            return horEntrada;
        }
        public int getHorSalida()
        {
            return horSalida;
        }
        public int getMinEntrada()
        {
            return minSalida;
        }
        public int getMinSalida()
        {
            return minSalida;
        }
        public void setNombre(String nombre) {
            this.nombre = nombre;
        }
        public void setHorEntrada(int HorEntrada)
        {
            this.horEntrada = HorEntrada;
        }
        public void setHorSalida(int HorSalida)
        {
            this.horSalida = HorSalida;
        }
        public void setMinEntrada(int MinEntrada)
        {
            this.minEntrada = MinEntrada;
        }
        public void setMinSalida(int MinSalida)
        {
            this.minSalida = MinSalida;
        }

    }
}
