using System.IO;
namespace chat
{

/**
* 
* Topic data type of the struct "ChatMessage" defined in "ChatMessage.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from ChatMessage.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit ChatMessage.idl instead.
*
*/
public class ChatMessagePubSubType : Halodi.TopicDataType<chat.ChatMessage>
{
   public const string name = "chat::ChatMessage";


   @Override
   public void serialize(chat.ChatMessage data, MemoryStream stream) throws java.io.IOException
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   @Override
   public void deserialize(MemoryStream stream, chat.ChatMessage data) throws java.io.IOException
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(stream);
   	   		read(data, cdr); 
   	   }
   }

   public final static int getCdrSerializedSize(chat.ChatMessage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(chat.ChatMessage data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.getSender().length() + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.getMsg().length() + 1;


      return current_alignment - initial_alignment;
   }

   public static void write(chat.ChatMessage data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_2(data.getKey());

      cdr.write_type_d(data.getSender());

      cdr.write_type_d(data.getMsg());

   }

   public static void read(chat.ChatMessage data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.Key=cdr.read_type_2());
      	
      cdr.read_type_d(data.getSender());	
      cdr.read_type_d(data.getMsg());	

   }



   public override string getName()
   {
      return name;
   }
   

}


}