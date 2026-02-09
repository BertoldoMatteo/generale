
using System;
using System.Collections.Generic;
using static System.Console;

namespace EsCinemaEmuStructBM
{
    enum TipoBiglietto
    {
        Standard,
        Ridotto,
        VIP
    }

    enum StatoPrenotazione
    {
        Prenotato,
        Pagato,
        Annullato
    }

    struct Biglietto
    {
        public int numeroDiPosto;
        public TipoBiglietto tipo;
        public StatoPrenotazione statoPren;
        public DateTime data;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Biglietto> listaBiglietti = new List<Biglietto>();
            int scelta = 0;
            bool Valid = false;
            do
            {
                WriteLine("MENU' CINEMA");
                WriteLine("1. Crea un biglietto");
                WriteLine("2. Paga un biglietto");
                WriteLine("3. Annulla un biglietto");
                WriteLine("4. Visualizza i biglietti");
                WriteLine("0. Esci");
                while (!Valid)
                {
                    Write("Cosa vuoi fare? ");
                    Valid = int.TryParse(ReadLine(), out scelta) && scelta >= 0 && scelta <= 4;
                }


                switch (scelta)
                {
                    case 1:
                        // CREO BIGLIETTO
                        Biglietto nuovo = new Biglietto();

                        Write("Inserisci il numero del posto: ");
                        nuovo.numeroDiPosto = Convert.ToInt32(ReadLine());

                        WriteLine("Scegli il tipo (0: Standard, 1: Ridotto, 2: VIP):");
                        int tipoScelto = Convert.ToInt32(ReadLine());
                        nuovo.tipo = (TipoBiglietto)tipoScelto;

                        nuovo.data = DateTime.Now;
                        nuovo.statoPren = StatoPrenotazione.Prenotato;

                        listaBiglietti.Add(nuovo);
                        WriteLine("Biglietto salvato con successo!");
                        break;
                    case 2:
                        // PAGARE BIGLIETTO
                        Write("Inserisci l'indice del biglietto da pagare: ");
                        int indice = Convert.ToInt32(ReadLine());

                        if (indice >= 0 && indice < listaBiglietti.Count)
                        {
                            Biglietto b = listaBiglietti[indice];
                            b.statoPren = StatoPrenotazione.Pagato;
                            listaBiglietti[indice] = b;
                            WriteLine("Stato aggiornato a PAGATO!");
                        }
                        else
                        {
                            WriteLine("Indice non valido!");
                        }
                        break;
                    case 3:
                        // ANNULLARE BIGLIETTO
                        Write("Inserisci l'indice del biglietto da annullare: ");
                        int indice = Convert.ToInt32(ReadLine());

                        if (indice >= 0 && indice < listaBiglietti.Count)
                        {
                            Biglietto b = listaBiglietti[indice];
                            b.statoPren = StatoPrenotazione.Annullato;
                            listaBiglietti[indice] = b;
                            WriteLine("Stato aggiornato a ANNULLATO!");
                        }
                        else
                        {
                            WriteLine("Indice non valido!");
                        }
                        break;
                    case 4:

                        // VISUALIZZARE BIGLIETTI
                        WriteLine("\nELENCO BIGLIETTI:");
                        if (listaBiglietti.Count == 0)
                        {
                            WriteLine("Nessun biglietto in lista.");
                        }
                        else
                        {
                            for (int i = 0; i < listaBiglietti.Count; i++)
                            {
                                Biglietto b = listaBiglietti[i];
                                WriteLine($"Indice: {i}");
                                WriteLine($"Posto: {b.numeroDiPosto}");
                                WriteLine($"Tipo: {b.tipo}");
                                WriteLine($"Stato: {b.statoPren}");
                                WriteLine($"Data: {b.data.ToShortDateString()}");
                                WriteLine("");
                            }
                        }
                        break;
                    default:
                        WriteLine("Errore nella compilazione");
                        break;
                }
            } while (scelta != 0)
        }
    }
}
