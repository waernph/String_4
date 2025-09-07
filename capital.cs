using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class Capital
{
    public static string MakeInitialCaseToUpper(string input)
    {
        string name = input.ToLower();
        string[] words = name.Split(" ");
        int length = words.Length;
        string output = "";

        for (var i = 0; i < length; i++)
        {
            char first = char.ToUpper(words[i][0]);
            words[i] = words[i].Remove(0, 1);
            output += first + words[i] + " ";
        }
        return output;
    }

    public static object ToDict(string key, string value)
    {
        Dictionary<string, string> nameReigster = new Dictionary<string, string>();
        nameReigster.Add("key", "value");
        return nameReigster;
    }
}
