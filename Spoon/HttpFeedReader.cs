namespace Spoon;
   using System.Xml;
public class HttpFeedReader : IFeedReader
{
   public HttpFeedReader(str url) {
      this.url = url;
   }
   str url;

   public Feed read() {
      var client = new HttpClient();
      var xml = client.GetStringAsync(url).Result;
      client.Dispose();
      var doc = new XmlDocument();
      doc.LoadXml(xml);
      var xmlRdr = new XmlFeedReader(doc);
      var feed = xmlRdr.read();
      return feed;
   }
}