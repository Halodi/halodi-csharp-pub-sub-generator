namespace test
{

/**
* 
* Topic data type of the struct "BigMessage" defined in "BigMessage.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from BigMessage.idl by us.ihmc.idl.generator.IDLGenerator. 
* Do not update this file directly, edit BigMessage.idl instead.
*
*/
public class BigMessagePubSubType : Halodi.TopicDataType<test.BigMessage>
{
   public const string name = "test::BigMessage";


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

      cdr.write_type_e(data.getLargeSequence());

   }

   public static void read(test.BigMessage data, us.ihmc.idl.CDR cdr)
   {
      data.Id=cdr.read_type_2());
      	

      int LargeSequence_length = cdr.read_type_2();
      data.LargeSequence = new System.Collections.Generic.List<test.IDLSubmessage>(LargeSequence_length);
      for(int i = 0; i < LargeSequence_length; i++)
      {
      	test.IDLSubmessagePubSubType.read(data.LargeSequence, cdr);	
      	
      }
      	

   }



   public override string getName()
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
}


}