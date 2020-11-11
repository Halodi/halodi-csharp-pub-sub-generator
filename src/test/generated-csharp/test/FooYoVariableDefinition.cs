using System.Text;
namespace test
{


[System.Serializable]
public class FooYoVariableDefinition
{
   public string name;
   public string description;
   public test.FooYoType type;
   public ushort registry;
   public ushort enumType;
   public bool allowNullValues;
   public bool isParameter;
   public double min;
   public double max;
   public test.FooLoadStatus loadStatus;


   public void Set(FooYoVariableDefinition other)
   {
      name = other.name;

      description = other.description;

      type = other.type;

      registry = other.registry;

      enumType = other.enumType;

      allowNullValues = other.allowNullValues;

      isParameter = other.isParameter;

      min = other.min;

      max = other.max;

      loadStatus = other.loadStatus;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("FooYoVariableDefinition {");
      builder.Append("name=");
      builder.Append(this.name);      builder.Append(", ");
      builder.Append("description=");
      builder.Append(this.description);      builder.Append(", ");
      builder.Append("type=");
      builder.Append(this.type);      builder.Append(", ");
      builder.Append("registry=");
      builder.Append(this.registry);      builder.Append(", ");
      builder.Append("enumType=");
      builder.Append(this.enumType);      builder.Append(", ");
      builder.Append("allowNullValues=");
      builder.Append(this.allowNullValues);      builder.Append(", ");
      builder.Append("isParameter=");
      builder.Append(this.isParameter);      builder.Append(", ");
      builder.Append("min=");
      builder.Append(this.min);      builder.Append(", ");
      builder.Append("max=");
      builder.Append(this.max);      builder.Append(", ");
      builder.Append("loadStatus=");
      builder.Append(this.loadStatus);
      builder.Append("}");
      return builder.ToString();
   }
}


}