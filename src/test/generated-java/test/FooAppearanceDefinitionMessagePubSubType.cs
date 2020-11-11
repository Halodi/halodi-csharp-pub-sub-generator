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
public class FooAppearanceDefinitionMessagePubSubType : Halodi.TopicDataType<test.FooAppearanceDefinitionMessage>
{
   public const string name = "test::FooAppearanceDefinitionMessage";


   @Override
   public void serialize(test.FooAppearanceDefinitionMessage data, MemoryStream stream) throws java.io.IOException
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   @Override
   public void deserialize(MemoryStream stream, test.FooAppearanceDefinitionMessage data) throws java.io.IOException
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(stream);
   	   		read(data, cdr); 
   	   }
   }

   public final static int getCdrSerializedSize(test.FooAppearanceDefinitionMessage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.FooAppearanceDefinitionMessage data, int current_alignment)
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
      cdr.write_type_6(data.getR());

      cdr.write_type_6(data.getG());

      cdr.write_type_6(data.getB());

      cdr.write_type_6(data.getTransparency());

   }

   public static void read(test.FooAppearanceDefinitionMessage data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.R=cdr.read_type_6());
      	
      data.G=cdr.read_type_6());
      	
      data.B=cdr.read_type_6());
      	
      data.Transparency=cdr.read_type_6());
      	

   }



   public override string getName()
   {
      return name;
   }
   

}


}