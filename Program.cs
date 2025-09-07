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
            Console.WriteLine(correctNaming);
            Console.ReadKey();
        }
    }
}