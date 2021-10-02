namespace JournalLabels;

public static class StringEx
{
    public static string ToTitleCase(this string str)
    {
        if (str is null || str.Length < 2)
            throw new ArgumentException("String should not be null nor have a length lower than 2 characters");

        var firstLetter = str[0].ToString().ToUpper();
        return $"{firstLetter}{str[1..].ToLower()}";
    }
}