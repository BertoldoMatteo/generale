using EsManutenzioneBM;
using Microsoft.Win32;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public CRegistroManutenzioni registro;
    public string str;
    public int scelta, count;
    public double costo;
    public DateTime data;
    public bool Valid, continuare;


    public static void Main(string[] args)
    {
        Program p = new Program();
        p.registro = new CRegistroManutenzioni();
        Console.WriteLine("BENVENUTO NELLA GESTIONE DELLE MANUTENZIONI");
        do
        {
            p.Input();
        } while (p.continuare);
        
    }

    public void Input()
    {
        Console.WriteLine("Cosa vuoi fare?");
        Console.WriteLine("0 - Aggiungi un intervento");
        if (registro.Interventi.Count > 0)
        {
            Console.WriteLine("1 - Rimuovi un intervento");
            Console.WriteLine("2 - Ricerca un intervento");
            Console.WriteLine("3 - Stampa registro");
            Console.WriteLine("4 - Stampa un report avanzato");
            do
            {
                Console.WriteLine("Inserisci il numero corrispondente all'azione che si vuole eseguire");
                Valid = int.TryParse(Console.ReadLine(), out scelta);
            } while (!Valid || scelta < 0 || scelta > 4);
        }
        else
        {
            do
            {
                Console.WriteLine("Inserisci il numero corrispondente all'azione che si vuole eseguire");
                Valid = int.TryParse(Console.ReadLine(), out scelta);
            } while (!Valid || scelta != 0);
        }

        switch (scelta)
        {
            case 0:
                AggiungiIntervento();
                break;
            case 1:
                RimuoviIntervento();
                break;
            case 2:
                RicercaIntervento();
                break;
            case 3:
                Console.WriteLine(registro.Stamparegistro());
                break;
            case 4:
                GeneraReportAvanzato();
                break;
        }
        Console.WriteLine("Vuoi continuare? (Y = 0/N = 1)");
        do
        {
            Valid = int.TryParse(Console.ReadLine(), out scelta);
        } while (!Valid || (scelta != 0 && scelta != 1));
        
        continuare = scelta == 0 ? true : false;
    }

    public void AggiungiIntervento()
    {
        CIntervento intervento = new CIntervento();
        try
        {
            intervento.CodiceIntervento = registro.Interventi.Count; //il codice vale 0 se è il primo
            do
            {
                Console.WriteLine("Inserisci categoria dell'Intervento (1/2/3):\n1 = Controllo\n2 = Riparazione\n3 = Sostituzione");
                Valid = int.TryParse(Console.ReadLine(), out scelta);
            } while (!Valid && scelta < 1 && scelta > 3);

            intervento.CategoriaIntervento = (Categoria)(scelta-1);

            Console.WriteLine("Inserisci il costo dell'intervento");
            double.TryParse(Console.ReadLine(), out costo);
            intervento.CostoIntervento = costo;

            do
            {
                Console.WriteLine("Inserisci data intervento");
                Valid = DateTime.TryParse(Console.ReadLine(), out data); //utilizzo il formato DateTime per la data
            } while (!Valid || data > DateTime.Now);

        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        

        registro.AggiungiIntervento(intervento);

    }

    public void RimuoviIntervento()
    {
        Console.WriteLine($"Inserisci il codice Intervento dell'intervento che vuoi eliminare(0-{registro.Interventi.Count})");
        do
        {
            Valid = int.TryParse(Console.ReadLine(), out scelta);
        } while (!Valid || scelta < 0 || scelta >= registro.Interventi.Count);
        registro.RimuoviIntervento(scelta);
    }

    public void RicercaIntervento()
    {
        Console.WriteLine($"Inserisci il codice Intervento da cercare(0-{registro.Interventi.Count})");
        do
        {
            Valid = int.TryParse(Console.ReadLine(), out scelta);
        } while (!Valid || scelta < 0 || scelta >= registro.Interventi.Count);
        Console.WriteLine(registro.RicercaIntervento(scelta));
    }
    public void GeneraReportAvanzato()
    {
        Console.WriteLine("INTERVENTI PER CATEGORIA");
        foreach (Categoria cat in Enum.GetValues<Categoria>()) //stampo numero interventi per categoria
        {
            Console.WriteLine($"\nCATEGORIA : {cat}\nINTERVENTI : {registro.ContaInterventiPerCategoria((Categoria)cat)}" +
                $"\nCOSTO MEDIO : {registro.CalcoloCostiPerCategoria((Categoria)cat)}");
        }
        Console.WriteLine($"\nCOSTO MINIMO = {registro.CostoMin()}\nCOSTO MASSIMO = {registro.CostoMax()}");
        Console.WriteLine($"N° INTERVENTO = {registro.Interventi.Count}");
        Console.WriteLine($"TOT. COSTI = {registro.CalcoloTotaleCosti()}");
        Console.WriteLine($"INTERVENTI CRITICI : \n{registro.InterventiCritici()}");
    }

    
}