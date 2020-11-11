using System.IO;
namespace test
{

/**
* 
* Topic data type of the struct "FooEnumType" defined in "FooHandshake.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from FooHandshake.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit FooHandshake.idl instead.
*
*/
public class FooEnumTypePubSubType : Halodi.TopicDataType<test.FooEnumType>
{
   public const string name = "test::FooEnumType";


   @Override
   public void serialize(test.FooEnumType data, MemoryStream stream) throws java.io.IOException
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   @Override
   public void deserialize(MemoryStream stream, test.FooEnumType data) throws java.io.IOException
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(stream);
   	   		read(data, cdr); 
   	   }
   }

   public final static int getCdrSerializedSize(test.FooEnumType data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.FooEnumType data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.getName().length() + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getEnumValues().size(); ++i0)
      {
          current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.getEnumValues().get(i0).length() + 1;
      }

      return current_alignment - initial_alignment;
   }

   public static void write(test.FooEnumType data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_d(data.getName());

      cdr.write_type_e(data.getEnumValues());

   }

   public static void read(test.FooEnumType data, Halodi.CDR.CDRDeserializer cdr)
   {
      cdr.read_type_d(data.getName());	

      int EnumValues_length = cdr.read_type_2();
      data.EnumValues = new System.Collections.Generic.List<string>(EnumValues_length);
      for(int i = 0; i < EnumValues_length; i++)
      {
      	data.EnumValues.Add(cdr.read_type_d());	
      	
      }
      	

   }



   public override string getName()
   {
      return name;
   }
   

}


}