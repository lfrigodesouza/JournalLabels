namespace JournalLabels;

public static class StringEx
{
    public static string ToTitleCase(this string str)
    {
        if (str is null || str.Length < 2) throw new ArgumentException("String inválida");

        var firstLetter = str[0].ToString().ToUpper();
        return $"{firstLetter}{str[1..].ToLower()}";
    }
}