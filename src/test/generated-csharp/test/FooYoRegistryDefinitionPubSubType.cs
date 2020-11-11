using System.IO;
namespace test
{

/**
* 
* Topic data type of the struct "FooYoRegistryDefinition" defined in "FooHandshake.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from FooHandshake.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit FooHandshake.idl instead.
*
*/
public class FooYoRegistryDefinitionPubSubType : Halodi.TopicDataType<test.FooYoRegistryDefinition>
{
   public const string name = "test::FooYoRegistryDefinition";


   @Override
   public void serialize(test.FooYoRegistryDefinition data, MemoryStream stream) throws java.io.IOException
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   @Override
   public void deserialize(MemoryStream stream, test.FooYoRegistryDefinition data) throws java.io.IOException
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(stream);
   	   		read(data, cdr); 
   	   }
   }

   public final static int getCdrSerializedSize(test.FooYoRegistryDefinition data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.FooYoRegistryDefinition data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 2 + Halodi.CDR.CDRCommon.alignment(current_alignment, 2);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.getName().length() + 1;


      return current_alignment - initial_alignment;
   }

   public static void write(test.FooYoRegistryDefinition data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_3(data.getParent());

      cdr.write_type_d(data.getName());

   }

   public static void read(test.FooYoRegistryDefinition data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.Parent=cdr.read_type_3());
      	
      cdr.read_type_d(data.getName());	

   }



   public override string getName()
   {
      return name;
   }
   

}


}