namespace test
{

/**
* 
* Topic data type of the struct "FooSummary" defined in "FooHandshake.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from FooHandshake.idl by us.ihmc.idl.generator.IDLGenerator. 
* Do not update this file directly, edit FooHandshake.idl instead.
*
*/
public class FooSummaryPubSubType : Halodi.TopicDataType<test.FooSummary>
{
   public const string name = "test::FooSummary";


   private final us.ihmc.idl.CDR serializeCDR = new us.ihmc.idl.CDR();
   private final us.ihmc.idl.CDR deserializeCDR = new us.ihmc.idl.CDR();

   @Override
   public void serialize(test.FooSummary data, us.ihmc.pubsub.common.SerializedPayload serializedPayload) throws java.io.IOException
   {
      serializeCDR.serialize(serializedPayload);
      write(data, serializeCDR);
      serializeCDR.finishSerialize();
   }

   @Override
   public void deserialize(us.ihmc.pubsub.common.SerializedPayload serializedPayload, test.FooSummary data) throws java.io.IOException
   {
      deserializeCDR.deserialize(serializedPayload);
      read(data, deserializeCDR);
      deserializeCDR.finishDeserialize();
   }

   public final static int getCdrSerializedSize(test.FooSummary data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.FooSummary data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 1 + us.ihmc.idl.CDR.alignment(current_alignment, 1);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4) + data.getSummaryTriggerVariable().length() + 1;

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getSummarizedVariables().size(); ++i0)
      {
          current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4) + data.getSummarizedVariables().get(i0).length() + 1;
      }

      return current_alignment - initial_alignment;
   }

   public static void write(test.FooSummary data, us.ihmc.idl.CDR cdr)
   {
      cdr.write_type_7(data.getCreateSummary());

      cdr.write_type_d(data.getSummaryTriggerVariable());

      cdr.write_type_e(data.getSummarizedVariables());

   }

   public static void read(test.FooSummary data, us.ihmc.idl.CDR cdr)
   {
      data.CreateSummary=cdr.read_type_7());
      	
      cdr.read_type_d(data.getSummaryTriggerVariable());	

      int SummarizedVariables_length = cdr.read_type_2();
      data.SummarizedVariables = new System.Collections.Generic.List<string>(SummarizedVariables_length);
      for(int i = 0; i < SummarizedVariables_length; i++)
      {
      	cdr.read_type_d(data.SummarizedVariables);	
      	
      }
      	

   }


   public override int getTypeSize()
   {
      return us.ihmc.idl.CDR.getTypeSize(getMaxCdrSerializedSize());
   }

   public override string getName()
   {
      return name;
   }
   
   public void serialize(test.FooSummary data, us.ihmc.idl.CDR cdr)
   {
      write(data, cdr);
   }

   public void deserialize(test.FooSummary data, us.ihmc.idl.CDR cdr)
   {
      read(data, cdr);
   }
}


}