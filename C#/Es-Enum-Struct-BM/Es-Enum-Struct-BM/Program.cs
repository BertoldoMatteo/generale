// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using static System.Console;

namespace EsCinemaEmuStructBM
{
    struct GestoreCinema
    {
        //Inizializzo gli Enum per accettare solo le scelte disponibili
        public enum TipoBiglietto { Standard, Ridotto, VIP }
        public enum StatoPrenotazione { Prenotato, Pagato, Annullato }

        //Costruttore
        public struct Biglietto
        {
            public int numeroDiPosto;
            public TipoBiglietto tipo;
            public StatoPrenotazione statoPren;
            public DateTime data;
        }

        //Inizializzo la lista dove inserirre ibiglietti
        public List<Biglietto> listaBiglietti;

        //Inizializzo un nuovo biglietto da inserire nella lista
        public void Inizializza()
        {
            listaBiglietti = new List<Biglietto>();
        }

        //Funzione per la lettura dei numeri ,evito errori del programma con funzione TryParse
        public int LeggiNumero()
        {
            int numero;
            bool successo = int.TryParse(ReadLine(), out numero);
            return successo ? numero : -1;
        }

        // Metodo per creare nuovo biglietto
        public void Crea()
        {
            Biglietto nuovo = new Biglietto();

            //Chiedo il posto e verifico SUBITO se è libero
            do
            {
                Write("Inserisci il numero del posto: ");
                nuovo.numeroDiPosto = LeggiNumero();
            } while (!VerificaDisp(nuovo.numeroDiPosto));

            //Se il posto è libero, procedo con il tipo di biglietto
            int t;
            do
            {
                WriteLine("Scegli il tipo (0: Standard, 1: Ridotto, 2: VIP):");
                t = LeggiNumero();
            } while (t < 0 || t > 2);

            nuovo.tipo = (TipoBiglietto)t;
            nuovo.data = DateTime.Now;
            nuovo.statoPren = StatoPrenotazione.Prenotato;

            listaBiglietti.Add(nuovo);
            WriteLine("Biglietto salvato con successo.");
        }

        //Metodo per verificare la disponibilità
        public bool VerificaDisp(int numeroPosto)
        {
            for (int i = 0; i < listaBiglietti.Count; i++)
            {
                //Se trovo il posto il metodo restituisce falso
                if (listaBiglietti[i].numeroDiPosto == numeroPosto && listaBiglietti[i].statoPren != StatoPrenotazione.Annullato)
                {
                    WriteLine("Errore: questo posto è già occupato!");
                    return false;
                }
            }
            return true; //Se non trovo altri biglietti con lo stesso posto, il posto è libero
        }

        //Metodo per cambiare lo stato del biglietto se viene pagato
        public void Paga()
        {
            Visualizza();
            Write("Inserisci l'indice del biglietto da pagare: ");
            int indice = LeggiNumero();

            if (indice >= 0 && indice < listaBiglietti.Count)
            {
                Biglietto b = listaBiglietti[indice];
                b.statoPren = StatoPrenotazione.Pagato;
                listaBiglietti[indice] = b;
                WriteLine($"Stato del biglietto {indice} aggiornato a PAGATO.");
            }
            else WriteLine("Indice non valido.");
        }

        //Metodo per annullare un biglietto
        public void Annulla()
        {
            Visualizza();
            Write("Inserisci l'indice del biglietto da annullare: ");
            int indice = LeggiNumero();

            if (indice >= 0 && indice < listaBiglietti.Count)
            {
                Biglietto b = listaBiglietti[indice];
                b.statoPren = StatoPrenotazione.Annullato;
                listaBiglietti[indice] = b;
                WriteLine($"Stato del biglietto {indice} aggiornato a ANNULLATO.");
            }
            else WriteLine("Impossibile trovare il biglietto specificato.");
        }

        //Metodo per visualizzare tutti i biglietti con interpolazione stringhe
        public void Visualizza()
        {
            string titolo = (listaBiglietti.Count == 0) ? "NESSUN BIGLIETTO" : "ELENCO BIGLIETTI";
            WriteLine($"\n--- {titolo} ---");

            for (int i = 0; i < listaBiglietti.Count; i++)
            {
                Biglietto b = listaBiglietti[i];
                WriteLine($"Indice: {i} | Posto: {b.numeroDiPosto} | Tipo: {b.tipo} | Stato: {b.statoPren} | Data: {b.data.ToShortDateString()}");
            }
        }

        //Metodo principale che richiama gli altri metodi della struct all'occorrenza
        public void AvviaProgramma()
        {
            Inizializza();
            int scelta;

            do
            {
                WriteLine("\nMENU CINEMA");
                WriteLine("1. Crea biglietto");
                WriteLine("2. Paga biglietto");
                WriteLine("3. Annulla biglietto");
                WriteLine("4. Visualizza tutti");
                WriteLine("0. Esci");
                Write("Inserisci scelta: ");
                scelta = LeggiNumero();

                switch (scelta)
                {
                    case 1: Crea(); break;
                    case 2: Paga(); break;
                    case 3: Annulla(); break;
                    case 4: Visualizza(); break;
                    case 0: WriteLine("Uscita dal programma."); break;
                    default: WriteLine("Opzione non valida, riprova."); break;
                }
            } while (scelta != 0);
        }
    }
    //Programma effettivo che richiama l'utilizzo di tutta la struct
    class Program
    {
        static void Main(string[] args)
        {
            GestoreCinema Cinema = new GestoreCinema();
            Cinema.AvviaProgramma();
        }
    }
}
