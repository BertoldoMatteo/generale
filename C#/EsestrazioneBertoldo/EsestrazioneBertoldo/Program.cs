// See https://aka.ms/new-console-template for more information
namespace EsEstrazioneBertoldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tent = 3;
            int estr=0;
            int n;
            Random rand;
            Console.WriteLine("Inserisci la difficoltà a cui vuoi giocare:");
            Console.WriteLine("1) Indovina tra 1-5");
            Console.WriteLine("2) Indovina tra 1-10");
            Console.WriteLine("3) Indovina tra 1-20");
            bool x=int.TryParse(Console.ReadLine(), out n);
            if (x && n >= 1 && n <= 3)
            {
                switch (n)
                {
                    case 1:
                        rand = new();
                        estr = rand.Next(1, 6);
                        break;
                    case 2:
                        rand = new();
                        estr = rand.Next(1, 11);
                        break;
                    case 3:
                        rand = new();
                        estr = rand.Next(1, 21);
                        break;
                }
                while (tent > 0)
                {
                    Console.WriteLine($"Hai {tent} tentativi");
                    Console.WriteLine("Prova a indovinare il numero:");
                    Console.WriteLine("(Inserisci un numero positivo)");
                    bool y=int.TryParse(Console.ReadLine(), out n);
                    if(y && n >= 0)
                    {
                        tent--;
                        if (n == estr)
                        {
                            Console.WriteLine($"Hai indovinato! con {3-tent} tentativi");
                            return;
                        }
                        else if(n < estr)
                        {
                            Console.WriteLine($"NUMERO TROPPO ALTO. Hai a disposizione ancora {tent} tentativi");

                        }
                        else
                        {
                            Console.WriteLine($"NUMERO TROPPO BASSO. Hai a disposizione ancora {tent} tentativi");
                        }
                    }
                }
                Console.WriteLine("Hai esautìrito i tentativi");
                return;
            }
            else
            {
                Console.WriteLine("errore nella digitazione");
                return;
            }
        }
    }
}
