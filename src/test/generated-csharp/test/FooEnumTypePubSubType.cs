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
public class FooEnumTypePubSubType : Halodi.CDR.TopicDataType<test.FooEnumType>
{
   public const string name = "test::FooEnumType";


   
   public override void serialize(test.FooEnumType data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, test.FooEnumType data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(test.FooEnumType data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(test.FooEnumType data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.name.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.enumValues.Count; ++i0)
      {
          current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.enumValues[i0].Length + 1;
      }

      return current_alignment - initial_alignment;
   }

   public static void write(test.FooEnumType data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_d(data.name);


      	int enumValues_length = data.enumValues.Count;
            cdr.write_type_2(enumValues_length);
            for (int i0 = 0; i0 < enumValues_length; i0++)
            {
      			cdr.write_type_d(data.enumValues[i0]);
            }
   }

   public static void read(test.FooEnumType data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.name = cdr.read_type_d();	

      int enumValues_length = cdr.read_type_2();
      data.enumValues = new System.Collections.Generic.List<string>(enumValues_length);
      for(int i = 0; i < enumValues_length; i++)
      {
      	data.enumValues.Add(cdr.read_type_d());	
      	
      }

      	

   }



   public override string getName()
   {
      return name;
   }
   

}


}