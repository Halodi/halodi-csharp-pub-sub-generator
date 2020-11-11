using System.Text;
namespace test
{


[System.Serializable]
public class FooGraphicObjectMessage
{
   public int registrationID;
   public string name;
   public System.Collections.Generic.List<ushort> yoVariableIndex;
   public System.Collections.Generic.List<double> constants;
   public test.FooAppearanceDefinitionMessage appearance;
   public string listName;


   public void set(FooGraphicObjectMessage other)
   {
      registrationID = other.registrationID;

      name = other.name;



      yoVariableIndex = new System.Collections.Generic.List<ushort>(other.yoVariableIndex.Count);
      for(int i1 = 0; i1 < other.yoVariableIndex.Count; i1++)
      {
         yoVariableIndex.Add(other.yoVariableIndex[i1]);
      }


      constants = new System.Collections.Generic.List<double>(other.constants.Count);
      for(int i2 = 0; i2 < other.constants.Count; i2++)
      {
         constants.Add(other.constants[i2]);
      }
      test.FooAppearanceDefinitionMessagePubSubType.Copy(other.appearance, appearance);

      listName = other.listName;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("FooGraphicObjectMessage {");
      builder.Append("registrationID=");
      builder.Append(this.registrationID);      builder.Append(", ");
      builder.Append("name=");
      builder.Append(this.name);      builder.Append(", ");
      builder.Append("yoVariableIndex=");
      builder.Append(this.yoVariableIndex);      builder.Append(", ");
      builder.Append("constants=");
      builder.Append(this.constants);      builder.Append(", ");
      builder.Append("appearance=");
      builder.Append(this.appearance);      builder.Append(", ");
      builder.Append("listName=");
      builder.Append(this.listName);
      builder.Append("}");
      return builder.ToString();
   }
}


}