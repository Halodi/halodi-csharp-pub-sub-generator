using System.Text;
namespace geometry
{


[System.Serializable]
public class Polygon
{
   public System.Collections.Generic.List<geometry.Vector> points;


   public void Set(Polygon other)
   {

      if(other.points == null)
      {
      	points = null;
      }
      else
      {
      	points = new System.Collections.Generic.List<geometry.Vector>(other.points.Count);
      	for(int i4 = 0; i4 < other.points.Count; i4++)
      	{
      		if(other.points[i4] == null)
      		{
      			points.Add(null);
      		}
      		else
      		{
      			geometry.Vector newElement = geometry.VectorPubSubType.Create();
      	   		geometry.VectorPubSubType.Copy(other.points[i4], newElement);
      	   		points.Add(newElement);
      		}	}
      }   }


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