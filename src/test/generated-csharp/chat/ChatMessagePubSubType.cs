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
public class ChatMessagePubSubType : Halodi.CDR.TopicDataType<chat.ChatMessage>
{
   public const string name = "chat::ChatMessage";


   
   public override void serialize(chat.ChatMessage data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, chat.ChatMessage data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(chat.ChatMessage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(chat.ChatMessage data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.sender.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.msg.Length + 1;


      return current_alignment - initial_alignment;
   }

   public static void write(chat.ChatMessage data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_2(data.key);

      cdr.write_type_d(data.sender);

      cdr.write_type_d(data.msg);

   }

   public static void read(chat.ChatMessage data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.key=cdr.read_type_2();
      	
      data.sender = cdr.read_type_d();	
      data.msg = cdr.read_type_d();	

   }



   public override string getName()
   {
      return name;
   }
   

}


}