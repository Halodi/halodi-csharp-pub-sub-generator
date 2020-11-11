using System.IO;
namespace geometry
{

/**
* 
* Topic data type of the struct "Box" defined in "Vector.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Vector.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Vector.idl instead.
*
*/
public class BoxPubSubType : Halodi.TopicDataType<geometry.Box>
{
   public const string name = "geometry::Box";


   @Override
   public void serialize(geometry.Box data, MemoryStream stream) throws java.io.IOException
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   @Override
   public void deserialize(MemoryStream stream, geometry.Box data) throws java.io.IOException
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(stream);
   	   		read(data, cdr); 
   	   }
   }

   public final static int getCdrSerializedSize(geometry.Box data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(geometry.Box data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += geometry.VectorPubSubType.getCdrSerializedSize(data.getCenter(), current_alignment);

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(geometry.Box data, Halodi.CDR.CDRSerializer cdr)
   {
      geometry.VectorPubSubType.write(data.getCenter(), cdr);
      cdr.write_type_6(data.getW());

      cdr.write_type_6(data.getL());

      cdr.write_type_6(data.getH());

   }

   public static void read(geometry.Box data, Halodi.CDR.CDRDeserializer cdr)
   {
      geometry.VectorPubSubType.read(data.Center, cdr);
      	
      data.W=cdr.read_type_6());
      	
      data.L=cdr.read_type_6());
      	
      data.H=cdr.read_type_6());
      	

   }



   public override string getName()
   {
      return name;
   }
   

}


}