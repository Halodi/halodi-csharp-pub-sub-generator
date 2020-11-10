namespace test
{

/**
* 
* Topic data type of the struct "FooJointDefinition" defined in "FooHandshake.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from FooHandshake.idl by us.ihmc.idl.generator.IDLGenerator. 
* Do not update this file directly, edit FooHandshake.idl instead.
*
*/
public class FooJointDefinitionPubSubType : Halodi.TopicDataType<test.FooJointDefinition>
{
   public const string name = "test::FooJointDefinition";


   private final us.ihmc.idl.CDR serializeCDR = new us.ihmc.idl.CDR();
   private final us.ihmc.idl.CDR deserializeCDR = new us.ihmc.idl.CDR();

   @Override
   public void serialize(test.FooJointDefinition data, us.ihmc.pubsub.common.SerializedPayload serializedPayload) throws java.io.IOException
   {
      serializeCDR.serialize(serializedPayload);
      write(data, serializeCDR);
      serializeCDR.finishSerialize();
   }

   @Override
   public void deserialize(us.ihmc.pubsub.common.SerializedPayload serializedPayload, test.FooJointDefinition data) throws java.io.IOException
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

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4) + 255 + 1;
      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);


      return current_alignment - initial_alignment;
   }

   public final static int getCdrSerializedSize(test.FooJointDefinition data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.FooJointDefinition data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4) + data.getName().length() + 1;

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(test.FooJointDefinition data, us.ihmc.idl.CDR cdr)
   {
      if(data.getName().length() <= 255)
      cdr.write_type_d(data.getName());else
          throw new RuntimeException("name field exceeds the maximum length");

      cdr.write_type_c(data.getType().ordinal());


   }

   public static void read(test.FooJointDefinition data, us.ihmc.idl.CDR cdr)
   {
      cdr.read_type_d(data.getName());	
      data.setType(test.FooJointType.values[cdr.read_type_c()]);
      	

   }

   @Override
   public final void serialize(test.FooJointDefinition data, us.ihmc.idl.InterchangeSerializer ser)
   {
      ser.write_type_d("name", data.getName());
      ser.write_type_c("type", data.getType());
   }

   @Override
   public final void deserialize(us.ihmc.idl.InterchangeSerializer ser, test.FooJointDefinition data)
   {
      ser.read_type_d("name", data.getName());
      data.setType((test.FooJointType)ser.read_type_c("type", test.FooJointType.class));

   }

   public static void staticCopy(test.FooJointDefinition src, test.FooJointDefinition dest)
   {
      dest.set(src);
   }

   @Override
   public test.FooJointDefinition createData()
   {
      return new test.FooJointDefinition();
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
   
   public void serialize(test.FooJointDefinition data, us.ihmc.idl.CDR cdr)
   {
      write(data, cdr);
   }

   public void deserialize(test.FooJointDefinition data, us.ihmc.idl.CDR cdr)
   {
      read(data, cdr);
   }
   
   public void copy(test.FooJointDefinition src, test.FooJointDefinition dest)
   {
      staticCopy(src, dest);
   }

   @Override
   public FooJointDefinitionPubSubType newInstance()
   {
      return new FooJointDefinitionPubSubType();
   }
}


}