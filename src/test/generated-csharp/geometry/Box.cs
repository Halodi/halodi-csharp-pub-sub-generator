using System.Text;
namespace geometry
{


[System.Serializable]
public class Box
{
   public geometry.Vector center;
   public double w;
   public double l;
   public double h;


   public void Set(Box other)
   {
      geometry.VectorPubSubType.Copy(other.center, center);

      w = other.w;

      l = other.l;

      h = other.h;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Box {");
      builder.Append("center=");
      builder.Append(this.center);      builder.Append(", ");
      builder.Append("w=");
      builder.Append(this.w);      builder.Append(", ");
      builder.Append("l=");
      builder.Append(this.l);      builder.Append(", ");
      builder.Append("h=");
      builder.Append(this.h);
      builder.Append("}");
      return builder.ToString();
   }
}


}