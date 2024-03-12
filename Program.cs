using web_scraping_Services;

string url = "https://dotnet.microsoft.com/pt-br/languages/csharp";
WebScraperService scraper = new();

var title = scraper.GetPageTitle(url);
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Título da página");
Console.WriteLine("----------------");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(title);

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Links na página");
Console.WriteLine("---------------");
Console.ForegroundColor = ConsoleColor.Blue;
var links = scraper.GetAllLinks(url);
foreach (var link in links)
    Console.WriteLine(link);
