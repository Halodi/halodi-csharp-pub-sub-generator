using System.IO;
namespace test
{

/**
* 
* Topic data type of the struct "FooSummary" defined in "FooHandshake.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from FooHandshake.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit FooHandshake.idl instead.
*
*/
public class FooSummaryPubSubType : Halodi.TopicDataType<test.FooSummary>
{
   public const string name = "test::FooSummary";


   @Override
   public void serialize(test.FooSummary data, MemoryStream stream) throws java.io.IOException
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   @Override
   public void deserialize(MemoryStream stream, test.FooSummary data) throws java.io.IOException
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(stream);
   	   		read(data, cdr); 
   	   }
   }

   public final static int getCdrSerializedSize(test.FooSummary data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.FooSummary data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.getSummaryTriggerVariable().length() + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getSummarizedVariables().size(); ++i0)
      {
          current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.getSummarizedVariables().get(i0).length() + 1;
      }

      return current_alignment - initial_alignment;
   }

   public static void write(test.FooSummary data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_7(data.getCreateSummary());

      cdr.write_type_d(data.getSummaryTriggerVariable());

      cdr.write_type_e(data.getSummarizedVariables());

   }

   public static void read(test.FooSummary data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.CreateSummary=cdr.read_type_7());
      	
      cdr.read_type_d(data.getSummaryTriggerVariable());	

      int SummarizedVariables_length = cdr.read_type_2();
      data.SummarizedVariables = new System.Collections.Generic.List<string>(SummarizedVariables_length);
      for(int i = 0; i < SummarizedVariables_length; i++)
      {
      	data.SummarizedVariables.Add(cdr.read_type_d());	
      	
      }
      	

   }



   public override string getName()
   {
      return name;
   }
   

}


}