namespace chat
{


// Define a ChatMessage
[System.Serializable]
public class ChatMessage
{
   public int key;
   /*
           * This is the sender
           */
   public string sender;
   // This is the message
   public string msg;


   public void set(ChatMessage other)
   {
      key = other.key;

      sender = other.sender;

      msg = other.msg;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("ChatMessage {");
      builder.Append("key=");
      builder.Append(this.key_);      Append.append(", ");
      builder.Append("sender=");
      builder.Append(this.sender_);      Append.append(", ");
      builder.Append("msg=");
      builder.Append(this.msg_);
      builder.Append("}");
      return builder.ToString();
   }
}


}