using System.IO;
namespace geometry
{

/**
* 
* Topic data type of the struct "Triangle" defined in "Vector.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Vector.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Vector.idl instead.
*
*/
public class TrianglePubSubType : Halodi.CDR.TopicDataType<geometry.Triangle>
{
   public const string name = "geometry::Triangle";


   
   public override void serialize(geometry.Triangle data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, geometry.Triangle data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(stream);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(geometry.Triangle data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry.Triangle data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      for(int i0 = 0; i0 < data.getPoints().Length; ++i0)
      {
              current_alignment += geometry.VectorPubSubType.getCdrSerializedSize(data.getPoints()[i0], current_alignment);
      }
      return current_alignment - initial_alignment;
   }

   public static void write(geometry.Triangle data, Halodi.CDR.CDRSerializer cdr)
   {
      for(int i0 = 0; i0 < data.points.length; ++i0)
      {
        	geometry.VectorPubSubType.write(data.points[i0], cdr);		
      }
   }

   public static void read(geometry.Triangle data, Halodi.CDR.CDRDeserializer cdr)
   {
      for(int i0 = 0; i0 < data.points.length; ++i0)
      {
        	geometry.VectorPubSubType.read(data.points[i0], cdr);	
      }
      	

   }



   public override string getName()
   {
      return name;
   }
   

}


}