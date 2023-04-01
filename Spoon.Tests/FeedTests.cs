namespace Spoon.Tests;
   using Spoon;
[TestClass]
public class FeedReaderTests
{
   [TestMethod]
   public void TestName() {
      var filePath = @"c:\code\spoon\Spoon\jeremydmiller.xml";
      IFeedReader fr = new FileFeedReader(filePath);
      var feed = fr.read();
      Assert.IsTrue(feed.title == "The Shade Tree Developer");
      Assert.IsTrue(feed.desc.IsSet());
      Assert.IsTrue(feed.link.IsSet());
      Assert.IsTrue(feed.items.Count > 0);
   }
}