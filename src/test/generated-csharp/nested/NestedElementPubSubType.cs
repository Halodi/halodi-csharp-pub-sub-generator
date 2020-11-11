using System.IO;
namespace nested
{

/**
* 
* Topic data type of the struct "NestedElement" defined in "NestedElement.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from NestedElement.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit NestedElement.idl instead.
*
*/
public class NestedElementPubSubType : Halodi.CDR.TopicDataType<nested.NestedElement>
{
   public override string Name => "nested::NestedElement";


   
   public override void serialize(nested.NestedElement data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, nested.NestedElement data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(nested.NestedElement data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(nested.NestedElement data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.stringTest.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(nested.NestedElement data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_d(data.stringTest);

      cdr.write_type_2(data.longTest);

   }

   public static void read(nested.NestedElement data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.stringTest = cdr.read_type_d();	
      data.longTest=cdr.read_type_2();
      	

   }


    public static void Copy(nested.NestedElement src, nested.NestedElement target)
    {
        target.Set(src);
    }


}


}