// See https://aka.ms/new-console-template for more information
using static System.Console;
namespace EsRobotBM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ValidInput = false, inc=false;
            int n1=0;// percorso numerico
            string p;// percorso
            while (!ValidInput)
            {
                Write("Inserisci una serie di numeri per vedere se è sicura per il robot: ");
                ValidInput=int.TryParse(ReadLine(), out n1) && n1 > 0;
            }
            p = n1.ToString();
            n1 = p[0];
            for (int i=1;i<p.Length; i++)
            {
                if ((n1 > p[i] && inc) || i==0)
                {
                    n1 = p[i];
                    inc = false;
                }
                else if ((n1 < p[i] && !inc) || i==0)
                {
                    n1 = p[i];
                    inc = true;
                }
                else
                {
                    WriteLine("Percorso NON sicuro per il robot");
                    return;
                }
            }
            WriteLine("Percorso sicuro per il Robot");
            
        }
    }
}

