namespace Spoon.Pages;
   using Microsoft.AspNetCore.Mvc.RazorPages;
public class IndexModel : PageModel
{
   public List<Feed> feeds = new();
   public void OnGet() {
      var filePaths = new List<str>();
      var filePath = @"c:\code\spoon\Spoon\jeremydmiller.xml";
      filePaths.Add(filePath);

      foreach (var path in filePaths) {
         IFeedReader rdr = new FileFeedReader(filePath);
         var feed = rdr.Read();
         feeds.Add(feed);
      }
   }
}