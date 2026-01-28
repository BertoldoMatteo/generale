// See https://aka.ms/new-console-template for more information
namespace EsEquazioneBertoldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x, x1, x2;
            Console.WriteLine("Ciao! Questo programma risolve equazioni di secondo grado della forma ax^2 + bx + c = 0");
            Console.Write("Inserisci il coefficiente a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Inserisci il coefficiente b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Inserisci il coefficiente c: ");
            c = Convert.ToDouble(Console.ReadLine());
            delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Le soluzioni sono reali e distinte: x1 = {x1}, x2 = {x2}");
            }
            else if (delta == 0)
            {
                x = -b / (2 * a);
                Console.WriteLine($"Le soluzioni sono reali e coincidenti: x = {x}");
            }
            else
            {
                Console.WriteLine("Le soluzioni non appartengono all'insieme dei numeri reali");
            }
        }
    }
}
