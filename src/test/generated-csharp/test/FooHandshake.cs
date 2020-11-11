using System.Text;
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



      registries = new System.Collections.Generic.List<test.FooYoRegistryDefinition>(other.registries.Count);
      for(int i5 = 0; i5 < other.registries.Count; i5++)
      {
      	test.FooYoRegistryDefinition newElement = new test.FooYoRegistryDefinitionPubSubType.Create();
         test.FooYoRegistryDefinitionPubSubType.Copy(other.registries, newElement);
         registries.Add(newElement);}


      variables = new System.Collections.Generic.List<test.FooYoVariableDefinition>(other.variables.Count);
      for(int i6 = 0; i6 < other.variables.Count; i6++)
      {
      	test.FooYoVariableDefinition newElement = new test.FooYoVariableDefinitionPubSubType.Create();
         test.FooYoVariableDefinitionPubSubType.Copy(other.variables, newElement);
         variables.Add(newElement);}


      joints = new System.Collections.Generic.List<test.FooJointDefinition>(other.joints.Count);
      for(int i7 = 0; i7 < other.joints.Count; i7++)
      {
      	test.FooJointDefinition newElement = new test.FooJointDefinitionPubSubType.Create();
         test.FooJointDefinitionPubSubType.Copy(other.joints, newElement);
         joints.Add(newElement);}


      graphicObjects = new System.Collections.Generic.List<test.FooGraphicObjectMessage>(other.graphicObjects.Count);
      for(int i8 = 0; i8 < other.graphicObjects.Count; i8++)
      {
      	test.FooGraphicObjectMessage newElement = new test.FooGraphicObjectMessagePubSubType.Create();
         test.FooGraphicObjectMessagePubSubType.Copy(other.graphicObjects, newElement);
         graphicObjects.Add(newElement);}


      artifacts = new System.Collections.Generic.List<test.FooGraphicObjectMessage>(other.artifacts.Count);
      for(int i9 = 0; i9 < other.artifacts.Count; i9++)
      {
      	test.FooGraphicObjectMessage newElement = new test.FooGraphicObjectMessagePubSubType.Create();
         test.FooGraphicObjectMessagePubSubType.Copy(other.artifacts, newElement);
         artifacts.Add(newElement);}


      enumTypes = new System.Collections.Generic.List<test.FooEnumType>(other.enumTypes.Count);
      for(int i10 = 0; i10 < other.enumTypes.Count; i10++)
      {
      	test.FooEnumType newElement = new test.FooEnumTypePubSubType.Create();
         test.FooEnumTypePubSubType.Copy(other.enumTypes, newElement);
         enumTypes.Add(newElement);}
      test.FooSummaryPubSubType.Copy(other.summary, summary);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("FooHandshake {");
      builder.Append("dt=");
      builder.Append(this.dt);      builder.Append(", ");
      builder.Append("registries=");
      builder.Append(this.registries);      builder.Append(", ");
      builder.Append("variables=");
      builder.Append(this.variables);      builder.Append(", ");
      builder.Append("joints=");
      builder.Append(this.joints);      builder.Append(", ");
      builder.Append("graphicObjects=");
      builder.Append(this.graphicObjects);      builder.Append(", ");
      builder.Append("artifacts=");
      builder.Append(this.artifacts);      builder.Append(", ");
      builder.Append("enumTypes=");
      builder.Append(this.enumTypes);      builder.Append(", ");
      builder.Append("summary=");
      builder.Append(this.summary);
      builder.Append("}");
      return builder.ToString();
   }
}


}