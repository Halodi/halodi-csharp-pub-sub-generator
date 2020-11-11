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
public class StatusMessagePubSubType : Halodi.CDR.TopicDataType<test.StatusMessage>
{
   public override string Name => "test::StatusMessage";


   
   public override void serialize(test.StatusMessage data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, test.StatusMessage data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(test.StatusMessage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(test.StatusMessage data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(test.StatusMessage data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_12(data.sequence_id);

      cdr.write_type_7(data.pause);

   }

   public static void read(test.StatusMessage data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.sequence_id=cdr.read_type_12();
      	
      data.pause=cdr.read_type_7();
      	

   }


    public static void Copy(test.StatusMessage src, test.StatusMessage target)
    {
        target.Set(src);
    }


}


}