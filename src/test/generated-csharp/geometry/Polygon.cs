using System.Text;
namespace geometry
{


[System.Serializable]
public class Polygon
{
   public System.Collections.Generic.List<geometry.Vector> points;


   public void set(Polygon other)
   {


      points = new System.Collections.Generic.List<geometry.Vector>(other.points.Count);
      for(int i4 = 0; i4 < other.points.Count; i4++)
      {
      	geometry.Vector newElement = new geometry.VectorPubSubType.Create();
         geometry.VectorPubSubType.Copy(other.points, newElement);
         points.Add(newElement);}   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Polygon {");
      builder.Append("points=");
      builder.Append(this.points);
      builder.Append("}");
      return builder.ToString();
   }
}


}