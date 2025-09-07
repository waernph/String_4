using System.ComponentModel;

public class Program
{
    public static void Main()
    {
        bool goOn = true;
        string password = "";
        object register;
        while (goOn)
        {
            Console.Clear();
            Console.Write("Skriv in för- och efternamn: ");
            string correctNaming = Capital.MakeInitialCaseToUpper(Console.ReadLine());
            Console.Write("Skriv in lösenord: ");
            password = Console.ReadLine();
            register = Capital.ToDict(correctNaming, password);
            Console.ReadKey();

        }
    }
}