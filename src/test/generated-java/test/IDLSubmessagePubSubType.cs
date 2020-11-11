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
public class IDLSubmessagePubSubType : Halodi.TopicDataType<test.IDLSubmessage>
{
   public const string name = "test::IDLSubmessage";


   @Override
   public void serialize(test.IDLSubmessage data, MemoryStream stream) throws java.io.IOException
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   @Override
   public void deserialize(MemoryStream stream, test.IDLSubmessage data) throws java.io.IOException
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(stream);
   	   		read(data, cdr); 
   	   }
   }

   public final static int getCdrSerializedSize(test.IDLSubmessage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.IDLSubmessage data, int current_alignment)
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
      cdr.write_type_11(data.getNum());

      cdr.write_type_11(data.getNoDefaultWithDoc());

      cdr.write_type_11(data.getNoDocNum());

      cdr.write_type_2(data.getHello());

   }

   public static void read(test.IDLSubmessage data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.Num=cdr.read_type_11());
      	
      data.NoDefaultWithDoc=cdr.read_type_11());
      	
      data.NoDocNum=cdr.read_type_11());
      	
      data.Hello=cdr.read_type_2());
      	

   }



   public override string getName()
   {
      return name;
   }
   

}


}