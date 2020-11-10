namespace test
{

/**
* 
* Topic data type of the struct "FooGraphicObjectMessage" defined in "FooHandshake.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from FooHandshake.idl by us.ihmc.idl.generator.IDLGenerator. 
* Do not update this file directly, edit FooHandshake.idl instead.
*
*/
public class FooGraphicObjectMessagePubSubType : Halodi.TopicDataType<test.FooGraphicObjectMessage>
{
   public const string name = "test::FooGraphicObjectMessage";


   private final us.ihmc.idl.CDR serializeCDR = new us.ihmc.idl.CDR();
   private final us.ihmc.idl.CDR deserializeCDR = new us.ihmc.idl.CDR();

   @Override
   public void serialize(test.FooGraphicObjectMessage data, us.ihmc.pubsub.common.SerializedPayload serializedPayload) throws java.io.IOException
   {
      serializeCDR.serialize(serializedPayload);
      write(data, serializeCDR);
      serializeCDR.finishSerialize();
   }

   @Override
   public void deserialize(us.ihmc.pubsub.common.SerializedPayload serializedPayload, test.FooGraphicObjectMessage data) throws java.io.IOException
   {
      deserializeCDR.deserialize(serializedPayload);
      read(data, deserializeCDR);
      deserializeCDR.finishDeserialize();
   }

   public final static int getCdrSerializedSize(test.FooGraphicObjectMessage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.FooGraphicObjectMessage data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4) + data.getName().length() + 1;

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      current_alignment += (data.getYoVariableIndex().size() * 2) + us.ihmc.idl.CDR.alignment(current_alignment, 2);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      current_alignment += (data.getConstants().size() * 8) + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      current_alignment += test.FooAppearanceDefinitionMessagePubSubType.getCdrSerializedSize(data.getAppearance(), current_alignment);

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4) + data.getListName().length() + 1;


      return current_alignment - initial_alignment;
   }

   public static void write(test.FooGraphicObjectMessage data, us.ihmc.idl.CDR cdr)
   {
      cdr.write_type_2(data.getRegistrationID());

      cdr.write_type_d(data.getName());

      cdr.write_type_e(data.getYoVariableIndex());

      cdr.write_type_e(data.getConstants());

      test.FooAppearanceDefinitionMessagePubSubType.write(data.getAppearance(), cdr);
      cdr.write_type_d(data.getListName());

   }

   public static void read(test.FooGraphicObjectMessage data, us.ihmc.idl.CDR cdr)
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


   public override int getTypeSize()
   {
      return us.ihmc.idl.CDR.getTypeSize(getMaxCdrSerializedSize());
   }

   public override string getName()
   {
      return name;
   }
   
   public void serialize(test.FooGraphicObjectMessage data, us.ihmc.idl.CDR cdr)
   {
      write(data, cdr);
   }

   public void deserialize(test.FooGraphicObjectMessage data, us.ihmc.idl.CDR cdr)
   {
      read(data, cdr);
   }
}


}