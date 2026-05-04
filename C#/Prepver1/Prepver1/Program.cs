namespace Prepver1
{
    internal class Program
    {
        public List<Esempio> list;
        public Esempio es;
        public bool Valid;
        public string str;
        public int n;
        public DateTime data;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.list = new List<Esempio>();
            do
            {
                
                p.Aggiungi();
            } while (p.list.Count < 2);
            foreach(Esempio i in p.list)
            {
                Console.WriteLine(i.Print());
            }
        }

        public void Aggiungi()
        {

            es = new Esempio();
            try
            {
                es.Id = list.Count;
                Console.WriteLine("Inserisci il nome");
                es.Name = Console.ReadLine();
                do
                {
                    Console.WriteLine("Inserisci l'età");
                } while (!int.TryParse(Console.ReadLine(), out n));
                es.Age = n;

                do
                {
                    Console.WriteLine("Inserisci il sesso (M/F)");
                    str = Console.ReadLine();
                } while (str == "");

                es.Sesso = str == "M" ? true : false;

                do
                {
                    Console.WriteLine("Inserisci anno di nascita");
                    Valid = DateTime.TryParse(Console.ReadLine(), out data);
                } while (!Valid);

                es.Birthday = data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            list.Add(es);
            Console.WriteLine("Aggiunto Correttamente");
        }
    }
}
