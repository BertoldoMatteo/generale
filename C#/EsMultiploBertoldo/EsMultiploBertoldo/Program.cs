// See https://aka.ms/new-console-template for more information
namespace EsMultiploBertoldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Inserisci il primo numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero:");
            n2 = int.Parse(Console.ReadLine());
            if(n1<0 || n2<=0)
            {
                Console.WriteLine("Inserisci solo numeri positivi");
                return;
            }   
            if (n1 % n2 == 0)
            {
                Console.WriteLine($"{n1} è multiplo di {n2}");
            }
            else
            {
                Console.WriteLine($"{n1} non è multiplo di {n2}");
            }
        }
    }
}
