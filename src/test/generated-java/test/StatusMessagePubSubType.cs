namespace test
{

/**
* 
* Topic data type of the struct "StatusMessage" defined in "StatusMessage.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from StatusMessage.idl by us.ihmc.idl.generator.IDLGenerator. 
* Do not update this file directly, edit StatusMessage.idl instead.
*
*/
public class StatusMessagePubSubType : Halodi.TopicDataType<test.StatusMessage>
{
   public const string name = "test::StatusMessage";


   private final us.ihmc.idl.CDR serializeCDR = new us.ihmc.idl.CDR();
   private final us.ihmc.idl.CDR deserializeCDR = new us.ihmc.idl.CDR();

   @Override
   public void serialize(test.StatusMessage data, us.ihmc.pubsub.common.SerializedPayload serializedPayload) throws java.io.IOException
   {
      serializeCDR.serialize(serializedPayload);
      write(data, serializeCDR);
      serializeCDR.finishSerialize();
   }

   @Override
   public void deserialize(us.ihmc.pubsub.common.SerializedPayload serializedPayload, test.StatusMessage data) throws java.io.IOException
   {
      deserializeCDR.deserialize(serializedPayload);
      read(data, deserializeCDR);
      deserializeCDR.finishDeserialize();
   }

   public final static int getCdrSerializedSize(test.StatusMessage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.StatusMessage data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      current_alignment += 1 + us.ihmc.idl.CDR.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(test.StatusMessage data, us.ihmc.idl.CDR cdr)
   {
      cdr.write_type_12(data.getSequenceId());

      cdr.write_type_7(data.getPause());

   }

   public static void read(test.StatusMessage data, us.ihmc.idl.CDR cdr)
   {
      data.SequenceId=cdr.read_type_12());
      	
      data.Pause=cdr.read_type_7());
      	

   }


   public override int getTypeSize()
   {
      return us.ihmc.idl.CDR.getTypeSize(getMaxCdrSerializedSize());
   }

   public override string getName()
   {
      return name;
   }
   
   public void serialize(test.StatusMessage data, us.ihmc.idl.CDR cdr)
   {
      write(data, cdr);
   }

   public void deserialize(test.StatusMessage data, us.ihmc.idl.CDR cdr)
   {
      read(data, cdr);
   }
}


}