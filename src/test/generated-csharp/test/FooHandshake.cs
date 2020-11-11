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


   public void Set(FooHandshake other)
   {
      dt = other.dt;


      if(other.registries == null)
      {
      	registries = null;
      }
      else
      {
      	registries = new System.Collections.Generic.List<test.FooYoRegistryDefinition>(other.registries.Count);
      	for(int i5 = 0; i5 < other.registries.Count; i5++)
      	{
      		if(other.registries[i5] == null)
      		{
      			registries.Add(null);
      		}
      		else
      		{
      			test.FooYoRegistryDefinition newElement = test.FooYoRegistryDefinitionPubSubType.Create();
      	   		test.FooYoRegistryDefinitionPubSubType.Copy(other.registries[i5], newElement);
      	   		registries.Add(newElement);
      		}	}
      }

      if(other.variables == null)
      {
      	variables = null;
      }
      else
      {
      	variables = new System.Collections.Generic.List<test.FooYoVariableDefinition>(other.variables.Count);
      	for(int i6 = 0; i6 < other.variables.Count; i6++)
      	{
      		if(other.variables[i6] == null)
      		{
      			variables.Add(null);
      		}
      		else
      		{
      			test.FooYoVariableDefinition newElement = test.FooYoVariableDefinitionPubSubType.Create();
      	   		test.FooYoVariableDefinitionPubSubType.Copy(other.variables[i6], newElement);
      	   		variables.Add(newElement);
      		}	}
      }

      if(other.joints == null)
      {
      	joints = null;
      }
      else
      {
      	joints = new System.Collections.Generic.List<test.FooJointDefinition>(other.joints.Count);
      	for(int i7 = 0; i7 < other.joints.Count; i7++)
      	{
      		if(other.joints[i7] == null)
      		{
      			joints.Add(null);
      		}
      		else
      		{
      			test.FooJointDefinition newElement = test.FooJointDefinitionPubSubType.Create();
      	   		test.FooJointDefinitionPubSubType.Copy(other.joints[i7], newElement);
      	   		joints.Add(newElement);
      		}	}
      }

      if(other.graphicObjects == null)
      {
      	graphicObjects = null;
      }
      else
      {
      	graphicObjects = new System.Collections.Generic.List<test.FooGraphicObjectMessage>(other.graphicObjects.Count);
      	for(int i8 = 0; i8 < other.graphicObjects.Count; i8++)
      	{
      		if(other.graphicObjects[i8] == null)
      		{
      			graphicObjects.Add(null);
      		}
      		else
      		{
      			test.FooGraphicObjectMessage newElement = test.FooGraphicObjectMessagePubSubType.Create();
      	   		test.FooGraphicObjectMessagePubSubType.Copy(other.graphicObjects[i8], newElement);
      	   		graphicObjects.Add(newElement);
      		}	}
      }

      if(other.artifacts == null)
      {
      	artifacts = null;
      }
      else
      {
      	artifacts = new System.Collections.Generic.List<test.FooGraphicObjectMessage>(other.artifacts.Count);
      	for(int i9 = 0; i9 < other.artifacts.Count; i9++)
      	{
      		if(other.artifacts[i9] == null)
      		{
      			artifacts.Add(null);
      		}
      		else
      		{
      			test.FooGraphicObjectMessage newElement = test.FooGraphicObjectMessagePubSubType.Create();
      	   		test.FooGraphicObjectMessagePubSubType.Copy(other.artifacts[i9], newElement);
      	   		artifacts.Add(newElement);
      		}	}
      }

      if(other.enumTypes == null)
      {
      	enumTypes = null;
      }
      else
      {
      	enumTypes = new System.Collections.Generic.List<test.FooEnumType>(other.enumTypes.Count);
      	for(int i10 = 0; i10 < other.enumTypes.Count; i10++)
      	{
      		if(other.enumTypes[i10] == null)
      		{
      			enumTypes.Add(null);
      		}
      		else
      		{
      			test.FooEnumType newElement = test.FooEnumTypePubSubType.Create();
      	   		test.FooEnumTypePubSubType.Copy(other.enumTypes[i10], newElement);
      	   		enumTypes.Add(newElement);
      		}	}
      }
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