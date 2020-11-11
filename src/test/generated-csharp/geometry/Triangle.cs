using System.Text;
namespace geometry
{


[System.Serializable]
public class Triangle
{
   public geometry.Vector[] points;


   public void set(Triangle other)
   {
      for(int i3 = 0; i3 < points.length; ++i3)
      {
            geometry.VectorPubSubType.staticCopy(other.points[i3], points[i3]);}
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Triangle {");
      builder.Append("points=");
      builder.Append(java.util.Arrays.toString(this.points_));
      builder.Append("}");
      return builder.ToString();
   }
}


}