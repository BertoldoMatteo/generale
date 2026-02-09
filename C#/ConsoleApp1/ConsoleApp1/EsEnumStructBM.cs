using System;
using System.Collections.Generic;
using static System.Console;

namespace EsCinemaEmuStructBM
{
    struct GestoreCinema
    {
        // Definizioni delle opzioni tramite Enum
        public enum TipoBiglietto { Standard, Ridotto, VIP }
        public enum StatoPrenotazione { Prenotato, Pagato, Annullato }

        // Struttura dati per il singolo biglietto
        public struct Biglietto
        {
            public int numeroDiPosto;
            public TipoBiglietto tipo;
            public StatoPrenotazione statoPren;
            public DateTime data;
        }

        // Lista che funge da database dei biglietti
        public List<Biglietto> listaBiglietti;

        // Metodo per creare la lista
        public void Inizializza()
        {
            listaBiglietti = new List<Biglietto>();
        }

        // Funzione per la lettura sicura dei numeri (evita crash se l'utente inserisce lettere)
        public int LeggiNumero()
        {
            int numero;
            bool successo = int.TryParse(ReadLine(), out numero);
            return successo ? numero : -1;
        }

        // Metodo per creare un nuovo biglietto
        public void Crea()
        {
            Biglietto nuovo = new Biglietto();
            Write("Inserisci il numero del posto: ");
            nuovo.numeroDiPosto = LeggiNumero();

            WriteLine("Scegli il tipo (0: Standard, 1: Ridotto, 2: VIP):");
            int t = LeggiNumero();
            // Ternario per gestire scelte fuori range
            nuovo.tipo = (t >= 0 && t <= 2) ? (TipoBiglietto)t : TipoBiglietto.Standard;

            nuovo.data = DateTime.Now;
            nuovo.statoPren = StatoPrenotazione.Prenotato;

            listaBiglietti.Add(nuovo);
            WriteLine("Biglietto salvato con successo.");
        }

        // Metodo per impostare un biglietto come pagato
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

        // Metodo per annullare un biglietto
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

        // Metodo per visualizzare tutti i biglietti con interpolazione stringhe
        public void Visualizza()
        {
            string titolo = (listaBiglietti.Count == 0) ? "NESSUN BIGLIETTO" : "ELENCO BIGLIETTI";
            WriteLine($"\n--- {titolo} ---");

            for (int i = 0; i < listaBiglietti.Count; i++)
            {
                Biglietto b = listaBiglietti[i];
                // Utilizzo di $ e {} per una stampa pulita
                WriteLine($"Indice: {i} | Posto: {b.numeroDiPosto} | Tipo: {b.tipo} | Stato: {b.statoPren} | Data: {b.data.ToShortDateString()}");
            }
        }

        // Ciclo principale del programma
        public void AvviaProgramma()
        {
            Inizializza();
            int scelta = -1;

            while (scelta != 0)
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
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GestoreCinema mioCinema = new GestoreCinema();
            mioCinema.AvviaProgramma();
        }
    }
}