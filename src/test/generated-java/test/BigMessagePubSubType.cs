package test;

/**
* 
* Topic data type of the struct "BigMessage" defined in "BigMessage.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from BigMessage.idl by us.ihmc.idl.generator.IDLGenerator. 
* Do not update this file directly, edit BigMessage.idl instead.
*
*/
public class BigMessagePubSubType implements us.ihmc.pubsub.TopicDataType<test.BigMessage>
{
   public static final java.lang.String name = "test::BigMessage";

   private final us.ihmc.idl.CDR serializeCDR = new us.ihmc.idl.CDR();
   private final us.ihmc.idl.CDR deserializeCDR = new us.ihmc.idl.CDR();

   @Override
   public void serialize(test.BigMessage data, us.ihmc.pubsub.common.SerializedPayload serializedPayload) throws java.io.IOException
   {
      serializeCDR.serialize(serializedPayload);
      write(data, serializeCDR);
      serializeCDR.finishSerialize();
   }

   @Override
   public void deserialize(us.ihmc.pubsub.common.SerializedPayload serializedPayload, test.BigMessage data) throws java.io.IOException
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

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);for(int i0 = 0; i0 < 100000; ++i0)
      {
          current_alignment += test.IDLSubmessagePubSubType.getMaxCdrSerializedSize(current_alignment);}

      return current_alignment - initial_alignment;
   }

   public final static int getCdrSerializedSize(test.BigMessage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.BigMessage data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getLargeSequence().size(); ++i0)
      {
          current_alignment += test.IDLSubmessagePubSubType.getCdrSerializedSize(data.getLargeSequence().get(i0), current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(test.BigMessage data, us.ihmc.idl.CDR cdr)
   {
      cdr.write_type_2(data.getId());

      if(data.getLargeSequence().size() <= 100000)
      cdr.write_type_e(data.getLargeSequence());else
          throw new RuntimeException("largeSequence field exceeds the maximum length");

   }

   public static void read(test.BigMessage data, us.ihmc.idl.CDR cdr)
   {
      data.setId(cdr.read_type_2());
      	
      cdr.read_type_e(data.getLargeSequence());	

   }

   @Override
   public final void serialize(test.BigMessage data, us.ihmc.idl.InterchangeSerializer ser)
   {
      ser.write_type_2("id", data.getId());
      ser.write_type_e("largeSequence", data.getLargeSequence());
   }

   @Override
   public final void deserialize(us.ihmc.idl.InterchangeSerializer ser, test.BigMessage data)
   {
      data.setId(ser.read_type_2("id"));
      ser.read_type_e("largeSequence", data.getLargeSequence());
   }

   public static void staticCopy(test.BigMessage src, test.BigMessage dest)
   {
      dest.set(src);
   }

   @Override
   public test.BigMessage createData()
   {
      return new test.BigMessage();
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
   
   public void serialize(test.BigMessage data, us.ihmc.idl.CDR cdr)
   {
      write(data, cdr);
   }

   public void deserialize(test.BigMessage data, us.ihmc.idl.CDR cdr)
   {
      read(data, cdr);
   }
   
   public void copy(test.BigMessage src, test.BigMessage dest)
   {
      staticCopy(src, dest);
   }

   @Override
   public BigMessagePubSubType newInstance()
   {
      return new BigMessagePubSubType();
   }
}
