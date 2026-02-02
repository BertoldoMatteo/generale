// See https://aka.ms/new-console-template for more information
namespace EsCollatzBM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N=0;
            bool ValidInput = false;
            Console.WriteLine("Inserisci un numero e il programma darà in output la sequenza di Collantz");
            while (!ValidInput)
            {
                Console.Write("Inserisci il numero (positivo): ");
                ValidInput = int.TryParse(Console.ReadLine(), out N) && N > 0;
            }
            do
            {
                if (N % 2 == 0)
                {
                    N /= 2;
                }
                else
                {
                    N = N * 3 + 1;
                }
                Console.WriteLine(N);
            } while (N != 1);
            
        }
    }
}
