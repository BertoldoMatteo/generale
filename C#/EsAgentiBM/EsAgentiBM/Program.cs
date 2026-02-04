// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using static System.Console;
namespace EsAgentiBM
{
    internal class Program
    {
        static bool Som(int n)
        {
            if (n % 3 == 0)//verifico che il numero sia divisibile per tre
            {
                return true;
            }
            return false;
        }

        static bool Prod(int n)
        {
            string num = n.ToString();
            for(int i=0; i<num.Length; i++)// verifico che almeno una cifra sia pari, così da rendere il prodotto pari
            {
                if (num[i] % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int N = 0;
            bool ValidInput = false, cond2=false, cond1;
            while (!ValidInput)
            {
                Write("Inserisci un numero per verifcare se è valido: ");
                ValidInput = int.TryParse(ReadLine(), out N) && N > 0;
                WriteLine(" ");
            }
            cond1 = Som(N);// se la somma delle cifre è disibile per 3 significa che quel numero è divisibile per tre
            cond2 = Prod(N);// pk il prodotto sia pari basta che sia presente almeno una cifra pari all'interno del numero
            if(cond2 && cond2)
            {
                WriteLine($"Il numero {N} è valido");
            }
            else
            {
                WriteLine($"Il numero {N} non è valido");
            }
        }
    }

}
