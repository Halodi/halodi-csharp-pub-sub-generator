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

   public static int getMaxCdrSerializedSize()
   {
      return getMaxCdrSerializedSize(0);
   }

   public static int getMaxCdrSerializedSize(int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 2 + us.ihmc.idl.CDR.alignment(current_alignment, 2);

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4) + 255 + 1;

      return current_alignment - initial_alignment;
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

      if(data.getName().length() <= 255)
      cdr.write_type_d(data.getName());else
          throw new RuntimeException("name field exceeds the maximum length");

   }

   public static void read(test.FooYoRegistryDefinition data, us.ihmc.idl.CDR cdr)
   {
      data.setParent(cdr.read_type_3());
      	
      cdr.read_type_d(data.getName());	

   }

   @Override
   public final void serialize(test.FooYoRegistryDefinition data, us.ihmc.idl.InterchangeSerializer ser)
   {
      ser.write_type_3("parent", data.getParent());
      ser.write_type_d("name", data.getName());
   }

   @Override
   public final void deserialize(us.ihmc.idl.InterchangeSerializer ser, test.FooYoRegistryDefinition data)
   {
      data.setParent(ser.read_type_3("parent"));
      ser.read_type_d("name", data.getName());
   }

   public static void staticCopy(test.FooYoRegistryDefinition src, test.FooYoRegistryDefinition dest)
   {
      dest.set(src);
   }

   @Override
   public test.FooYoRegistryDefinition createData()
   {
      return new test.FooYoRegistryDefinition();
   }

   @Override
   public int getTypeSize()
   {
      return us.ihmc.idl.CDR.getTypeSize(getMaxCdrSerializedSize());
   }

   @Override
   public java.lang.String getName()
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
   
   public void copy(test.FooYoRegistryDefinition src, test.FooYoRegistryDefinition dest)
   {
      staticCopy(src, dest);
   }

   @Override
   public FooYoRegistryDefinitionPubSubType newInstance()
   {
      return new FooYoRegistryDefinitionPubSubType();
   }
}


}