namespace test
{

/**
* 
* Topic data type of the struct "FooEnumType" defined in "FooHandshake.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from FooHandshake.idl by us.ihmc.idl.generator.IDLGenerator. 
* Do not update this file directly, edit FooHandshake.idl instead.
*
*/
public class FooEnumTypePubSubType : Halodi.TopicDataType<test.FooEnumType>
{
   public const string name = "test::FooEnumType";


   private final us.ihmc.idl.CDR serializeCDR = new us.ihmc.idl.CDR();
   private final us.ihmc.idl.CDR deserializeCDR = new us.ihmc.idl.CDR();

   @Override
   public void serialize(test.FooEnumType data, us.ihmc.pubsub.common.SerializedPayload serializedPayload) throws java.io.IOException
   {
      serializeCDR.serialize(serializedPayload);
      write(data, serializeCDR);
      serializeCDR.finishSerialize();
   }

   @Override
   public void deserialize(us.ihmc.pubsub.common.SerializedPayload serializedPayload, test.FooEnumType data) throws java.io.IOException
   {
      deserializeCDR.deserialize(serializedPayload);
      read(data, deserializeCDR);
      deserializeCDR.finishDeserialize();
   }

   public final static int getCdrSerializedSize(test.FooEnumType data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.FooEnumType data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4) + data.getName().length() + 1;

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getEnumValues().size(); ++i0)
      {
          current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4) + data.getEnumValues().get(i0).length() + 1;
      }

      return current_alignment - initial_alignment;
   }

   public static void write(test.FooEnumType data, us.ihmc.idl.CDR cdr)
   {
      cdr.write_type_d(data.getName());

      cdr.write_type_e(data.getEnumValues());

   }

   public static void read(test.FooEnumType data, us.ihmc.idl.CDR cdr)
   {
      cdr.read_type_d(data.getName());	

      int EnumValues_length = cdr.read_type_2();
      data.EnumValues = new System.Collections.Generic.List<string>(EnumValues_length);
      for(int i = 0; i < EnumValues_length; i++)
      {
      	cdr.read_type_d(data.EnumValues);	
      	
      }
      	

   }


   public override int getTypeSize()
   {
      return us.ihmc.idl.CDR.getTypeSize(getMaxCdrSerializedSize());
   }

   public override string getName()
   {
      return name;
   }
   
   public void serialize(test.FooEnumType data, us.ihmc.idl.CDR cdr)
   {
      write(data, cdr);
   }

   public void deserialize(test.FooEnumType data, us.ihmc.idl.CDR cdr)
   {
      read(data, cdr);
   }
}


}