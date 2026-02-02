// See https://aka.ms/new-console-template for more information
namespace EsArmstrongBM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool x;
            double somma=0, cifra, lung=0, n1, num;     
            Console.WriteLine("Siamo un sistema bancario basato su numeri di Armstrong");
            Console.WriteLine("Il programma dirà se il numero rispetta i criteri di Armstrong");
            do
            {
                Console.WriteLine("Devi inserire un numero intero positivo:");
                x = double.TryParse(Console.ReadLine(), out n1);
            } while (!x || n1 < 0);
            num = n1;
            while (num > 0)
            {
                num = Math.Floor(num / 10);
                lung++;
            }
            num = n1;
            for (int i = 1; i <= lung; i++)
            {
                cifra = n1%10;
                somma += Math.Pow(cifra, lung);
                n1 =Math.Floor(n1/10);
            }
            if (somma == num)
            {
                Console.WriteLine("Il numero " + num + " è un numero di Armstrong");
            }
            else
            {
                Console.WriteLine("Il numero " + num + " non è un numero di Armstrong");
            }
        }
    }
}

