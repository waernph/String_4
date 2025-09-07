using System.ComponentModel;

public class Program
{
    public static void Main()
    {
        bool goOn = true;
        while (goOn)
        {
            Console.Clear();
            Console.Write("Skriv in för- och efternamn: ");
            string correctNaming = Capital.MakeInitialCaseToUpper(Console.ReadLine());
            Console.WriteLine($"Jag har fixat ditt namn: {correctNaming}");
            Console.WriteLine("Tryck esc för att avsluta");
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                goOn = false;
            }

        }
    }
}