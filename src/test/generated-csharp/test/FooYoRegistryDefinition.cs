using System.Text;
namespace test
{


[System.Serializable]
public class FooYoRegistryDefinition
{
   public ushort parent;
   public string name;


   public void set(FooYoRegistryDefinition other)
   {
      parent = other.parent;

      name = other.name;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("FooYoRegistryDefinition {");
      builder.Append("parent=");
      builder.Append(this.parent);      builder.Append(", ");
      builder.Append("name=");
      builder.Append(this.name);
      builder.Append("}");
      return builder.ToString();
   }
}


}