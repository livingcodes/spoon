namespace Spoon;
public static class ObjExt {
   public static bool IsSet(this obj obj) {
      if (obj == null)
         return false;
      var str = obj.ToString();
      if (str == null)
         return false;
      if (str.Trim() == "")
         return false;
      return true;
   }
   public static bool NotSet(this obj obj) =>
      !obj.IsSet();
}