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
public class FooSummaryPubSubType : Halodi.CDR.TopicDataType<test.FooSummary>
{
   public const string name = "test::FooSummary";


   
   public override void serialize(test.FooSummary data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, test.FooSummary data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(stream);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(test.FooSummary data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(test.FooSummary data, int current_alignment)
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
      cdr.write_type_7(data.createSummary);

      cdr.write_type_d(data.summaryTriggerVariable);


      	int summarizedVariables_length = data.summarizedVariables.Count;
            cdr.write_type_2(summarizedVariables_length);
            for (int i0 = 0; i0 < summarizedVariables_length; i0++)
            {
      			cdr.write_type_d(data.summarizedVariables[i0]);
            }
   }

   public static void read(test.FooSummary data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.createSummary=cdr.read_type_7();
      	
      data.summaryTriggerVariable = cdr.read_type_d();	

      int summarizedVariables_length = cdr.read_type_2();
      data.summarizedVariables = new System.Collections.Generic.List<string>(summarizedVariables_length);
      for(int i = 0; i < summarizedVariables_length; i++)
      {
      	data.summarizedVariables.Add(cdr.read_type_d());	
      	
      }

      	

   }



   public override string getName()
   {
      return name;
   }
   

}


}