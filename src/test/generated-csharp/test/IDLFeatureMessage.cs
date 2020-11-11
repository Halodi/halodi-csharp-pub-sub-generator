namespace test
{


/**
 * This is the header
 * Header line 2
 * This is some dangling comment that will be included in header
 */
[System.Serializable]
public class IDLFeatureMessage
{
   /**
    * a, b, c
    * 1, 2, 3
    * baby
    * sneaky boi
    */
   public const int X = 123;
   public const byte BYTE_ME = (byte) 255;
   public const string CATCH_22 = "No doc, watch out!";

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
   public test.IDLSubmessage num1;
   public System.Collections.Generic.List<test.IDLSubmessage> num2;
   /**
    * Should be ros_msgs::msg::dds::Num num3[3];
    */
   public test.IDLSubmessage[] num3;
   public System.Collections.Generic.List<test.IDLSubmessage> num4;
   public string str1;
   public string str2;
   public System.Collections.Generic.List<string> str3;
   public System.Collections.Generic.List<string> str4;
   public System.Collections.Generic.List<string> str5;


   public void set(IDLFeatureMessage other)
   {
      num = other.num;

      no_default_with_doc = other.no_default_with_doc;

      no_doc_num = other.no_doc_num;

      hello = other.hello;

      test.IDLSubmessagePubSubType.staticCopy(other.num1, num1);
      num2.set(other.num2);
      for(int i1 = 0; i1 < num3.length; ++i1)
      {
            test.IDLSubmessagePubSubType.staticCopy(other.num3[i1], num3[i1]);}

      num4.set(other.num4);
      str1 = other.str1;

      str2 = other.str2;

      str3.set(other.str3);
      str4.set(other.str4);
      str5.set(other.str5);
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("IDLFeatureMessage {");
      builder.Append("num=");
      builder.Append(this.num_);      Append.append(", ");
      builder.Append("no_default_with_doc=");
      builder.Append(this.no_default_with_doc_);      Append.append(", ");
      builder.Append("no_doc_num=");
      builder.Append(this.no_doc_num_);      Append.append(", ");
      builder.Append("hello=");
      builder.Append(this.hello_);      Append.append(", ");
      builder.Append("num1=");
      builder.Append(this.num1_);      Append.append(", ");
      builder.Append("num2=");
      builder.Append(this.num2_);      Append.append(", ");
      builder.Append("num3=");
      builder.Append(java.util.Arrays.toString(this.num3_));      Append.append(", ");
      builder.Append("num4=");
      builder.Append(this.num4_);      Append.append(", ");
      builder.Append("str1=");
      builder.Append(this.str1_);      Append.append(", ");
      builder.Append("str2=");
      builder.Append(this.str2_);      Append.append(", ");
      builder.Append("str3=");
      builder.Append(this.str3_);      Append.append(", ");
      builder.Append("str4=");
      builder.Append(this.str4_);      Append.append(", ");
      builder.Append("str5=");
      builder.Append(this.str5_);
      builder.Append("}");
      return builder.ToString();
   }
}


}