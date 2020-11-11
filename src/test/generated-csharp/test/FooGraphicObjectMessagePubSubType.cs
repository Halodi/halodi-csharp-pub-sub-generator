using System.IO;
namespace test
{

/**
* 
* Topic data type of the struct "FooGraphicObjectMessage" defined in "FooHandshake.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from FooHandshake.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit FooHandshake.idl instead.
*
*/
public class FooGraphicObjectMessagePubSubType : Halodi.TopicDataType<test.FooGraphicObjectMessage>
{
   public const string name = "test::FooGraphicObjectMessage";


   @Override
   public void serialize(test.FooGraphicObjectMessage data, MemoryStream stream) throws java.io.IOException
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   @Override
   public void deserialize(MemoryStream stream, test.FooGraphicObjectMessage data) throws java.io.IOException
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(stream);
   	   		read(data, cdr); 
   	   }
   }

   public final static int getCdrSerializedSize(test.FooGraphicObjectMessage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.FooGraphicObjectMessage data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.getName().length() + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.getYoVariableIndex().size() * 2) + Halodi.CDR.CDRCommon.alignment(current_alignment, 2);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.getConstants().size() * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += test.FooAppearanceDefinitionMessagePubSubType.getCdrSerializedSize(data.getAppearance(), current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.getListName().length() + 1;


      return current_alignment - initial_alignment;
   }

   public static void write(test.FooGraphicObjectMessage data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_2(data.getRegistrationID());

      cdr.write_type_d(data.getName());

      cdr.write_type_e(data.getYoVariableIndex());

      cdr.write_type_e(data.getConstants());

      test.FooAppearanceDefinitionMessagePubSubType.write(data.getAppearance(), cdr);
      cdr.write_type_d(data.getListName());

   }

   public static void read(test.FooGraphicObjectMessage data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.RegistrationID=cdr.read_type_2());
      	
      cdr.read_type_d(data.getName());	

      int YoVariableIndex_length = cdr.read_type_2();
      data.YoVariableIndex = new System.Collections.Generic.List<ushort>(YoVariableIndex_length);
      for(int i = 0; i < YoVariableIndex_length; i++)
      {
      	data.YoVariableIndex.Add(cdr.read_type_3());
      	
      	
      }
      	

      int Constants_length = cdr.read_type_2();
      data.Constants = new System.Collections.Generic.List<double>(Constants_length);
      for(int i = 0; i < Constants_length; i++)
      {
      	data.Constants.Add(cdr.read_type_6());
      	
      	
      }
      	
      test.FooAppearanceDefinitionMessagePubSubType.read(data.Appearance, cdr);
      	
      cdr.read_type_d(data.getListName());	

   }



   public override string getName()
   {
      return name;
   }
   

}


}