using System.Text;
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



      largeSequence = new System.Collections.Generic.List<test.IDLSubmessage>(other.largeSequence.Count);
      for(int i1 = 0; i1 < other.largeSequence.Count; i1++)
      {
      	test.IDLSubmessage newElement = new test.IDLSubmessagePubSubType.Create();
         test.IDLSubmessagePubSubType.Copy(other.largeSequence, newElement);
         largeSequence.Add(newElement);}
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("BigMessage {");
      builder.Append("id=");
      builder.Append(this.id);      builder.Append(", ");
      builder.Append("largeSequence=");
      builder.Append(this.largeSequence);
      builder.Append("}");
      return builder.ToString();
   }
}


}