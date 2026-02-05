// See https://aka.ms/new-console-template for more information
using static System.Console;

namespace EsParMagBM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vocali = "aeiou";
            string parola = "";
            
            while(parola.Length == 0)
            {
                Write("Inserisci una parola: ");
                parola = ReadLine().ToLower();//prendo in imput la parola e la trasformo in minuscola per verificare la presenza delle vocali
            }
            for (int i = 0; i < parola.Length; i++)
            {
                // Cerco dove si trova la vocale della parola dentro la stringa "aeiou"
                int indiceVocale = vocali.IndexOf(parola[i]);

                // IndexOf restituisce -1,se la vocale non  è presente
                if (indiceVocale != -1)
                {
                    // do alla stringa il valore senza la vocale trovata
                    vocali = vocali.Remove(indiceVocale, 1);
                }
            }

            // Se è rimasta massimo 1 vocale, voul dire che ne ho trovate almeno tre
            if (vocali.Length <= 1)
                WriteLine("La parola è MAGICA");
            else
                WriteLine("La parola NON è magica");
        }
    }
}
