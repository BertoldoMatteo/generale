// See https://aka.ms/new-console-template for more information
namespace EsMoneteBertoldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 5;
            double mon = 0;
            double monTot = 0;
            int count = 0;
            while(monTot < max)
            {
                Console.WriteLine("Posso una moneta?");
                Console.WriteLine("Inserisci il valore della moneta donata: ");
                Console.WriteLine("(Se non vuoi darmi una moneta inserisci '0')");
                bool x = double.TryParse(Console.ReadLine(), out mon);
                if(x && mon >= 0)
                {
                    if(mon > 0)
                    {
                        monTot += mon;
                        count++;
                        Console.WriteLine($"Grazie per la moneta numero {count} di valore {mon}");
                    }
                }
                else
                {
                                       Console.WriteLine("Valore non valido, riprova.");
                }
            }
            Console.WriteLine("Ho abbastanza monete per la colazione, grazie!");
            Console.WriteLine("Ho ricevuto in totale: " + monTot);
            Console.WriteLine("E un totale di " + count + " monete.");
        }
    }
}
