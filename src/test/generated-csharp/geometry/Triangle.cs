using System.Text;
namespace geometry
{


[System.Serializable]
public class Triangle
{
   public geometry.Vector[] points;


   public void set(Triangle other)
   {
      for(int i5 = 0; i5 < points.Length; ++i5)
      {
            geometry.VectorPubSubType.Copy(other.points[i5], points[i5]);}
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Triangle {");
      builder.Append("points=");
	  builder.Append("[");
      builder.Append(System.String.Join(",", this.points));
      builder.Append("]");
      builder.Append("}");
      return builder.ToString();
   }
}


}