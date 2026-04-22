using EsCatch1BM;

string a, b;
double div;
Console.WriteLine("Il programma eseguirà la divisione tra due numeri positivi");
Console.WriteLine("");
Console.WriteLine("Inserisci il primo numero (a)");
a = Console.ReadLine();
Console.WriteLine("Inserisci il secondo numero (b)");
b = Console.ReadLine();
Calcolatrice ris = new Calcolatrice();
div = ris.Divisione(a, b);
switch (div)
{
    case -1:
        Console.WriteLine("Errore: divisione per zero.");
        break;
    case -2:
        Console.WriteLine("Errore: input non numerico");
        break;
    case -3:
        Console.WriteLine("Errore: numero negativo presente");
        break;
    case -4:
        Console.WriteLine("Errore: input non valido");
        break;
    default:
        Console.WriteLine("Divisione eseguita con successo.");
        Console.WriteLine($"{a}/{b} = {div}");
        break;
}
