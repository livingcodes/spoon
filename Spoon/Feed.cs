namespace Spoon;
public class Feed {
   public str title, desc, link;
   public dte pub;
   public List<Item> items = new();
}
public class Item {
   public str title, desc, link, content;
   public dte pub;
}