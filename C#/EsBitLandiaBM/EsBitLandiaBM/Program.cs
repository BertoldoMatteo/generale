// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using static System.Console;
namespace EsBitLandiaBM
{
    public enum TipoMostro
    {
        Fuoco,
        Acqua,
        Erba,
        Elettrico,
        Roccia
    }

    public enum LivelloEnergia
    {
        Basso,
        Medio,
        Alto
    }
    public struct Mostri
    {
        public int codice;
        public TipoMostro tipo;
        public LivelloEnergia energia;
        public int età;
        public int forza;
        public string allenatore;

        public Mostri(int id, TipoMostro type, LivelloEnergia energy, int age, int power, string coach)
        {
            this.codice = id;
            this.tipo = type;
            this.energia = energy;
            this.età = age;
            this.forza = power;
            this.allenatore = coach;
        }

        public bool ÈAllenabile()
        {
            if (energia != LivelloEnergia.Basso)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CambiaAllenatore(string nuovoAllenatore)
        {
            allenatore=nuovoAllenatore;
        }

        public void Allenati(int punti)
        {
            forza += punti;
        }

        public string Descrizione(int n)
        {
            return $"Mostro numero: {n} \nCodice identificativo = {codice} \nTipo mostro = {tipo} \nLivello energia = {energia}\nEtà = {età}\nForza = {forza}/100\nAllenatore = {allenatore}\n\n";
        }
    }
    class Program
    {
        public static Mostri[]? arr;
        static void Main(string[] args)
        {
            bool finish = false;
            arr = new Mostri[5];
            int count = 0, scelta = 0;
            Mostri mostro;
            Presenta();

            do
            {
                scelta = Input(count);

                switch (scelta)// per verificare tutte le opzioni
                {
                    case 0:
                        finish = true;
                        break;
                    case 1:
                        mostro = Aggiungi(count);
                        arr[count] = mostro;
                        count++;
                        break;
                    case 2:
                        AllenaMostro(count);
                        break;
                    case 3:
                        CambiaAllenatore(count);
                        break;
                    case 4:
                        ScambioAllenatori(count);
                        break;
                    case 5:
                        Stampa(count);
                        break;
                    case 6:
                        StampaTipo(count);
                        break;
                    case 7:
                        StampaEnergia(count);
                        break;
                    }
            } while (!finish);

        }

        static void Presenta()
        {
            WriteLine("Benvenuto nel Centro Addestramento Mostri Digitali");
            WriteLine("");
            WriteLine("!!!Attenzione!!!");
            WriteLine("In questo mercato accettiamo e teniamo solo alcuni tipi di mostri:");
            WriteLine("-Fuoco");
            WriteLine("-Acqua");
            WriteLine("-Erba");
            WriteLine("-Elettrico");
            WriteLine("-Roccia");
            WriteLine("Ogni mostro può avere tre livelli di energia( Basso / Medio / Alto )");
            WriteLine("");
        }

        static int Input(int count)
        {
            int n = 1;
            WriteLine("Cosa vuoi svolgere?");
            if (count >= 1)
            {
                if (count < 5)
                {
                    WriteLine($"1) Lasciare il tuo mostro (liberi = {5 - count})");
                }
                WriteLine("2) Allena un mostro");
                WriteLine("3) Cambia allenatore a un mostro");
                WriteLine("4) Scambia allenatore tra mostri");
                WriteLine("5) Visualizza elenco mostri");
                WriteLine("6) Filtra per tipo mostro");
                WriteLine("7) Filtra per livello di energia");
                WriteLine("0) Exit");

            }
            else
            {
                WriteLine($"1) Lasciare il tuo mostro (liberi = {5 - count})");
            }

            do
            {
                WriteLine("Inserisci il numero dell'azione corrispondente");
            } while ((!int.TryParse(ReadLine(), out n)) || n < 0 || n > 7);
            return n;
        }

        static Mostri Aggiungi(int count)
        {
            int id, power, age;
            TipoMostro type;
            LivelloEnergia energy;
            string coach = "";

            id = count;

            do
            {
                Write("Tipo: ");
            } while (!TipoMostro.TryParse(ReadLine(), out type) || (int)type < 0 || (int)type > 4);

            do
            {
                Write("Livello energia: ");
            } while (!LivelloEnergia.TryParse(ReadLine(), out energy) || (int)energy < 0 || (int)energy > 2);

            do
            {
                Write("Età: ");
            } while (!int.TryParse(ReadLine(), out age) || age <= 0);

            do
            {
                Write("Forza(1..100): ");
            } while (!int.TryParse(ReadLine(), out power) || power < 1 || power > 100);

            Write("Nome del proprietario: ");
            coach = ReadLine();

            Mostri mostro = new Mostri(id, type, energy, age, power, coach);
            return mostro;
        }

