using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EsClasseLibro
{
    internal class Program
    {
        public static int scelta ,idx = 0, anno, pagine;
        public static string nome="", cognome= "", sesso= "", nascita = "", titolo = "";
        public static DateOnly data;
        public static List<Autore> elencoAutori = new List<Autore>();
        public static List<Libro> elencoLibri = new List<Libro>();
        public static Biblioteca biblio = new Biblioteca("ITIS ROSSI", elencoAutori, elencoLibri);
        public static Autore autore;
        public static Libro libro;

        static void Main(string[] args)
        {
            do
            {
                Input();
                Console.WriteLine("ATTENZIONE !! PER TERMINARE IL PROGRAMMA DIGITARE \"END\", altrimenti digita quello che vuoi");
            } while(Console.ReadLine() != "END");
        }

        public static void Input()
        {
            Console.WriteLine("Inserisci quale operazione svolgere: ");
            Console.WriteLine("1 - Aggiungi Autore");
            Console.WriteLine("2 - Aggiungi Libro");
            Console.WriteLine("3 - Visualizza Autori");
            Console.WriteLine("4 - Visualizza Libri");
            Console.WriteLine("5 - Autori in un anno");

            int.TryParse(Console.ReadLine(), out scelta);
            switch (scelta) {
                case 1:
                    autore = AggiungiAut();
                    biblio.AggiungiAutore(autore);
                    break;
                case 2:
                    libro = AggiungiLib();
                    biblio.AggiungiLibro(libro);
                    break;
                case 3:
                    VisualizzaAutori();
                    break;
                case 4:
                    VisualizzaLibri();
                    break;
                case 5:
                    Console.WriteLine(AutoriInAnno());
                    break;
                default:
                    Console.WriteLine("Inserire un numero valido(1-5)");
                    break;
            }
        }

        public static Autore AggiungiAut()
        {
            Console.WriteLine("Inserisci cognome autore:");
            do
            {
                cognome = Console.ReadLine();
            }while (string.IsNullOrEmpty(cognome));

            Console.WriteLine("Inserisci nome autore:");
            do
            {
                nome = Console.ReadLine();
            } while (string.IsNullOrEmpty(nome));

            Console.WriteLine("Inserisci il sesso dell' autore (M-F):");
            do
            {
                sesso = Console.ReadLine();
            } while (sesso != "M" && sesso != "F");

            do
            {
                Console.WriteLine("Inserisci una data (gg/mm/aaaa):");
                nascita = Console.ReadLine();
            } while (!DateOnly.TryParse(nascita, out data) || data > DateOnly.FromDateTime(DateTime.Now));

            Autore autore = new Autore(cognome, nome, sesso == "M" ? true : false, data);
            return autore;
        }

        public static Libro AggiungiLib()
        {
            Console.WriteLine("Inserisci titolo del libro:");
            do
            {
                titolo = Console.ReadLine();
            } while (string.IsNullOrEmpty(titolo));

            Autore autore = AggiungiAut();
            Console.WriteLine("Inserisci anno uscita del libro:");
            do
            {
                int.TryParse(Console.ReadLine(), out anno);
            } while (anno > DateTime.Now.Year);

            Console.WriteLine("Inserisci numero pagine del libro:");
            do
            {
                int.TryParse(Console.ReadLine(), out pagine);
            } while (pagine < 0);

            Libro lib = new Libro(titolo, autore, anno, pagine);

            return lib;
        }

        public static void VisualizzaAutori()
        {
            Console.WriteLine("Elenco Autori:");
            Console.WriteLine(biblio.StampaAutori());
        }

        public static void VisualizzaLibri()
        {
            Console.WriteLine("Elenco Libri:\n");
            Console.WriteLine(biblio.StampaLibri());
        }

        public static string AutoriInAnno()
        {
            string str = "";
            Console.WriteLine("Inserisci anno in cui cercare");
            do
            {
                int.TryParse(Console.ReadLine(), out anno);
            } while (anno > DateTime.Now.Year);

            foreach(Autore autore in biblio.ElencoAutoriAnno(anno))
            {
                str += autore.Info() + '\n';
            }

            return str;
        }
    }
}
