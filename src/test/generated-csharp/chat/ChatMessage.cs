using System.Text;
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
      builder.Append(this.key);      builder.Append(", ");
      builder.Append("sender=");
      builder.Append(this.sender);      builder.Append(", ");
      builder.Append("msg=");
      builder.Append(this.msg);
      builder.Append("}");
      return builder.ToString();
   }
}


}