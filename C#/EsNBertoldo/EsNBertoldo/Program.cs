// See https://aka.ms/new-console-template for more information
namespace EsNBertoldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int count=0;
            Console.WriteLine("Inserisci un numero e il programma stamperà tutti i numeri fino a quello");
            bool x =int.TryParse(Console.ReadLine(), out n);

            if (x && n>=1)
            {
                Console.WriteLine("I numeri sono:");
                Console.WriteLine("1");
                for(int i=1; i<=n; i++)
                {
                    count = 0;
                    for(int  j=1; j<=i/2; j++)
                    {
                        if (i % j == 0)
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
