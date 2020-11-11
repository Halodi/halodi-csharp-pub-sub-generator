using System.Text;
namespace test
{


[System.Serializable]
public class FooSummary
{
   public bool createSummary;
   public string summaryTriggerVariable;
   public System.Collections.Generic.List<string> summarizedVariables;


   public void set(FooSummary other)
   {
      createSummary = other.createSummary;

      summaryTriggerVariable = other.summaryTriggerVariable;



      summarizedVariables = new System.Collections.Generic.List<string>(other.summarizedVariables.Count);
      for(int i4 = 0; i4 < other.summarizedVariables.Count; i4++)
      {
         summarizedVariables.Add(other.summarizedVariables[i4]);
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("FooSummary {");
      builder.Append("createSummary=");
      builder.Append(this.createSummary);      builder.Append(", ");
      builder.Append("summaryTriggerVariable=");
      builder.Append(this.summaryTriggerVariable);      builder.Append(", ");
      builder.Append("summarizedVariables=");
      builder.Append(this.summarizedVariables);
      builder.Append("}");
      return builder.ToString();
   }
}


}