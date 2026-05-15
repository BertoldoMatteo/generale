using System.Diagnostics.Tracing;

namespace EsDictionaryMolo
{
    internal class Program
    {
        public Porto porto;
        public Tipo tipo;
        public int n, count;

        public static void Main(string[] args)
        {
            Program p = new Program();
            p.porto = new Porto();
            p.count = 0;
            Console.WriteLine("BENVENUTO NEL MOLO!");
            do
            {
                p.Input();
                Console.WriteLine("Inserisci \' N \' per terminare");
            } while (Console.ReadLine() != "N");
            
        }

        public void Input()
        {
            porto.RegistraBarche();
            Console.WriteLine($"Sono presenti {porto.Barche.Count} barche");
            Console.WriteLine("Inserisci un tipo di carico:\n0 -> cibo\n1 -> auto\n2 -> bevande\n3 -> animali");
            do
            {
                Console.WriteLine("Inserisci da 0 a 3");
            } while (!int.TryParse(Console.ReadLine(), out n) || n<0 || n>3);
            Console.WriteLine(porto.GestisciPartenze((Tipo)n, ref count));
            if (count >= 5) Console.WriteLine("Il porto si sta svuotando rapidamente!\n Più di 5 barche sono partite in un solo turno");
        }
    }
}
