// See https://aka.ms/new-console-template for more information
namespace EsArrayGeneraBM
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            int[] arr2;
            
            arr = CreaArray();
            Console.WriteLine("questo programma ha generato un array di 30 numeri da 0 a 100 e ora stamperà le coppie di numeri tali che il primo sia il doppio del secondo");
            arr2 = Coppie(arr);
            Stampa(arr2);
            StampaArray(arr);
        }

        static int[] CreaArray()
        {
            Random rand = new Random();
            int[] arr = new int[30];
            for(int i=0; i<30; i++)
            {
                arr[i] = rand.Next(0, 101);
            }
            return arr;
        }
        static int[] Coppie(int[] arr)
        {
            int[] arr2 = new int[30];
            int k = 0;
            for (int i = 0; i < 30; i++)
            {
                for(int j=i; j<30; j++)
                {
                    if (arr[i] == 2 * arr[j] || arr[j] == 2 * arr[i])
                    {
                        if (arr[i]> arr[j])
                        {
                            arr2[k] = arr[i];
                            arr2[k + 1] = arr[j];
                        }
                        else
                        {
                            arr2[k] = arr[j];
                            arr2[k+1] = arr[i];
                        }

                            k += 2;
                    }
                }
            }
            return arr2;
        }

        static void Stampa(int[] arr2)
        {
            int z = 1;
            for(int i=0; i<arr2.Length; i+=2)
            {
                if (arr2[i] == 0)
                {
                    return;
                }
                Console.WriteLine($"Coppia {z}: {arr2[i]} / {arr2[i+1]}");
                z++;
            }
        }
        static void StampaArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i ++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
