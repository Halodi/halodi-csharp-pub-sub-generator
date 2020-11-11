using System.IO;
namespace test
{

/**
* 
* Topic data type of the struct "BigMessage" defined in "BigMessage.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from BigMessage.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit BigMessage.idl instead.
*
*/
public class BigMessagePubSubType : Halodi.TopicDataType<test.BigMessage>
{
   public const string name = "test::BigMessage";


   @Override
   public void serialize(test.BigMessage data, MemoryStream stream) throws java.io.IOException
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   @Override
   public void deserialize(MemoryStream stream, test.BigMessage data) throws java.io.IOException
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(stream);
   	   		read(data, cdr); 
   	   }
   }

   public final static int getCdrSerializedSize(test.BigMessage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.BigMessage data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getLargeSequence().size(); ++i0)
      {
          current_alignment += test.IDLSubmessagePubSubType.getCdrSerializedSize(data.getLargeSequence().get(i0), current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(test.BigMessage data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_2(data.getId());

      cdr.write_type_e(data.getLargeSequence());

   }

   public static void read(test.BigMessage data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.Id=cdr.read_type_2());
      	

      int LargeSequence_length = cdr.read_type_2();
      data.LargeSequence = new System.Collections.Generic.List<test.IDLSubmessage>(LargeSequence_length);
      for(int i = 0; i < LargeSequence_length; i++)
      {
      	test.IDLSubmessagePubSubType.read(data.LargeSequence, cdr);	
      	
      }
      	

   }



   public override string getName()
   {
      return name;
   }
   

}


}