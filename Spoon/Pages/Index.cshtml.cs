
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Spoon.Pages;
public class IndexModel : PageModel
{
    public List<Feed> feeds;
    public void OnGet() {
        var rdr = new Reader();
        feeds = rdr.Read();
    }
}