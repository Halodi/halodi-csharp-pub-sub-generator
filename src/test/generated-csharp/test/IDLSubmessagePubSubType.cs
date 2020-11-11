using System.IO;
namespace test
{

/**
* 
* Topic data type of the struct "IDLSubmessage" defined in "IDLSubmessage.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from IDLSubmessage.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit IDLSubmessage.idl instead.
*
*/
public class IDLSubmessagePubSubType : Halodi.CDR.TopicDataType<test.IDLSubmessage>
{
   public const string name = "test::IDLSubmessage";


   
   public override void serialize(test.IDLSubmessage data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, test.IDLSubmessage data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(stream);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(test.IDLSubmessage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(test.IDLSubmessage data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(test.IDLSubmessage data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_11(data.num);

      cdr.write_type_11(data.no_default_with_doc);

      cdr.write_type_11(data.no_doc_num);

      cdr.write_type_2(data.hello);

   }

   public static void read(test.IDLSubmessage data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.num=cdr.read_type_11();
      	
      data.no_default_with_doc=cdr.read_type_11();
      	
      data.no_doc_num=cdr.read_type_11();
      	
      data.hello=cdr.read_type_2();
      	

   }



   public override string getName()
   {
      return name;
   }
   

}


}