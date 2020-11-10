namespace test
{

/**
* 
* Topic data type of the struct "FooYoRegistryDefinition" defined in "FooHandshake.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from FooHandshake.idl by us.ihmc.idl.generator.IDLGenerator. 
* Do not update this file directly, edit FooHandshake.idl instead.
*
*/
public class FooYoRegistryDefinitionPubSubType : Halodi.TopicDataType<test.FooYoRegistryDefinition>
{
   public const string name = "test::FooYoRegistryDefinition";


   private final us.ihmc.idl.CDR serializeCDR = new us.ihmc.idl.CDR();
   private final us.ihmc.idl.CDR deserializeCDR = new us.ihmc.idl.CDR();

   @Override
   public void serialize(test.FooYoRegistryDefinition data, us.ihmc.pubsub.common.SerializedPayload serializedPayload) throws java.io.IOException
   {
      serializeCDR.serialize(serializedPayload);
      write(data, serializeCDR);
      serializeCDR.finishSerialize();
   }

   @Override
   public void deserialize(us.ihmc.pubsub.common.SerializedPayload serializedPayload, test.FooYoRegistryDefinition data) throws java.io.IOException
   {
      deserializeCDR.deserialize(serializedPayload);
      read(data, deserializeCDR);
      deserializeCDR.finishDeserialize();
   }

   public final static int getCdrSerializedSize(test.FooYoRegistryDefinition data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.FooYoRegistryDefinition data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 2 + us.ihmc.idl.CDR.alignment(current_alignment, 2);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4) + data.getName().length() + 1;


      return current_alignment - initial_alignment;
   }

   public static void write(test.FooYoRegistryDefinition data, us.ihmc.idl.CDR cdr)
   {
      cdr.write_type_3(data.getParent());

      cdr.write_type_d(data.getName());

   }

   public static void read(test.FooYoRegistryDefinition data, us.ihmc.idl.CDR cdr)
   {
      data.Parent=cdr.read_type_3());
      	
      cdr.read_type_d(data.getName());	

   }


   public override int getTypeSize()
   {
      return us.ihmc.idl.CDR.getTypeSize(getMaxCdrSerializedSize());
   }

   public override string getName()
   {
      return name;
   }
   
   public void serialize(test.FooYoRegistryDefinition data, us.ihmc.idl.CDR cdr)
   {
      write(data, cdr);
   }

   public void deserialize(test.FooYoRegistryDefinition data, us.ihmc.idl.CDR cdr)
   {
      read(data, cdr);
   }
}


}