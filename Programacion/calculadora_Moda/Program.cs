namespace calculadora_Moda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            int opc = 1,num=0,i=0;

            Console.WriteLine("Ingrese los numeros para calcular la moda");
            while( opc != 0)
            {
                Console.WriteLine("Ingresar numero >");
                num=int.Parse(Console.ReadLine());  
                nums.Add(num);
                Console.WriteLine("Añadir otro numero? SI=1 / NO=0");
                opc = int.Parse(Console.ReadLine());    
            }

            Console.WriteLine("Lista de numeros ingresados");
            for(i=0; i < nums.Count; i++)
            {
                Console.WriteLine(nums[i]);

            }

            int maxn = nums[0];
            int maxveces = 0;

            i = 0;
            while (i < nums.Count)
            {
                int nveces = 0;
                int j = 0;
                while (j < nums.Count)
                {
                    if (nums[j] == nums[i])
                    {
                        nveces++;
                    }
                    j++;
                }
                if (nveces > maxveces)
                {
                    maxn = nums[i];
                    maxveces = nveces;
                }
                i++;
            }

            Console.WriteLine("Moda: " + maxn + " - Veces que se repite: " + maxveces);
        }
    }
}