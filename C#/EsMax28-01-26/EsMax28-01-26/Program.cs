// See https://aka.ms/new-console-template for more information
namespace CalcolaMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max=0;
            int n, m;

            Console.WriteLine("Inserisci il primo numero:");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero:");
            m=int.Parse(Console.ReadLine());

            if(n>m)
            {
                max= n;
            }
            else
            {
                max= m;
            }
            Console.WriteLine($"Il numero maggiore è {max}");
        }
    }
}

