public class Program
{
    public static void Main()
    {
        bool goOn = true;
        while (goOn)
        {
            Console.Clear();
            Console.Write("Skriv in för- och efternamn: ");

            string correctName = Capital.MakeCapital(Console.ReadLine());

            System.Console.WriteLine(correctName);
        }
    }
}