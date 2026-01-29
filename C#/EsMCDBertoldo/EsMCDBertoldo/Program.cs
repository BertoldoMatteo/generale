// See https://aka.ms/new-console-template for more information
namespace EsMCDBertoldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, MCD, min;
            Console.WriteLine("Inserisci il numero di pezzi del primo ordine: ");
            bool x = int.TryParse(Console.ReadLine(), out n1);
            Console.WriteLine("Inserisci il numero di pezzi del secondo ordine: ");
            bool y = int.TryParse(Console.ReadLine(), out n2);
            if (x && y && n1 > 0 && n2 > 0)
            {
                if (n1 > n2)
                {
                    min = n2;
                }
                else
                {
                    min = n1;
                }
                for (int i = min; i > 0; i--)
                {
                    if (n1 % i == 0 && n2 % i == 0)
                    {
                        MCD = i;
                        Console.WriteLine("Il massimo comun divisore tra " + n1 + " e " + n2 + " è: " + MCD);
                        return;
                    }
                }
            }
        }
    }
}

