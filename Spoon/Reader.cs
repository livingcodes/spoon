namespace Spoon;
class Reader {
   public List<Feed> Read() {
      var ls = new List<Feed>();
      var feed = new Feed {
         title = "Shadetree Developer",
         desc = "Dev",
         link = "https://jeremydmiller.com/feed/"
      };
      var item = new Item {
         title = "Wolverine",
         desc = "Coding",
         link = "https://jeremydmiller.com/feed/"
      };
      feed.items.Add(item);
      ls.Add(feed);
      return ls;
   }
}