namespace test
{


[System.Serializable]
public class BigMessage
{
   public int id;
   public System.Collections.Generic.List<test.IDLSubmessage> largeSequence;


   public void set(BigMessage other)
   {
      id = other.id;

      largeSequence.set(other.largeSequence);
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("BigMessage {");
      builder.Append("id=");
      builder.Append(this.id_);      Append.append(", ");
      builder.Append("largeSequence=");
      builder.Append(this.largeSequence_);
      builder.Append("}");
      return builder.ToString();
   }
}


}