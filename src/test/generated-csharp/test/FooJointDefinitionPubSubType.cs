using System.IO;
namespace test
{

/**
* 
* Topic data type of the struct "FooJointDefinition" defined in "FooHandshake.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from FooHandshake.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit FooHandshake.idl instead.
*
*/
public class FooJointDefinitionPubSubType : Halodi.TopicDataType<test.FooJointDefinition>
{
   public const string name = "test::FooJointDefinition";


   @Override
   public void serialize(test.FooJointDefinition data, MemoryStream stream) throws java.io.IOException
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   @Override
   public void deserialize(MemoryStream stream, test.FooJointDefinition data) throws java.io.IOException
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(stream);
   	   		read(data, cdr); 
   	   }
   }

   public final static int getCdrSerializedSize(test.FooJointDefinition data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.FooJointDefinition data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.getName().length() + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(test.FooJointDefinition data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_d(data.getName());

      cdr.write_type_c(data.getType().ordinal());


   }

   public static void read(test.FooJointDefinition data, Halodi.CDR.CDRDeserializer cdr)
   {
      cdr.read_type_d(data.getName());	
      data.Type = (test.FooJointType) cdr.read_type_c();
      	

   }



   public override string getName()
   {
      return name;
   }
   

}


}