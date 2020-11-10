namespace chat
{

/**
* 
* Topic data type of the struct "ChatMessage" defined in "ChatMessage.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from ChatMessage.idl by us.ihmc.idl.generator.IDLGenerator. 
* Do not update this file directly, edit ChatMessage.idl instead.
*
*/
public class ChatMessagePubSubType : Halodi.TopicDataType<chat.ChatMessage>
{
   public const string name = "chat::ChatMessage";


   private final us.ihmc.idl.CDR serializeCDR = new us.ihmc.idl.CDR();
   private final us.ihmc.idl.CDR deserializeCDR = new us.ihmc.idl.CDR();

   @Override
   public void serialize(chat.ChatMessage data, us.ihmc.pubsub.common.SerializedPayload serializedPayload) throws java.io.IOException
   {
      serializeCDR.serialize(serializedPayload);
      write(data, serializeCDR);
      serializeCDR.finishSerialize();
   }

   @Override
   public void deserialize(us.ihmc.pubsub.common.SerializedPayload serializedPayload, chat.ChatMessage data) throws java.io.IOException
   {
      deserializeCDR.deserialize(serializedPayload);
      read(data, deserializeCDR);
      deserializeCDR.finishDeserialize();
   }

   public final static int getCdrSerializedSize(chat.ChatMessage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(chat.ChatMessage data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4) + data.getSender().length() + 1;

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4) + data.getMsg().length() + 1;


      return current_alignment - initial_alignment;
   }

   public static void write(chat.ChatMessage data, us.ihmc.idl.CDR cdr)
   {
      cdr.write_type_2(data.getKey());

      cdr.write_type_d(data.getSender());

      cdr.write_type_d(data.getMsg());

   }

   public static void read(chat.ChatMessage data, us.ihmc.idl.CDR cdr)
   {
      data.Key=cdr.read_type_2());
      	
      cdr.read_type_d(data.getSender());	
      cdr.read_type_d(data.getMsg());	

   }



   public override string getName()
   {
      return name;
   }
   
   public void serialize(chat.ChatMessage data, us.ihmc.idl.CDR cdr)
   {
      write(data, cdr);
   }

   public void deserialize(chat.ChatMessage data, us.ihmc.idl.CDR cdr)
   {
      read(data, cdr);
   }
}


}