namespace Spoon.Pages;
   using Microsoft.AspNetCore.Mvc.RazorPages;
public class FeedModel : PageModel
{
   public Feed feed;
   public void OnGet() {
      var url = "https://jeremydmiller.com/feed/";
      var rdr = new HttpFeedReader(url);
      feed = rdr.read();
   }
}