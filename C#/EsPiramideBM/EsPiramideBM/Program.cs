// See https://aka.ms/new-console-template for more information
using static System.Console;
namespace EsPiramideBM
{
    internal class Program
    {
        static void Main()
        {
            int N=0, diff;
            bool ValidInput = false;
            while (!ValidInput)
            {
                WriteLine("Inserisci un valore e il programma stamperà una piramide di quella altezza");
                ValidInput = int.TryParse(ReadLine(), out N);
            }
            for(int i = 0; i <N; i++) // for per stampare N righe
            {
                for (int j = 1; j < N*2; j++) // for per stampare ogni elemento della riga
                {
                    if (i + j >= N)//verifico se posso stampare i numeri
                    {
                        if (j > N)// verifico se i numeri sono a destra del centro
                        {
                            diff = j - N;// calcolo la differenza pk a destra vanno decrescendo
                            if (diff > i)//calcolo quando smettere di stampare
                            {
                                Write(" ");//stampo gli spazi a destra
                            }
                            else
                            {
                                Write(j - (diff*2)-(N-i)+1); //calcolo i numeri da stampare a destra del centro
                            }
                                
                        }
                        else
                        {
                            Write(j-(N-i)+1);// stampo i numeri a sinistra del centro
                        }
                    }
                    else
                    {
                        Write(" ");//stampo gli spazi a sinistra
                    }
                }
                WriteLine("");// vado a acaporiga dopo ogni riga;
            }
        }
    }
}
