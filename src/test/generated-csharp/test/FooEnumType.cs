using System.Text;
namespace test
{


[System.Serializable]
public class FooEnumType
{
   public string name;
   public System.Collections.Generic.List<string> enumValues;


   public void set(FooEnumType other)
   {
      name = other.name;

      enumValues.set(other.enumValues);
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("FooEnumType {");
      builder.Append("name=");
      builder.Append(this.name_);      Append.append(", ");
      builder.Append("enumValues=");
      builder.Append(this.enumValues_);
      builder.Append("}");
      return builder.ToString();
   }
}


}