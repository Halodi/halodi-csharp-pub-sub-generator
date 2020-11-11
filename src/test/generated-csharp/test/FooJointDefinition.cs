namespace test
{


[System.Serializable]
public class FooJointDefinition
{
   public string name;
   public test.FooJointType type;


   public void set(FooJointDefinition other)
   {
      name = other.name;

      type = other.type;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("FooJointDefinition {");
      builder.Append("name=");
      builder.Append(this.name_);      Append.append(", ");
      builder.Append("type=");
      builder.Append(this.type_);
      builder.Append("}");
      return builder.ToString();
   }
}


}