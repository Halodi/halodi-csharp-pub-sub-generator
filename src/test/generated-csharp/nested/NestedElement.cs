using System.Text;
namespace nested
{


[System.Serializable]
public class NestedElement
{
   public string stringTest;
   public int longTest;


   public void Set(NestedElement other)
   {
      stringTest = other.stringTest;

      longTest = other.longTest;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("NestedElement {");
      builder.Append("stringTest=");
      builder.Append(this.stringTest);      builder.Append(", ");
      builder.Append("longTest=");
      builder.Append(this.longTest);
      builder.Append("}");
      return builder.ToString();
   }
}


}