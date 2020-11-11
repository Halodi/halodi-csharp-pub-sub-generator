using System.IO;
namespace test
{

/**
* 
* Topic data type of the struct "FooYoVariableDefinition" defined in "FooHandshake.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from FooHandshake.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit FooHandshake.idl instead.
*
*/
public class FooYoVariableDefinitionPubSubType : Halodi.CDR.TopicDataType<test.FooYoVariableDefinition>
{
   public const string name = "test::FooYoVariableDefinition";


   
   public override void serialize(test.FooYoVariableDefinition data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, test.FooYoVariableDefinition data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(stream);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(test.FooYoVariableDefinition data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(test.FooYoVariableDefinition data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.getName().length() + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.getDescription().length() + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 2 + Halodi.CDR.CDRCommon.alignment(current_alignment, 2);


      current_alignment += 2 + Halodi.CDR.CDRCommon.alignment(current_alignment, 2);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(test.FooYoVariableDefinition data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_d(data.name);

      cdr.write_type_d(data.description);

      cdr.write_type_c(data.type.ordinal());


      cdr.write_type_3(data.registry);

      cdr.write_type_3(data.enumType);

      cdr.write_type_7(data.allowNullValues);

      cdr.write_type_7(data.isParameter);

      cdr.write_type_6(data.min);

      cdr.write_type_6(data.max);

      cdr.write_type_c(data.loadStatus.ordinal());


   }

   public static void read(test.FooYoVariableDefinition data, Halodi.CDR.CDRDeserializer cdr)
   {
      cdr.read_type_d(data.name);	
      cdr.read_type_d(data.description);	
      data.type = (test.FooYoType) cdr.read_type_c();
      	
      data.registry=cdr.read_type_3();
      	
      data.enumType=cdr.read_type_3();
      	
      data.allowNullValues=cdr.read_type_7();
      	
      data.isParameter=cdr.read_type_7();
      	
      data.min=cdr.read_type_6();
      	
      data.max=cdr.read_type_6();
      	
      data.loadStatus = (test.FooLoadStatus) cdr.read_type_c();
      	

   }



   public override string getName()
   {
      return name;
   }
   

}


}