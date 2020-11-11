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
public class FooGraphicObjectMessagePubSubType : Halodi.CDR.TopicDataType<test.FooGraphicObjectMessage>
{
   public override string Name => "test::FooGraphicObjectMessage";


   
   public override void serialize(test.FooGraphicObjectMessage data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, test.FooGraphicObjectMessage data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(test.FooGraphicObjectMessage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(test.FooGraphicObjectMessage data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.name.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.yoVariableIndex.Count * 2) + Halodi.CDR.CDRCommon.alignment(current_alignment, 2);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.constants.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += test.FooAppearanceDefinitionMessagePubSubType.getCdrSerializedSize(data.appearance, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.listName.Length + 1;


      return current_alignment - initial_alignment;
   }

   public static void write(test.FooGraphicObjectMessage data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_2(data.registrationID);

      cdr.write_type_d(data.name);


      	int yoVariableIndex_length = data.yoVariableIndex.Count;
            cdr.write_type_2(yoVariableIndex_length);
            for (int i0 = 0; i0 < yoVariableIndex_length; i0++)
            {
      			cdr.write_type_3(data.yoVariableIndex[i0]);
            }

      	int constants_length = data.constants.Count;
            cdr.write_type_2(constants_length);
            for (int i0 = 0; i0 < constants_length; i0++)
            {
      			cdr.write_type_6(data.constants[i0]);
            }
      test.FooAppearanceDefinitionMessagePubSubType.write(data.appearance, cdr);

      cdr.write_type_d(data.listName);

   }

   public static void read(test.FooGraphicObjectMessage data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.registrationID=cdr.read_type_2();
      	
      data.name = cdr.read_type_d();	

      int yoVariableIndex_length = cdr.read_type_2();
      data.yoVariableIndex = new System.Collections.Generic.List<ushort>(yoVariableIndex_length);
      for(int i = 0; i < yoVariableIndex_length; i++)
      {
      	data.yoVariableIndex.Add(cdr.read_type_3());
      	
      	
      }

      	

      int constants_length = cdr.read_type_2();
      data.constants = new System.Collections.Generic.List<double>(constants_length);
      for(int i = 0; i < constants_length; i++)
      {
      	data.constants.Add(cdr.read_type_6());
      	
      	
      }

      	
      data.appearance = test.FooAppearanceDefinitionMessagePubSubType.Create();
      test.FooAppearanceDefinitionMessagePubSubType.read(data.appearance, cdr);
      	
      data.listName = cdr.read_type_d();	

   }


    public static void Copy(test.FooGraphicObjectMessage src, test.FooGraphicObjectMessage target)
    {
        target.Set(src);
    }


}


}