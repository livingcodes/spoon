namespace Spoon;
   using System.Xml;
public class FileFeedReader : IFeedReader
{
   public FileFeedReader(string filePath) {
      this.filePath = filePath;
   }
   string filePath;

   public Feed read() {
      XmlDocument doc = new();
      doc.Load(filePath);
      var feed = new XmlFeedReader(doc).read();
      return feed;
   }
}