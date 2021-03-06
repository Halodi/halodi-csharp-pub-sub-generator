using System.Text;
namespace test
{


[System.Serializable]
public class FooJointDefinition
{
   public string name;
   public test.FooJointType type;


   public void Set(FooJointDefinition other)
   {
      name = other.name;

      type = other.type;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("FooJointDefinition {");
      builder.Append("name=");
      builder.Append(this.name);      builder.Append(", ");
      builder.Append("type=");
      builder.Append(this.type);
      builder.Append("}");
      return builder.ToString();
   }
}


}