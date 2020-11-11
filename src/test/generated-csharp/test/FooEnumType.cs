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



      enumValues = new System.Collections.Generic.List<string>(other.enumValues.Count);
      for(int i3 = 0; i3 < other.enumValues.Count; i3++)
      {
         enumValues.Add(other.enumValues[i3]);
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("FooEnumType {");
      builder.Append("name=");
      builder.Append(this.name);      builder.Append(", ");
      builder.Append("enumValues=");
      builder.Append(this.enumValues);
      builder.Append("}");
      return builder.ToString();
   }
}


}