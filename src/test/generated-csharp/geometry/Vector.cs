using System.Text;
namespace geometry
{


//@Abstract(type="java.lang.Object", impl="null")
[System.Serializable]
public class Vector
{
   public string frame;
   public double x;
   public double y;
   public double z;
   public System.Collections.Generic.List<double> bla;
   public double[] waa;


   public void Set(Vector other)
   {
      frame = other.frame;

      x = other.x;

      y = other.y;

      z = other.z;


      if(other.bla == null)
      {
      	bla = null;
      }
      else
      {
      	bla = new System.Collections.Generic.List<double>(other.bla.Count);
      	for(int i1 = 0; i1 < other.bla.Count; i1++)
      	{
         		bla.Add(other.bla[i1]);
      	}
      }
      for(int i2 = 0; i2 < waa.Length; ++i2)
      {
            waa[i2] = other.waa[i2];

      }

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Vector {");
      builder.Append("frame=");
      builder.Append(this.frame);      builder.Append(", ");
      builder.Append("x=");
      builder.Append(this.x);      builder.Append(", ");
      builder.Append("y=");
      builder.Append(this.y);      builder.Append(", ");
      builder.Append("z=");
      builder.Append(this.z);      builder.Append(", ");
      builder.Append("bla=");
      builder.Append(this.bla);      builder.Append(", ");
      builder.Append("waa=");
      builder.Append(Halodi.CDR.CDRCommon.ArrayToString(",", this.waa));
      builder.Append("}");
      return builder.ToString();
   }
}


}