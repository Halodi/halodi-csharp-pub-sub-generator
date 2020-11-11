using System.IO;
namespace test
{

/**
* 
* Topic data type of the struct "FooAppearanceDefinitionMessage" defined in "FooHandshake.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from FooHandshake.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit FooHandshake.idl instead.
*
*/
public class FooAppearanceDefinitionMessagePubSubType : Halodi.CDR.TopicDataType<test.FooAppearanceDefinitionMessage>
{
   public const string name = "test::FooAppearanceDefinitionMessage";


   
   public override void serialize(test.FooAppearanceDefinitionMessage data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, test.FooAppearanceDefinitionMessage data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(test.FooAppearanceDefinitionMessage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(test.FooAppearanceDefinitionMessage data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(test.FooAppearanceDefinitionMessage data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_6(data.r);

      cdr.write_type_6(data.g);

      cdr.write_type_6(data.b);

      cdr.write_type_6(data.transparency);

   }

   public static void read(test.FooAppearanceDefinitionMessage data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.r=cdr.read_type_6();
      	
      data.g=cdr.read_type_6();
      	
      data.b=cdr.read_type_6();
      	
      data.transparency=cdr.read_type_6();
      	

   }



   public override string getName()
   {
      return name;
   }
   

}


}