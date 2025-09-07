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
            Console.WriteLine(words[i]);
            //words[i] = words[i].Replace(words[i][0], first);
            //words[i] = words[i].Replace(words[i][0], first);
            words[i] = words[i].Remove(0, 1);
            output += first + words[i] + " ";
        }
        return output;
    }

    public static object ToDict(string key, string value)
    {
        Dictionary<string, string> nameReigster = new()
        {
            { key, value }
        };
        return nameReigster;
    }
}
