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
public class TrianglePubSubType : Halodi.TopicDataType<geometry.Triangle>
{
   public const string name = "geometry::Triangle";


   @Override
   public void serialize(geometry.Triangle data, MemoryStream stream) throws java.io.IOException
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   @Override
   public void deserialize(MemoryStream stream, geometry.Triangle data) throws java.io.IOException
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(stream);
   	   		read(data, cdr); 
   	   }
   }

   public final static int getCdrSerializedSize(geometry.Triangle data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(geometry.Triangle data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      for(int i0 = 0; i0 < data.getPoints().length; ++i0)
      {
              current_alignment += geometry.VectorPubSubType.getCdrSerializedSize(data.getPoints()[i0], current_alignment);
      }
      return current_alignment - initial_alignment;
   }

   public static void write(geometry.Triangle data, Halodi.CDR.CDRSerializer cdr)
   {
      for(int i0 = 0; i0 < data.getPoints().length; ++i0)
      {
        	geometry.VectorPubSubType.write(data.getPoints()[i0], cdr);		
      }
   }

   public static void read(geometry.Triangle data, Halodi.CDR.CDRDeserializer cdr)
   {
      for(int i0 = 0; i0 < data.Points.length; ++i0)
      {
        	geometry.VectorPubSubType.read(data.Points[i0], cdr);	
      }
      	

   }



   public override string getName()
   {
      return name;
   }
   

}


}