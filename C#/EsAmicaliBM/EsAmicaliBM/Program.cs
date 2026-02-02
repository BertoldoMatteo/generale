// See https://aka.ms/new-console-template for more information
namespace EsAmicaliBM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1=0, n2=0, somma=0;
            bool ValidInput = false;
            
            Console.WriteLine("Inserisci due numeri interi e positivi e il programma ti dirà se sono amici, ovvero se la somma dei divisori propri di ciascun numero è uguale all'altro numero.");
            while (!ValidInput)
            {
                Console.WriteLine("Inserisci il primo numero (positivo):");
                ValidInput = int.TryParse(Console.ReadLine(), out n1) && n1 > 0;
                
            }
            ValidInput = false;
            while (!ValidInput)
            {
                Console.WriteLine("Inserisci il secondo numero (positivo):");
                ValidInput = int.TryParse(Console.ReadLine(), out n2) && n2 > 0;
            }
            for(int i=1; i<=n1/2; i++)
            {
                if (n1%i == 0)
                {
                    somma+=i;
                }
            }
            if (somma == n2)
            {
                somma = 0;
                for (int j = 1; j <= n2 / 2; j++)
                {
                    if (n2 % j == 0)
                    {
                        somma += j;
                    }
                }
                if (somma == n1)
                {
                    Console.WriteLine($"I due numeri {n1} e {n2} sono amici.");
                    return;
                }
            }
            Console.WriteLine($"I due numeri {n1} e {n2} NON sono amici.");
        }
        
    }
}
