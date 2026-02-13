// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices.Marshalling;
using System.Security;
using static System.Console;
namespace EsArrSomma50
{
    class Program
    {
        static void Main()
        {
            float[] arr = new float[100];
            arr[99] = 0;
            arr = Lettura(arr);

            Verifica(arr);
        }

        static float[] Lettura(float[] arr)
        {
            float somma = 0, n;
            bool Valid;
            int i = 0;
            arr = new float[100];
            do
            {
                do
                {
                    Write($"Inserisci il {i + 1}° numero: ");
                    Valid = float.TryParse(ReadLine(), out n);

                } while (!Valid && n!=0);
                arr[i] = n;
                somma += n;
                i++;
            } while (somma <= 50 || arr[99] != 0);
            return arr;
        }

        static void Verifica(float[] arr)
        {
            double rapp = Math.Abs(arr[0]);

            for(int i=1; i<arr.Length; i++)
            {
                for(int j=i+1; j<arr.Length; j++)
                {
                    if (Math.Abs(arr[i] / arr[j]) == rapp || Math.Abs(arr[j] / arr[i]) == rapp)
                    {
                        WriteLine($"Il rapporto tra {arr[j]} e {arr[i]} vale {rapp}");
                    }
                }
            }
            WriteLine("FINE");
        }
    }
}
