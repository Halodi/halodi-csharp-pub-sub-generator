using System.IO;
namespace geometry
{

/**
* 
* Topic data type of the struct "Polygon" defined in "Vector.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Vector.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Vector.idl instead.
*
*/
public class PolygonPubSubType : Halodi.CDR.TopicDataType<geometry.Polygon>
{
   public override string Name => "geometry::Polygon";


   
   public override void serialize(geometry.Polygon data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, geometry.Polygon data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(geometry.Polygon data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry.Polygon data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.points.Count; ++i0)
      {
          current_alignment += geometry.VectorPubSubType.getCdrSerializedSize(data.points[i0], current_alignment);}

      return current_alignment - initial_alignment;
   }

   public static void write(geometry.Polygon data, Halodi.CDR.CDRSerializer cdr)
   {

      	int points_length = data.points.Count;
            cdr.write_type_2(points_length);
            for (int i0 = 0; i0 < points_length; i0++)
            {
      			geometry.VectorPubSubType.write(data.points[i0], cdr);	      }   }

   public static void read(geometry.Polygon data, Halodi.CDR.CDRDeserializer cdr)
   {

      int points_length = cdr.read_type_2();
      data.points = new System.Collections.Generic.List<geometry.Vector>(points_length);
      for(int i = 0; i < points_length; i++)
      {
      	geometry.Vector new_points = geometry.VectorPubSubType.Create(); 
      	geometry.VectorPubSubType.read(new_points, cdr);
      	data.points.Add(new_points);	
      	
      }

      	

   }


    public static void Copy(geometry.Polygon src, geometry.Polygon target)
    {
        target.Set(src);
    }


}


}