using System.ComponentModel;

public class Capital
{
    public static string MakeCapital(string input)
    {
        string name = input.ToLower();
        int pos = name.IndexOf(" ");
        string firstName = name.Substring(0, pos);
        string lastName = name.Substring(pos + 1);
        char first = char.ToUpper(firstName[0]);
        char last = char.ToUpper(lastName[0]);
        string capitalizedFirstName =
            first + firstName.Substring(1) + " " + last + lastName.Substring(1);
        return capitalizedFirstName;
    }

    public static string NoSpaces(string input)
    {
        string name = input.ToLower();
        string[] words = name.Split(" ");
        string output = "";
        int length = words.Length;

        for (var i = 0; i < length; i++)
        {
            char first = char.ToUpper(words[i][0]);
            words[i] = words[i].Remove(0, 1);
            output += first + words[i] + " ";
        }
        return output;
    }
}
