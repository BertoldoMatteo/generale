namespace DivisionePerZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* VERSIONE 1 */
//              Console.WriteLine(new CCalcolatrice().Dividi1(18,0));

            /* VERSIONE 2 */

            try
            {
                Console.WriteLine(new CCalcolatrice().Dividi2(18, 0));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { Console.WriteLine("Operazione terminata"); }
        }
    }
}










