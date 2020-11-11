namespace test
{


[System.Serializable]
public class FooAppearanceDefinitionMessage
{
   public double r;
   public double g;
   public double b;
   public double transparency;


   public void set(FooAppearanceDefinitionMessage other)
   {
      r = other.r;

      g = other.g;

      b = other.b;

      transparency = other.transparency;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("FooAppearanceDefinitionMessage {");
      builder.Append("r=");
      builder.Append(this.r_);      Append.append(", ");
      builder.Append("g=");
      builder.Append(this.g_);      Append.append(", ");
      builder.Append("b=");
      builder.Append(this.b_);      Append.append(", ");
      builder.Append("transparency=");
      builder.Append(this.transparency_);
      builder.Append("}");
      return builder.ToString();
   }
}


}