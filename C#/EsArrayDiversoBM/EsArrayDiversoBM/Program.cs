// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Security;
namespace EsArrayDiversoBM
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, num;
            bool Valid;
            Console.WriteLine("Questo programma chiederà numeri in input e stamperà 1 se sono tutti diversi, altrimenti 0");
            do
            {
                Console.Write("Inserisci quanti numeri vuoi inserire: ");
                Valid = int.TryParse(Console.ReadLine(), out n);

            } while (!Valid);

            Valid = false;

            int[] arr = Lettura(n);

            Valid = Verifica(arr);

            if (Verifica(arr))
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            } 

        }

        static int[] Lettura(int n)
        {
            int[] arr;
            bool Valid;
            int num;
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.Write($"Inserisci il {i + 1}° numero: ");
                    Valid = int.TryParse(Console.ReadLine(), out num);
                } while (!Valid);
                arr[i] = num;
            }
            return arr;
        }

        static bool Verifica(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if(arr[i] == arr[j]) return false;
                }
            }
            return true;
        }
    }
}
