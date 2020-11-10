package test;

/**
* 
* Topic data type of the struct "FooAppearanceDefinitionMessage" defined in "FooHandshake.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from FooHandshake.idl by us.ihmc.idl.generator.IDLGenerator. 
* Do not update this file directly, edit FooHandshake.idl instead.
*
*/
public class FooAppearanceDefinitionMessagePubSubType implements us.ihmc.pubsub.TopicDataType<test.FooAppearanceDefinitionMessage>
{
   public static final java.lang.String name = "test::FooAppearanceDefinitionMessage";

   private final us.ihmc.idl.CDR serializeCDR = new us.ihmc.idl.CDR();
   private final us.ihmc.idl.CDR deserializeCDR = new us.ihmc.idl.CDR();

   @Override
   public void serialize(test.FooAppearanceDefinitionMessage data, us.ihmc.pubsub.common.SerializedPayload serializedPayload) throws java.io.IOException
   {
      serializeCDR.serialize(serializedPayload);
      write(data, serializeCDR);
      serializeCDR.finishSerialize();
   }

   @Override
   public void deserialize(us.ihmc.pubsub.common.SerializedPayload serializedPayload, test.FooAppearanceDefinitionMessage data) throws java.io.IOException
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

      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);

      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);

      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);

      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      return current_alignment - initial_alignment;
   }

   public final static int getCdrSerializedSize(test.FooAppearanceDefinitionMessage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.FooAppearanceDefinitionMessage data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(test.FooAppearanceDefinitionMessage data, us.ihmc.idl.CDR cdr)
   {
      cdr.write_type_6(data.getR());

      cdr.write_type_6(data.getG());

      cdr.write_type_6(data.getB());

      cdr.write_type_6(data.getTransparency());

   }

   public static void read(test.FooAppearanceDefinitionMessage data, us.ihmc.idl.CDR cdr)
   {
      data.setR(cdr.read_type_6());
      	
      data.setG(cdr.read_type_6());
      	
      data.setB(cdr.read_type_6());
      	
      data.setTransparency(cdr.read_type_6());
      	

   }

   @Override
   public final void serialize(test.FooAppearanceDefinitionMessage data, us.ihmc.idl.InterchangeSerializer ser)
   {
      ser.write_type_6("r", data.getR());
      ser.write_type_6("g", data.getG());
      ser.write_type_6("b", data.getB());
      ser.write_type_6("transparency", data.getTransparency());
   }

   @Override
   public final void deserialize(us.ihmc.idl.InterchangeSerializer ser, test.FooAppearanceDefinitionMessage data)
   {
      data.setR(ser.read_type_6("r"));
      data.setG(ser.read_type_6("g"));
      data.setB(ser.read_type_6("b"));
      data.setTransparency(ser.read_type_6("transparency"));
   }

   public static void staticCopy(test.FooAppearanceDefinitionMessage src, test.FooAppearanceDefinitionMessage dest)
   {
      dest.set(src);
   }

   @Override
   public test.FooAppearanceDefinitionMessage createData()
   {
      return new test.FooAppearanceDefinitionMessage();
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
   
   public void serialize(test.FooAppearanceDefinitionMessage data, us.ihmc.idl.CDR cdr)
   {
      write(data, cdr);
   }

   public void deserialize(test.FooAppearanceDefinitionMessage data, us.ihmc.idl.CDR cdr)
   {
      read(data, cdr);
   }
   
   public void copy(test.FooAppearanceDefinitionMessage src, test.FooAppearanceDefinitionMessage dest)
   {
      staticCopy(src, dest);
   }

   @Override
   public FooAppearanceDefinitionMessagePubSubType newInstance()
   {
      return new FooAppearanceDefinitionMessagePubSubType();
   }
}
