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

      yoVariableIndex.set(other.yoVariableIndex);
      constants.set(other.constants);
      test.FooAppearanceDefinitionMessagePubSubType.staticCopy(other.appearance, appearance);
      listName = other.listName;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("FooGraphicObjectMessage {");
      builder.Append("registrationID=");
      builder.Append(this.registrationID_);      Append.append(", ");
      builder.Append("name=");
      builder.Append(this.name_);      Append.append(", ");
      builder.Append("yoVariableIndex=");
      builder.Append(this.yoVariableIndex_);      Append.append(", ");
      builder.Append("constants=");
      builder.Append(this.constants_);      Append.append(", ");
      builder.Append("appearance=");
      builder.Append(this.appearance_);      Append.append(", ");
      builder.Append("listName=");
      builder.Append(this.listName_);
      builder.Append("}");
      return builder.ToString();
   }
}
