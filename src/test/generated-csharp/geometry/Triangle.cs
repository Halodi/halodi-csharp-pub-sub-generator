using System.Text;
namespace geometry
{


[System.Serializable]
public class Triangle
{
   public readonly geometry.Vector[] points = new geometry.Vector[3];

   public void Set(Triangle other)
   {
      for(int i5 = 0; i5 < 3; ++i5)
      {
            geometry.VectorPubSubType.Copy(other.points[i5], points[i5]);}
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Triangle {");
      builder.Append("points=");
      builder.Append(Halodi.CDR.CDRCommon.ArrayToString(",", this.points));
      builder.Append("}");
      return builder.ToString();
   }
}


}