// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using static System.Console;
namespace EsDinoStructBM
{
    class Program
    {
        
        public enum TipoDinosauro
        {
            Brontosauro,
            Triceratopo,
            Pterodattilo,
            TRex,
            Stegosauro
        }

        public enum Taglia
        {
            Piccolo,
            Medio,
            Grande
        }

        public struct Dinosauro
        {
            public int codice;
            public TipoDinosauro tipo;
            public Taglia taglia;
            public int età;
            public int forza;
            public string proprietario;

            public Dinosauro(int id, TipoDinosauro type, Taglia size, int age, int power, string prop)
            {
                codice = id;
                tipo = type;
                taglia = size;
                età = age;
                forza = power;
                proprietario = prop;
            }
        }

        public static Dinosauro[]? arr;
        static void Main()
        {
            bool finish = false;
            arr = new Dinosauro[5];
            int count = 0, scelta;
            Dinosauro dino;
            Presenta();

            do { 
                scelta = Input(count);

                switch (scelta)// per verificare tutte le opzioni
                {
                    case 0:
                        finish = true;
                        break;
                    case 1:
                        dino = Aggiungi();
                        arr[count] = dino;
                        count++;
                        break;
                    case 2:
                        Sostituisci();
                        break;
                    case 3:
                        Scambio();
                        break;
                    case 4:
                        Stampa();
                        break;
                    case 5:
                        StampaTipo();
                        break;
                    case 6:
                        StampaTaglia();
                        break;
                }
            } while (!finish);
            

        }

        static void Presenta()
        {
            WriteLine("Benvenuto nel MERCATO DEI DINOSAURI BEDROCK");
            WriteLine("");
            WriteLine("!!!Attenzione!!!");
            WriteLine("In questo mercato accettiamo e teniamo solo alcuni tipi di dinosauro:");
            WriteLine("-Brontosauro--Triceratopo--Pterodattilo--TRex--Stegosauro-");
            WriteLine("Ogni dinosauro può essere di 3 taglie diverse( Grande / Medio / Piccolo )");
            WriteLine("");
        }

        static int Input(int count)
        {
            int n = 1;
            WriteLine("Cosa vuoi svolgere?");
            if (count >= 5)
            {
                WriteLine("2) Sostituire un dinosauro");
                WriteLine("3) Scambio tra 2 clienti");
                WriteLine("4) Visualizza elenco dinosauri nei recinti");
                WriteLine("5) Filtra per tipo");
                WriteLine("6) Filtra per taglia");
                WriteLine("0) Exit");

                do
                {
                    WriteLine("Inserisci il numero dell'azione corrispondente");
                } while ((!int.TryParse(ReadLine(), out n)) || n < 0 || n > 6 || n == 1);
            }
            else // all'inizio devo solo riempire recinti quindi accetto solo opzione 1 o 0
            {
                WriteLine($"1) Riempire un recinto (liberi = {5 - count})");
                do
                {
                    WriteLine("Inserisci il numero dell'azione corrispondente");
                } while (!int.TryParse(ReadLine(), out n) || n < 0 || n > 1);
            }
            return n;
        }

        static Dinosauro Aggiungi()
        {
            int id, power, age;
            TipoDinosauro type;
            Taglia size;
            string prop="";
            do
            {
                Write("Codice univoco: ");
            } while (!int.TryParse(ReadLine(), out id) || id<=0);

            do
            {
                Write("Tipo: ");
            } while (!TipoDinosauro.TryParse(ReadLine(), out type) && (int)type < 0 || (int)type > 4);

            do
            {
                Write("Taglia: ");
            } while (!Taglia.TryParse(ReadLine(), out size) && (int)size<0 || (int)size>2);

            do
            {
                Write("Età: ");
            } while (!int.TryParse(ReadLine(), out age) || age <= 0);

            do
            {
                Write("Forza(1..100): ");
            } while (!int.TryParse(ReadLine(), out power) || power <1 || power>100);

            Write("Nome del proprietario: ");
            prop = ReadLine();

            Dinosauro dino=new Dinosauro(id, type, size, age, power, prop);
            return dino;
        }

        static void Sostituisci()
        {
            WriteLine("Dinosauro da prelevare");
            Elimina();
            WriteLine("Dinosauro da depositare");
            Aggiungi();
        }

