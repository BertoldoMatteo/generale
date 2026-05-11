using System.Security.Cryptography.X509Certificates;

namespace EsDictionaryBiblioteca
{
    internal class Program
    {
        public static Dictionary<int, Libro> biblioteca { get; set; }  //punto 1
        public static Libro libro;
        public static int ISBN, anno;
        public static bool trovato;
        public static void Main(string[] args)
        {
            biblioteca = new Dictionary<int, Libro>(); // punto 1
            trovato = false;
            libro = new Libro();

            for (int i = 0; i < 5; i++) //punto 2
            {
                Console.WriteLine("\nAggiungi libro");
                
                AggiungiLibro();
            }

            do // punto 3
            {
                Console.Write("Inserisci un ISBN per verificare la presenza: ");
            } while (!int.TryParse(Console.ReadLine(), out ISBN));

            foreach (var i in biblioteca) //punto 3
            {
                if (i.Key == ISBN)
                {
                    Console.WriteLine("ISBN già presente");
                    trovato = true;
                }
            }
            if (!trovato) Console.WriteLine("ISBN non presente");


            AggiungiLibro(); //punto 5


            do // punto 5
            {
                Console.Write("Inserisci un ISBN per modificare il titolo : ");
            } while (!int.TryParse(Console.ReadLine(), out ISBN));

            foreach (var i in biblioteca) //punto 3
            {
                if (i.Key == ISBN)
                {
                    Console.Write("Inserisci il nuovo titolo : ");
                    biblioteca[ISBN].Titolo = Console.ReadLine();
                }
            }
            if (!trovato) Console.WriteLine("ISBN non presente");


            do // punto 6
            {
                Console.Write("Inserisci un ISBN per eliminare il libro : ");
            } while (!int.TryParse(Console.ReadLine(), out ISBN));

            foreach (var i in biblioteca) //punto 6
            {
                if (i.Key == ISBN)
                {
                    biblioteca.Remove(ISBN);
                }
            }
            if (!trovato) Console.WriteLine("ISBN non presente");


            foreach (var i in biblioteca) //punto 7
            {
                Console.WriteLine(i.Key + " -> " + i.Value.Print());
            }
        }

        public static void AggiungiLibro()
        {
            do
            {
                Console.Write("Inserisci codice ISBN : ");
            } while (!int.TryParse(Console.ReadLine(), out ISBN));

            libro = new Libro();
            Console.Write("inserisci titolo del libro : ");
            libro.Titolo = Console.ReadLine();
            Console.Write("Inserisci l'Autore del libro : ");
            libro.Autore = Console.ReadLine();
            try
            {
                do
                {
                    Console.Write("Inserisci l'anno di pubblicazione del libro : ");
                } while (!int.TryParse(Console.ReadLine(), out anno));
                libro.Anno = anno;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("INSERISCI NUOVAMENTE\n");
                AggiungiLibro();
            }
            biblioteca[ISBN] = libro;
        }


    }
}
