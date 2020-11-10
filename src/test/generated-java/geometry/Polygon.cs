namespace geometry
{


[System.Serializable]
public class Polygon
{
   public System.Collections.Generic.List<geometry.Vector> points;


   public void set(Polygon other)
   {
      points.set(other.points);
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Polygon {");
      builder.Append("points=");
      builder.Append(this.points_);
      builder.Append("}");
      return builder.ToString();
   }
}


}