        static void Elimina()
        {
            int id;
            do
            {
                Write("codice univoco (da eliminare): ");
            } while (!int.TryParse(ReadLine(), out id) || id <= 0);

            //Cerco l'indice del dinosauro nell'array
            int indexToRemove = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].codice == id)
                {
                    indexToRemove = i;
                    break;
                }
            }

            //Se lo trovo, accorcio l'array
            if (indexToRemove != -1)
            {
                Dinosauro[] nuovoArray = new Dinosauro[arr.Length - 1];

                //Copio i dinosauri prima di quello rimosso
                for (int i = 0; i < indexToRemove; i++)
                    nuovoArray[i] = arr[i];

                //Copio i dinosauri dopo quello rimosso
                for (int i = indexToRemove + 1; i < arr.Length; i++)
                    nuovoArray[i - 1] = arr[i];

                //Sostituisco l'array globale con quello nuovo
                arr = nuovoArray;
                WriteLine("Dinosauro rimosso.");
            }
            else
            {
                WriteLine("ID non trovato.");
                Elimina();
            }
        }

        static void Scambio()
        {
            int id1, id2;
            string nome1="", nome2="";
            Dinosauro dino1, dino2;
            do
            {
                WriteLine("Codice univoco del primo dinosauro: ");
            } while (!int.TryParse(ReadLine(), out id1) && id1 <= 0);

            do
            {
                WriteLine("Codice univoco del secondo dinosauro: ");
            } while (!int.TryParse(ReadLine(), out id2) && id2 <= 0);

            foreach(var dino in arr)
            {
                if(dino.codice == id1)
                {
                    nome1 = dino.proprietario;
                    dino1 = dino;
                }
            }

            foreach(var dino in arr)
            {
                if (dino.codice == id2)
                {
                    nome2 = dino.proprietario;
                    dino2 = dino;
                    break;
                }
            }
            dino2.proprietario = nome1;
            dino1.proprietario=nome2;
        }

        static void Stampa()
        {
            int count = 1;
            foreach (var dino in arr)
            {
                WriteLine("");
                WriteLine($"--- DINOSAURO {count} --- ");
                WriteLine($"Codice univoco: {dino.codice}");
                WriteLine($"Tipo: {dino.tipo}");
                WriteLine($"Taglia: {dino.taglia}");
                WriteLine($"Età: {dino.età}");
                WriteLine($"Forza: {dino.forza}");
                WriteLine($"Proprietario: {dino.proprietario}");
                WriteLine("");
                count++;
            }
        }

        static void StampaTipo()
        {
            int count = 1;
            TipoDinosauro type;
            do
            {
                Write("Filtra in base Tipo: ");
            } while (!TipoDinosauro.TryParse(ReadLine(), out type));

            foreach (Dinosauro dino in arr)
            {
                TipoDinosauro tipo = dino.tipo;
                if (type == tipo)
                {
                    WriteLine("");
                    WriteLine($"--- DINOSAURO {count} --- ");
                    WriteLine($"Codice univoco: {dino.codice}");
                    WriteLine($"Tipo: {dino.tipo}");
                    WriteLine($"Taglia: {dino.taglia}");
                    WriteLine($"Età: {dino.età}");
                    WriteLine($"Forza: {dino.forza}");
                    WriteLine($"Proprietario: {dino.proprietario}");
                    WriteLine("");
                }
                count++;
            }
        }

        static void StampaTaglia()
        {
            int count = 1;
            Taglia size; ;
            do
            {
                Write("Filtra in base Taglia: ");
            } while (!Taglia.TryParse(ReadLine(), out size));

            foreach (Dinosauro dino in arr)
            {
                Taglia taglia = dino.taglia;
                if (size == taglia)
                {
                    WriteLine("");
                    WriteLine($"--- DINOSAURO {count} --- ");
                    WriteLine($"Codice nivoco: {dino.codice}");
                    WriteLine($"Tipo: {dino.tipo}");
                    WriteLine($"Taglia: {dino.taglia}");
                    WriteLine($"Età: {dino.età}");
                    WriteLine($"Forza: {dino.forza}");
                    WriteLine($"Proprietario: {dino.proprietario}");
                    WriteLine("");
                }
                count++;
            }
        }
    }
}
