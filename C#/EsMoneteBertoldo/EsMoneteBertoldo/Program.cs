// See https://aka.ms/new-console-template for more information
namespace EsMoneteBertoldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const float max = 5;
            float mon = 0;
            float monTot = 0f; //portafoglio delle monete
            int count = 0;

            while(monTot < max)
            {
                Console.WriteLine("Posso una moneta?");
                Console.WriteLine("Inserisci il valore della moneta donata: ");
                Console.WriteLine("(Se non vuoi darmi una moneta inserisci '0')");
                bool x = float.TryParse(Console.ReadLine(), out mon);
                if(x && (mon==0.05 || mon==0.10 || mon==0.2 || mon==0.5 || mon==1 || mon==2))
                {
                    monTot += mon;
                    count++;
                    Console.WriteLine($"Grazie per la moneta numero {count} di valore {mon}");
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
