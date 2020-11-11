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
public class FooYoRegistryDefinitionPubSubType : Halodi.CDR.TopicDataType<test.FooYoRegistryDefinition>
{
   public const string name = "test::FooYoRegistryDefinition";


   
   public override void serialize(test.FooYoRegistryDefinition data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, test.FooYoRegistryDefinition data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(stream);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(test.FooYoRegistryDefinition data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(test.FooYoRegistryDefinition data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 2 + Halodi.CDR.CDRCommon.alignment(current_alignment, 2);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.getName().length() + 1;


      return current_alignment - initial_alignment;
   }

   public static void write(test.FooYoRegistryDefinition data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_3(data.parent);

      cdr.write_type_d(data.name);

   }

   public static void read(test.FooYoRegistryDefinition data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.parent=cdr.read_type_3();
      	
      data.name = cdr.read_type_d();	

   }



   public override string getName()
   {
      return name;
   }
   

}


}