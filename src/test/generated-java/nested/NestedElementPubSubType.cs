using System.IO;
namespace nested
{

/**
* 
* Topic data type of the struct "NestedElement" defined in "NestedElement.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from NestedElement.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit NestedElement.idl instead.
*
*/
public class NestedElementPubSubType : Halodi.TopicDataType<nested.NestedElement>
{
   public const string name = "nested::NestedElement";


   @Override
   public void serialize(nested.NestedElement data, MemoryStream stream) throws java.io.IOException
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   @Override
   public void deserialize(MemoryStream stream, nested.NestedElement data) throws java.io.IOException
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(stream);
   	   		read(data, cdr); 
   	   }
   }

   public final static int getCdrSerializedSize(nested.NestedElement data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(nested.NestedElement data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.getStringTest().length() + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(nested.NestedElement data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_d(data.getStringTest());

      cdr.write_type_2(data.getLongTest());

   }

   public static void read(nested.NestedElement data, Halodi.CDR.CDRDeserializer cdr)
   {
      cdr.read_type_d(data.getStringTest());	
      data.LongTest=cdr.read_type_2());
      	

   }



   public override string getName()
   {
      return name;
   }
   

}


}