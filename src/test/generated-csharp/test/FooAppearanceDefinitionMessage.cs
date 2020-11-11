using System.Text;
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
      builder.Append(this.r);      builder.Append(", ");
      builder.Append("g=");
      builder.Append(this.g);      builder.Append(", ");
      builder.Append("b=");
      builder.Append(this.b);      builder.Append(", ");
      builder.Append("transparency=");
      builder.Append(this.transparency);
      builder.Append("}");
      return builder.ToString();
   }
}


}