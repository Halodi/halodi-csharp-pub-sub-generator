using System.Text;
namespace test
{


/**
 * This message is to test sending uint32_t.
 */
[System.Serializable]
public class StatusMessage
{
   public ulong sequence_id;
   public bool pause;


   public void Set(StatusMessage other)
   {
      sequence_id = other.sequence_id;

      pause = other.pause;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("StatusMessage {");
      builder.Append("sequence_id=");
      builder.Append(this.sequence_id);      builder.Append(", ");
      builder.Append("pause=");
      builder.Append(this.pause);
      builder.Append("}");
      return builder.ToString();
   }
}


}