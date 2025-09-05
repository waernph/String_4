public class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.Write("Skriv in för- och efternamn: ");

        string correctName = Capital.MakeCapital(Console.ReadLine());

        System.Console.WriteLine(correctName);
    }
}