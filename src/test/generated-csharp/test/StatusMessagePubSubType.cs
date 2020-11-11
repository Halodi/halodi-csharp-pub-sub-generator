using System.IO;
namespace test
{

/**
* 
* Topic data type of the struct "StatusMessage" defined in "StatusMessage.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from StatusMessage.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit StatusMessage.idl instead.
*
*/
public class StatusMessagePubSubType : Halodi.TopicDataType<test.StatusMessage>
{
   public const string name = "test::StatusMessage";


   @Override
   public void serialize(test.StatusMessage data, MemoryStream stream) throws java.io.IOException
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   @Override
   public void deserialize(MemoryStream stream, test.StatusMessage data) throws java.io.IOException
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(stream);
   	   		read(data, cdr); 
   	   }
   }

   public final static int getCdrSerializedSize(test.StatusMessage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.StatusMessage data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(test.StatusMessage data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_12(data.getSequenceId());

      cdr.write_type_7(data.getPause());

   }

   public static void read(test.StatusMessage data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.SequenceId=cdr.read_type_12());
      	
      data.Pause=cdr.read_type_7());
      	

   }



   public override string getName()
   {
      return name;
   }
   

}


}