        static void AllenaMostro(int count)
        {
            int id, energy;
            do
            {
                Write("Inserisci codice univoco mostro da allenare: ");
            } while (!int.TryParse(ReadLine(), out id) || id < 1 || id > count);

            Mostri mostro = arr[id - 1];

            if (!mostro.ÈAllenabile())
            {
                WriteLine("Livello energia troppo basso");
            }
            else if (mostro.forza == 100)
            {
                WriteLine("La forza è già al massimo!");
            }
            else
            {
                energy = (int)mostro.energia;
                energy -= 1;
                mostro.energia = (LivelloEnergia)energy;

                mostro.forza += 10;
                if (mostro.forza == 100)
                {
                    mostro.forza = 100;
                    WriteLine("Limite forza raggiunto : MAX POWER");
                }
                else
                {
                    WriteLine($"Forza aumentata di 10 \n Forza attuale = {mostro.forza}");
                }
                WriteLine($"Livello di energia : {mostro.energia}");
            }
        }
        static void CambiaAllenatore(int count)
        {
            int id;
            string Allenatore;
            do
            {
                Write("Codice univoco mostro (a cui cambiare allenatore): ");
            } while (!int.TryParse(ReadLine(), out id) || id < 1 || id > count);
            do
            {
                WriteLine("Nuovo allenatore: ");
                Allenatore = ReadLine();
            } while (Allenatore == null);
            Mostri mostro = arr[id - 1];
            mostro.allenatore = Allenatore;
        }

        static void ScambioAllenatori(int count)
        {
            bool trovato = false, trovato1 = false;
            string Allenatore, Allenatore1;
            Mostri[]? arr1 = arr;
            if (count <= 1)
            {
                WriteLine("Devi avere almeno due mostri per scambiarli di allenatore");
            }
            else
            {
                do
                {
                    WriteLine("Inserisci il nome del primo allenatore da scambiare");
                    Allenatore = ReadLine();
                } while (Allenatore == null);

                do
                {
                    WriteLine("Inserisci il nome del secondo allenatore da scambiare");
                    Allenatore1 = ReadLine();
                } while (Allenatore1 == null);

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].allenatore == Allenatore1)
                    {
                        trovato=true;
                    }
                    else if (arr[i].allenatore == Allenatore)
                    {
                        trovato1=true;
                    }
                }
                if(!trovato || !trovato1)
                {
                    WriteLine("Almeno 1 allenatore di quelli inseriti non esiste, riprova");
                    
                    WriteLine("Elenco allenatori:");
                    for (int i = 0; i < count; i++)
                    {
                        WriteLine(arr[i].allenatore);
                    }
                    ScambioAllenatori(count);

                }
                else
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i].allenatore == Allenatore1)
                        {
                            arr[i].allenatore = Allenatore;
                        }
                        else if (arr[i].allenatore == Allenatore)
                        {
                            arr[i].allenatore = Allenatore1;
                        }
                    }
                    WriteLine("Allenatori scambiati con successo");
                }
            }
        }

        static void Stampa(int count)
        {
            string str = "";

            WriteLine($"\nELENCO MOSTRI\n");

            for (int i=0; i<count; i++)
            {
                str += arr[i].Descrizione(i + 1);
            }
            WriteLine(str);
        }

        static void StampaTipo(int count)
        {
            string str = "";
            TipoMostro type;
            do
            {
                Write("Inserissci il tipo per cui filtrare: ");
            } while (!TipoMostro.TryParse(ReadLine(), out type) || (int)type < 0 || (int)type > 4);

            WriteLine($"\nELENCO MOSTRI FILTRO TIPO: {type}\n");

            for (int i = 0; i < count; i++)
            {
                if (arr[i].tipo == type)
                {
                    str += arr[i].Descrizione(i + 1);
                }
            }
            WriteLine(str);
        }

        static void StampaEnergia(int count)
        {
            string str = "";
            LivelloEnergia energy;
            do
            {
                Write("Livello energia: ");
            } while (!LivelloEnergia.TryParse(ReadLine(), out energy) || (int)energy < 0 || (int)energy > 2);
            
            WriteLine($"\nELENCO MOSTRI FILTRO ENERGIA: {energy}\n");

            for (int i = 0; i < count; i++)
            {
                if (arr[i].energia == energy)
                {
                    str += arr[i].Descrizione(i+1);
                }
            }
            WriteLine(str);
        }
    }
}
