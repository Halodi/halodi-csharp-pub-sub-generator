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
public class PolygonPubSubType : Halodi.TopicDataType<geometry.Polygon>
{
   public const string name = "geometry::Polygon";


   @Override
   public void serialize(geometry.Polygon data, MemoryStream stream) throws java.io.IOException
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   @Override
   public void deserialize(MemoryStream stream, geometry.Polygon data) throws java.io.IOException
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(stream);
   	   		read(data, cdr); 
   	   }
   }

   public final static int getCdrSerializedSize(geometry.Polygon data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(geometry.Polygon data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getPoints().size(); ++i0)
      {
          current_alignment += geometry.VectorPubSubType.getCdrSerializedSize(data.getPoints().get(i0), current_alignment);}

      return current_alignment - initial_alignment;
   }

   public static void write(geometry.Polygon data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_e(data.getPoints());

   }

   public static void read(geometry.Polygon data, Halodi.CDR.CDRDeserializer cdr)
   {

      int Points_length = cdr.read_type_2();
      data.Points = new System.Collections.Generic.List<geometry.Vector>(Points_length);
      for(int i = 0; i < Points_length; i++)
      {
      	geometry.VectorPubSubType.read(data.Points, cdr);	
      	
      }
      	

   }



   public override string getName()
   {
      return name;
   }
   

}


}