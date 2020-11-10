namespace nested
{


[System.Serializable]
public class NestedElement
{
   public string stringTest;
   public int longTest;


   public void set(NestedElement other)
   {
      stringTest = other.stringTest;

      longTest = other.longTest;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("NestedElement {");
      builder.Append("stringTest=");
      builder.Append(this.stringTest_);      Append.append(", ");
      builder.Append("longTest=");
      builder.Append(this.longTest_);
      builder.Append("}");
      return builder.ToString();
   }
}
