using System.Text;
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
   public readonly test.IDLSubmessage[] num3 = new test.IDLSubmessage[3];
   public System.Collections.Generic.List<test.IDLSubmessage> num4;
   public string str1;
   public string str2;
   public System.Collections.Generic.List<string> str3;
   public System.Collections.Generic.List<string> str4;
   public System.Collections.Generic.List<string> str5;


   public void Set(IDLFeatureMessage other)
   {
      num = other.num;

      no_default_with_doc = other.no_default_with_doc;

      no_doc_num = other.no_doc_num;

      hello = other.hello;

      test.IDLSubmessagePubSubType.Copy(other.num1, num1);


      if(other.num2 == null)
      {
      	num2 = null;
      }
      else
      {
      	num2 = new System.Collections.Generic.List<test.IDLSubmessage>(other.num2.Count);
      	for(int i1 = 0; i1 < other.num2.Count; i1++)
      	{
      		if(other.num2[i1] == null)
      		{
      			num2.Add(null);
      		}
      		else
      		{
      			test.IDLSubmessage newElement = test.IDLSubmessagePubSubType.Create();
      	   		test.IDLSubmessagePubSubType.Copy(other.num2[i1], newElement);
      	   		num2.Add(newElement);
      		}	}
      }
      for(int i2 = 0; i2 < 3; ++i2)
      {
            test.IDLSubmessagePubSubType.Copy(other.num3[i2], num3[i2]);}


      if(other.num4 == null)
      {
      	num4 = null;
      }
      else
      {
      	num4 = new System.Collections.Generic.List<test.IDLSubmessage>(other.num4.Count);
      	for(int i4 = 0; i4 < other.num4.Count; i4++)
      	{
      		if(other.num4[i4] == null)
      		{
      			num4.Add(null);
      		}
      		else
      		{
      			test.IDLSubmessage newElement = test.IDLSubmessagePubSubType.Create();
      	   		test.IDLSubmessagePubSubType.Copy(other.num4[i4], newElement);
      	   		num4.Add(newElement);
      		}	}
      }
      str1 = other.str1;

      str2 = other.str2;


      if(other.str3 == null)
      {
      	str3 = null;
      }
      else
      {
      	str3 = new System.Collections.Generic.List<string>(other.str3.Count);
      	for(int i5 = 0; i5 < other.str3.Count; i5++)
      	{
         		str3.Add(other.str3[i5]);
      	}
      }

      if(other.str4 == null)
      {
      	str4 = null;
      }
      else
      {
      	str4 = new System.Collections.Generic.List<string>(other.str4.Count);
      	for(int i6 = 0; i6 < other.str4.Count; i6++)
      	{
         		str4.Add(other.str4[i6]);
      	}
      }

      if(other.str5 == null)
      {
      	str5 = null;
      }
      else
      {
      	str5 = new System.Collections.Generic.List<string>(other.str5.Count);
      	for(int i7 = 0; i7 < other.str5.Count; i7++)
      	{
         		str5.Add(other.str5[i7]);
      	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("IDLFeatureMessage {");
      builder.Append("num=");
      builder.Append(this.num);      builder.Append(", ");
      builder.Append("no_default_with_doc=");
      builder.Append(this.no_default_with_doc);      builder.Append(", ");
      builder.Append("no_doc_num=");
      builder.Append(this.no_doc_num);      builder.Append(", ");
      builder.Append("hello=");
      builder.Append(this.hello);      builder.Append(", ");
      builder.Append("num1=");
      builder.Append(this.num1);      builder.Append(", ");
      builder.Append("num2=");
      builder.Append(this.num2);      builder.Append(", ");
      builder.Append("num3=");
      builder.Append(Halodi.CDR.CDRCommon.ArrayToString(",", this.num3));      builder.Append(", ");
      builder.Append("num4=");
      builder.Append(this.num4);      builder.Append(", ");
      builder.Append("str1=");
      builder.Append(this.str1);      builder.Append(", ");
      builder.Append("str2=");
      builder.Append(this.str2);      builder.Append(", ");
      builder.Append("str3=");
      builder.Append(this.str3);      builder.Append(", ");
      builder.Append("str4=");
      builder.Append(this.str4);      builder.Append(", ");
      builder.Append("str5=");
      builder.Append(this.str5);
      builder.Append("}");
      return builder.ToString();
   }
}


}