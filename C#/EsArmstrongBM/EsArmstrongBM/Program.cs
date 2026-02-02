// See https://aka.ms/new-console-template for more information
namespace EsArmstrongBM 
{ 
    internal class Program 
    {
        static void Main(string[] args)
        {

            double somma = 0;
            bool x;
            int n1,cifra, lung;
            string str = "";
            Console.WriteLine("Siamo un sistema bancario basato su numeri di Armstrong");
            Console.WriteLine("Il programma dirà se il numero rispetta i criteri di Armstrong");
            //Console.WriteLine("Inserisci un numero intero positivo:");
            //x = int.TryParse(Console.ReadLine(), out n1);
            do
            {
                Console.WriteLine("Devi inserire un numero intero positivo:");
                x = int.TryParse(Console.ReadLine(), out n1);
            } while (!x || n1 < 0);
            str = n1.ToString();
            lung=str.Length;
            
            for (int i = 0; i < str.Length; i++)
            {
                cifra= int.Parse(str[i].ToString());
                somma += Math.Pow(cifra, lung);
            }
            if(somma==n1)
            {
                Console.WriteLine("Il numero " + n1 + " è un numero di Armstrong");
            }
            else
            {
                Console.WriteLine("Il numero " + n1 + " non è un numero di Armstrong");
            }
        }
    }
}
