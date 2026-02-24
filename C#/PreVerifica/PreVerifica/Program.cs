using static System.Console;
namespace esVerifica
{
    public enum TipoAlbero
    {
        Faggio,
        Bertulla,
        Quercia
    }

    public enum TagliaAlbero
    {
        Grande,
        Medio,
        Piccolo
    }

    public enum ColoreAlbero
    {
        Giallo,
        Verde,
        Rosso,
        Arancione
    }

    public struct Alberi
    {
        public TipoAlbero type;
        public TagliaAlbero size;
        public ColoreAlbero color;

        public Alberi(TipoAlbero tipo, TagliaAlbero taglia, ColoreAlbero colore)
        {
            type = tipo;
            size = taglia;
            color = colore;
        }

        public string Stampa(int count)
        {
            return $"Albero numero {count}\nTipo: {type}\nTaglia: {size}\n Colore: {color}";
        }
    }

    internal class Program
    {
        static bool Valid;
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int n = (int)TipoAlbero.Faggio;
            WriteLine(n);
            TipoAlbero tipo = (TipoAlbero)2;
            WriteLine(tipo);
            Alberi albero = new Alberi();
            
            string str;
            int count = 0;
            WriteLine("Inserisci caratteristiche albero");
            do
            {
                Write("Tipo: ");
                Valid = TipoAlbero.TryParse(ReadLine(), out albero.type);
            } while (!Valid);

            do
            {
                Write("Taglia: ");
                Valid = TagliaAlbero.TryParse(ReadLine(), out albero.size);
            } while (!Valid);

            do
            {
                Write("Colore: ");
                Valid = ColoreAlbero.TryParse(ReadLine(), out albero.color);
            } while (!Valid);
            count++;

            str = albero.Stampa(count);
            WriteLine(str);
        }
    }
}
