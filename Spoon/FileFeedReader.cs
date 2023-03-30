namespace Spoon;
   using System.Xml;
public class FileFeedReader : IFeedReader {
   public FileFeedReader(string filePath) {
      this.filePath = filePath;
   }
   string filePath;

   public Feed Read() {
      XmlDocument doc = new();
      doc.Load(filePath);
      var feed = new Feed();
      Func<str, str> nodeTxt = (str path) =>
         doc.DocumentElement.SelectSingleNode(path).InnerText;
      feed.title = nodeTxt("/rss/channel/title");
      feed.desc = nodeTxt("/rss/channel/description");
      feed.link = nodeTxt("/rss/channel/link");
      var nodes = doc.DocumentElement.SelectNodes("/rss/channel/item");
      foreach (XmlNode node in nodes) {
         var item = new Item {
            title = node.SelectSingleNode("title")?.InnerText,
            desc = node.SelectSingleNode("description")?.InnerText,
            link = node.SelectSingleNode("link")?.InnerText,
            pub = dte.Parse(node.SelectSingleNode("pubDate")?.InnerText)
         };
         foreach (XmlNode child in node.ChildNodes)
            if (child.Name == "content:encoded") {
               item.content = child.InnerText;
               break;
            }
         feed.items.Add(item);
      }
      return feed;
   }
}