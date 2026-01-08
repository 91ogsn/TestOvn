public class Stringmanupilation
{
    //  En klass med olika metoder för strängmanipulering (till exempel bakvändning av sträng, ihopslagning av strängar,
    //  borttagning av mellanslag etc.). Metoder för varje strängmanipulationsfunktion.

    // Vänd en sträng
    public string? ReverseString(string input)
    {
        if (input != null)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        return null;
    }

    // Slå ihop två strängar
    public string? ConcatStrings(string str1, string str2)
    {
        if (str1 != null && str2 != null)
        {
            return str1 + str2;
        }
        return null;
    }

    // Ta bort mellanslag från en sträng
    public string? RemoveSpaces(string input)
    {
        if (input != null)
        {
            return input.Replace(" ", "");
        }
        return null;
    }

}