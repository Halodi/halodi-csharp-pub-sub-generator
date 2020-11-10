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


   public void set(FooYoVariableDefinition other)
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
      builder.Append(this.name_);      Append.append(", ");
      builder.Append("description=");
      builder.Append(this.description_);      Append.append(", ");
      builder.Append("type=");
      builder.Append(this.type_);      Append.append(", ");
      builder.Append("registry=");
      builder.Append(this.registry_);      Append.append(", ");
      builder.Append("enumType=");
      builder.Append(this.enumType_);      Append.append(", ");
      builder.Append("allowNullValues=");
      builder.Append(this.allowNullValues_);      Append.append(", ");
      builder.Append("isParameter=");
      builder.Append(this.isParameter_);      Append.append(", ");
      builder.Append("min=");
      builder.Append(this.min_);      Append.append(", ");
      builder.Append("max=");
      builder.Append(this.max_);      Append.append(", ");
      builder.Append("loadStatus=");
      builder.Append(this.loadStatus_);
      builder.Append("}");
      return builder.ToString();
   }
}


}