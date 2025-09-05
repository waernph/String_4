public class Program
{
    public static void Main()
    {
        Console.WriteLine("Skriv in för och efternamn");

        string correctName = Capital.MakeCapital(Console.ReadLine());

        System.Console.WriteLine(correctName);
        
    }
}