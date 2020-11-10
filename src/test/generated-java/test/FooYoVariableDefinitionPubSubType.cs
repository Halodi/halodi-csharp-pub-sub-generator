package test;

/**
* 
* Topic data type of the struct "FooYoVariableDefinition" defined in "FooHandshake.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from FooHandshake.idl by us.ihmc.idl.generator.IDLGenerator. 
* Do not update this file directly, edit FooHandshake.idl instead.
*
*/
public class FooYoVariableDefinitionPubSubType implements us.ihmc.pubsub.TopicDataType<test.FooYoVariableDefinition>
{
   public static final java.lang.String name = "test::FooYoVariableDefinition";

   private final us.ihmc.idl.CDR serializeCDR = new us.ihmc.idl.CDR();
   private final us.ihmc.idl.CDR deserializeCDR = new us.ihmc.idl.CDR();

   @Override
   public void serialize(test.FooYoVariableDefinition data, us.ihmc.pubsub.common.SerializedPayload serializedPayload) throws java.io.IOException
   {
      serializeCDR.serialize(serializedPayload);
      write(data, serializeCDR);
      serializeCDR.finishSerialize();
   }

   @Override
   public void deserialize(us.ihmc.pubsub.common.SerializedPayload serializedPayload, test.FooYoVariableDefinition data) throws java.io.IOException
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
      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4) + 255 + 1;
      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);

      current_alignment += 2 + us.ihmc.idl.CDR.alignment(current_alignment, 2);

      current_alignment += 2 + us.ihmc.idl.CDR.alignment(current_alignment, 2);

      current_alignment += 1 + us.ihmc.idl.CDR.alignment(current_alignment, 1);

      current_alignment += 1 + us.ihmc.idl.CDR.alignment(current_alignment, 1);

      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);

      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);


      return current_alignment - initial_alignment;
   }

   public final static int getCdrSerializedSize(test.FooYoVariableDefinition data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.FooYoVariableDefinition data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4) + data.getName().length() + 1;

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4) + data.getDescription().length() + 1;

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);


      current_alignment += 2 + us.ihmc.idl.CDR.alignment(current_alignment, 2);


      current_alignment += 2 + us.ihmc.idl.CDR.alignment(current_alignment, 2);


      current_alignment += 1 + us.ihmc.idl.CDR.alignment(current_alignment, 1);


      current_alignment += 1 + us.ihmc.idl.CDR.alignment(current_alignment, 1);


      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(test.FooYoVariableDefinition data, us.ihmc.idl.CDR cdr)
   {
      if(data.getName().length() <= 255)
      cdr.write_type_d(data.getName());else
          throw new RuntimeException("name field exceeds the maximum length");

      if(data.getDescription().length() <= 255)
      cdr.write_type_d(data.getDescription());else
          throw new RuntimeException("description field exceeds the maximum length");

      cdr.write_type_c(data.getType().ordinal());


      cdr.write_type_3(data.getRegistry());

      cdr.write_type_3(data.getEnumType());

      cdr.write_type_7(data.getAllowNullValues());

      cdr.write_type_7(data.getIsParameter());

      cdr.write_type_6(data.getMin());

      cdr.write_type_6(data.getMax());

      cdr.write_type_c(data.getLoadStatus().ordinal());


   }

   public static void read(test.FooYoVariableDefinition data, us.ihmc.idl.CDR cdr)
   {
      cdr.read_type_d(data.getName());	
      cdr.read_type_d(data.getDescription());	
      data.setType(test.FooYoType.values[cdr.read_type_c()]);
      	
      data.setRegistry(cdr.read_type_3());
      	
      data.setEnumType(cdr.read_type_3());
      	
      data.setAllowNullValues(cdr.read_type_7());
      	
      data.setIsParameter(cdr.read_type_7());
      	
      data.setMin(cdr.read_type_6());
      	
      data.setMax(cdr.read_type_6());
      	
      data.setLoadStatus(test.FooLoadStatus.values[cdr.read_type_c()]);
      	

   }

   @Override
   public final void serialize(test.FooYoVariableDefinition data, us.ihmc.idl.InterchangeSerializer ser)
   {
      ser.write_type_d("name", data.getName());
      ser.write_type_d("description", data.getDescription());
      ser.write_type_c("type", data.getType());
      ser.write_type_3("registry", data.getRegistry());
      ser.write_type_3("enumType", data.getEnumType());
      ser.write_type_7("allowNullValues", data.getAllowNullValues());
      ser.write_type_7("isParameter", data.getIsParameter());
      ser.write_type_6("min", data.getMin());
      ser.write_type_6("max", data.getMax());
      ser.write_type_c("loadStatus", data.getLoadStatus());
   }

   @Override
   public final void deserialize(us.ihmc.idl.InterchangeSerializer ser, test.FooYoVariableDefinition data)
   {
      ser.read_type_d("name", data.getName());
      ser.read_type_d("description", data.getDescription());
      data.setType((test.FooYoType)ser.read_type_c("type", test.FooYoType.class));

      data.setRegistry(ser.read_type_3("registry"));
      data.setEnumType(ser.read_type_3("enumType"));
      data.setAllowNullValues(ser.read_type_7("allowNullValues"));
      data.setIsParameter(ser.read_type_7("isParameter"));
      data.setMin(ser.read_type_6("min"));
      data.setMax(ser.read_type_6("max"));
      data.setLoadStatus((test.FooLoadStatus)ser.read_type_c("loadStatus", test.FooLoadStatus.class));

   }

   public static void staticCopy(test.FooYoVariableDefinition src, test.FooYoVariableDefinition dest)
   {
      dest.set(src);
   }

   @Override
   public test.FooYoVariableDefinition createData()
   {
      return new test.FooYoVariableDefinition();
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
   
   public void serialize(test.FooYoVariableDefinition data, us.ihmc.idl.CDR cdr)
   {
      write(data, cdr);
   }

   public void deserialize(test.FooYoVariableDefinition data, us.ihmc.idl.CDR cdr)
   {
      read(data, cdr);
   }
   
   public void copy(test.FooYoVariableDefinition src, test.FooYoVariableDefinition dest)
   {
      staticCopy(src, dest);
   }

   @Override
   public FooYoVariableDefinitionPubSubType newInstance()
   {
      return new FooYoVariableDefinitionPubSubType();
   }
}
