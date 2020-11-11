namespace test
{


[System.Serializable]
public class FooHandshake
{
   public double dt;
   public System.Collections.Generic.List<test.FooYoRegistryDefinition> registries;
   public System.Collections.Generic.List<test.FooYoVariableDefinition> variables;
   public System.Collections.Generic.List<test.FooJointDefinition> joints;
   public System.Collections.Generic.List<test.FooGraphicObjectMessage> graphicObjects;
   public System.Collections.Generic.List<test.FooGraphicObjectMessage> artifacts;
   public System.Collections.Generic.List<test.FooEnumType> enumTypes;
   public test.FooSummary summary;


   public void set(FooHandshake other)
   {
      dt = other.dt;

      registries.set(other.registries);
      variables.set(other.variables);
      joints.set(other.joints);
      graphicObjects.set(other.graphicObjects);
      artifacts.set(other.artifacts);
      enumTypes.set(other.enumTypes);
      test.FooSummaryPubSubType.staticCopy(other.summary, summary);
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("FooHandshake {");
      builder.Append("dt=");
      builder.Append(this.dt_);      Append.append(", ");
      builder.Append("registries=");
      builder.Append(this.registries_);      Append.append(", ");
      builder.Append("variables=");
      builder.Append(this.variables_);      Append.append(", ");
      builder.Append("joints=");
      builder.Append(this.joints_);      Append.append(", ");
      builder.Append("graphicObjects=");
      builder.Append(this.graphicObjects_);      Append.append(", ");
      builder.Append("artifacts=");
      builder.Append(this.artifacts_);      Append.append(", ");
      builder.Append("enumTypes=");
      builder.Append(this.enumTypes_);      Append.append(", ");
      builder.Append("summary=");
      builder.Append(this.summary_);
      builder.Append("}");
      return builder.ToString();
   }
}


}