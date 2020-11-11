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
public class BoxPubSubType : Halodi.CDR.TopicDataType<geometry.Box>
{
   public const string name = "geometry::Box";


   
   public override void serialize(geometry.Box data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, geometry.Box data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(geometry.Box data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry.Box data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += geometry.VectorPubSubType.getCdrSerializedSize(data.center, current_alignment);

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(geometry.Box data, Halodi.CDR.CDRSerializer cdr)
   {
      geometry.VectorPubSubType.write(data.center, cdr);

      cdr.write_type_6(data.w);

      cdr.write_type_6(data.l);

      cdr.write_type_6(data.h);

   }

   public static void read(geometry.Box data, Halodi.CDR.CDRDeserializer cdr)
   {
      geometry.VectorPubSubType.read(data.center, cdr);
      	
      data.w=cdr.read_type_6();
      	
      data.l=cdr.read_type_6();
      	
      data.h=cdr.read_type_6();
      	

   }



   public override string getName()
   {
      return name;
   }
   

}


}