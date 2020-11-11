using System.Text;
namespace test
{


/**
 * This is the header
 * Header line 2
 * This is some dangling comment that will be included in header
 */
[System.Serializable]
public class IDLSubmessage
{
   /**
    * a, b, c
    * 1, 2, 3
    * baby
    * sneaky boi
    */
   public const int Y = 123;
   public const string CATCH_23 = "No doc, watch out!";

   /**
    * this num should have default value 5
    */
   public long num = 5;
   /**
    * I have some doc not relevant to the next
    */
   public long no_default_with_doc;
   public long no_doc_num;
   /**
    * @javadoc I guess javadoc will work okay.
    * hello
    */
   public int hello;


   public void set(IDLSubmessage other)
   {
      num = other.num;

      no_default_with_doc = other.no_default_with_doc;

      no_doc_num = other.no_doc_num;

      hello = other.hello;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("IDLSubmessage {");
      builder.Append("num=");
      builder.Append(this.num);      builder.Append(", ");
      builder.Append("no_default_with_doc=");
      builder.Append(this.no_default_with_doc);      builder.Append(", ");
      builder.Append("no_doc_num=");
      builder.Append(this.no_doc_num);      builder.Append(", ");
      builder.Append("hello=");
      builder.Append(this.hello);
      builder.Append("}");
      return builder.ToString();
   }
}


}