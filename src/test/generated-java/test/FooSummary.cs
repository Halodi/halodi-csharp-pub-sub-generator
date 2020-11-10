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

      summarizedVariables.set(other.summarizedVariables);
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("FooSummary {");
      builder.Append("createSummary=");
      builder.Append(this.createSummary_);      Append.append(", ");
      builder.Append("summaryTriggerVariable=");
      builder.Append(this.summaryTriggerVariable_);      Append.append(", ");
      builder.Append("summarizedVariables=");
      builder.Append(this.summarizedVariables_);
      builder.Append("}");
      return builder.ToString();
   }
}
