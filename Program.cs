using JournalLabels;

Console.WriteLine("Iniciando gerador de labels para o Journal");
Console.WriteLine("Informe o ano desejado");
var inputYear = Console.ReadLine();
int year;

if (!int.TryParse(inputYear, out year))
{
    Console.WriteLine("Valor inválido");
    throw new Exception();
}

Console.WriteLine($"Gerando labels para o ano {year}");
var filePath = $"C:\\Temp\\journal_labels_{year}.txt";
if (File.Exists(filePath)) File.Delete(filePath);
var sw = new StreamWriter(filePath);

var currentMonth = 0;
var date = new DateTime(year, 1, 1);
while (date.Year == year)
{
    if (date.Month != currentMonth)
    {
        var month = $"{date.ToString("MMMM").ToTitleCase()}";
        Console.WriteLine(month);
        sw.WriteLine(month);
        currentMonth++;
    }

    var dateTimePart = date.ToString("dd/MM/yyyy");
    var weekdayPart = date.ToString("ddd");
    var journalLabel = $"{dateTimePart} {weekdayPart[..^1].ToTitleCase()}";
    Console.WriteLine(journalLabel);
    sw.WriteLine(journalLabel);
    date = date.AddDays(1);
}

sw.Close();
Console.WriteLine("Labels gerados");
Console.WriteLine(filePath);