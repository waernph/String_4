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
        string capitalizedFirstName = first + firstName.Substring(1) + " " + last + lastName.Substring(1);
        return capitalizedFirstName;
    }
}