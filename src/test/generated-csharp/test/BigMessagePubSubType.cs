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
public class BigMessagePubSubType : Halodi.CDR.TopicDataType<test.BigMessage>
{
   public const string name = "test::BigMessage";


   
   public override void serialize(test.BigMessage data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, test.BigMessage data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(test.BigMessage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(test.BigMessage data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.largeSequence.Count; ++i0)
      {
          current_alignment += test.IDLSubmessagePubSubType.getCdrSerializedSize(data.largeSequence[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(test.BigMessage data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_2(data.id);


      	int largeSequence_length = data.largeSequence.Count;
            cdr.write_type_2(largeSequence_length);
            for (int i0 = 0; i0 < largeSequence_length; i0++)
            {
      			test.IDLSubmessagePubSubType.write(data.largeSequence[i0], cdr);	      }
   }

   public static void read(test.BigMessage data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.id=cdr.read_type_2();
      	

      int largeSequence_length = cdr.read_type_2();
      data.largeSequence = new System.Collections.Generic.List<test.IDLSubmessage>(largeSequence_length);
      for(int i = 0; i < largeSequence_length; i++)
      {
      	test.IDLSubmessagePubSubType.read(data.largeSequence, cdr);	
      	
      }

      	

   }



   public override string getName()
   {
      return name;
   }
   

}


}