namespace geometry
{


[System.Serializable]
public class Box
{
   public geometry.Vector center;
   public double w;
   public double l;
   public double h;


   public void set(Box other)
   {
      geometry.VectorPubSubType.staticCopy(other.center, center);
      w = other.w;

      l = other.l;

      h = other.h;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Box {");
      builder.Append("center=");
      builder.Append(this.center_);      Append.append(", ");
      builder.Append("w=");
      builder.Append(this.w_);      Append.append(", ");
      builder.Append("l=");
      builder.Append(this.l_);      Append.append(", ");
      builder.Append("h=");
      builder.Append(this.h_);
      builder.Append("}");
      return builder.ToString();
   }
}


}