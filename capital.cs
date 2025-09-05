public class Capital
{
    public static string MakeCapital(string input)
    {
        string name = input;
        string nameCapital = name.ToUpper();
        int pos = name.IndexOf(" ");
        string firstName = nameCapital.Substring(0, pos);
        string lastName = nameCapital.Substring(pos + 1);
        char first = firstName[0];
        char last = lastName[0];
        string firstNameSmall = firstName.ToLower();
        string lastNameSmall = lastName.ToLower();
        string capitalizedFirstName = first + firstNameSmall.Substring(1) + " " + last + lastNameSmall.Substring(1);
        string hej;
        return capitalizedFirstName;
        
    }
}