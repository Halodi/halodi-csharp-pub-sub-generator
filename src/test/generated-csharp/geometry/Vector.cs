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


   public void set(Vector other)
   {
      frame = other.frame;

      x = other.x;

      y = other.y;

      z = other.z;

      bla.set(other.bla);
      for(int i1 = 0; i1 < waa.length; ++i1)
      {
            waa[i1] = other.waa[i1];

      }

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Vector {");
      builder.Append("frame=");
      builder.Append(this.frame_);      Append.append(", ");
      builder.Append("x=");
      builder.Append(this.x_);      Append.append(", ");
      builder.Append("y=");
      builder.Append(this.y_);      Append.append(", ");
      builder.Append("z=");
      builder.Append(this.z_);      Append.append(", ");
      builder.Append("bla=");
      builder.Append(this.bla_);      Append.append(", ");
      builder.Append("waa=");
      builder.Append(java.util.Arrays.toString(this.waa_));
      builder.Append("}");
      return builder.ToString();
   }
}


}