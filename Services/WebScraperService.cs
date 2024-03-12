using HtmlAgilityPack;

namespace web_scraping_Services;

public class WebScraperService
{
    private readonly HtmlWeb _webClient;

    public WebScraperService() => _webClient = new HtmlWeb();

    public string GetPageTitle(string url)
    {
        HtmlDocument doc = _webClient.Load(url);
        
        return doc.DocumentNode.SelectSingleNode("//title").InnerText.Trim();
    }

    public List<string> GetAllLinks(string url)
    {
        List<string> links = [];
        HtmlDocument doc = _webClient.Load(url);
        
        var linkNodes = doc.DocumentNode.SelectNodes("//a[@href]");
        if (linkNodes != null)
        {
            foreach (var linkNode in linkNodes)
            {
                var href = linkNode.Attributes["href"].Value;
                if (href.StartsWith("http://") || href.StartsWith("https://")) links.Add(href);
            }
        }

        return links;
    }
}