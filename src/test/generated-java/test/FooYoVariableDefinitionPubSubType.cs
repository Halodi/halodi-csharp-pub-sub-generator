namespace test
{

/**
* 
* Topic data type of the struct "FooYoVariableDefinition" defined in "FooHandshake.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from FooHandshake.idl by us.ihmc.idl.generator.IDLGenerator. 
* Do not update this file directly, edit FooHandshake.idl instead.
*
*/
public class FooYoVariableDefinitionPubSubType : Halodi.TopicDataType<test.FooYoVariableDefinition>
{
   public const string name = "test::FooYoVariableDefinition";


   private final us.ihmc.idl.CDR serializeCDR = new us.ihmc.idl.CDR();
   private final us.ihmc.idl.CDR deserializeCDR = new us.ihmc.idl.CDR();

   @Override
   public void serialize(test.FooYoVariableDefinition data, us.ihmc.pubsub.common.SerializedPayload serializedPayload) throws java.io.IOException
   {
      serializeCDR.serialize(serializedPayload);
      write(data, serializeCDR);
      serializeCDR.finishSerialize();
   }

   @Override
   public void deserialize(us.ihmc.pubsub.common.SerializedPayload serializedPayload, test.FooYoVariableDefinition data) throws java.io.IOException
   {
      deserializeCDR.deserialize(serializedPayload);
      read(data, deserializeCDR);
      deserializeCDR.finishDeserialize();
   }

   public final static int getCdrSerializedSize(test.FooYoVariableDefinition data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.FooYoVariableDefinition data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4) + data.getName().length() + 1;

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4) + data.getDescription().length() + 1;

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);


      current_alignment += 2 + us.ihmc.idl.CDR.alignment(current_alignment, 2);


      current_alignment += 2 + us.ihmc.idl.CDR.alignment(current_alignment, 2);


      current_alignment += 1 + us.ihmc.idl.CDR.alignment(current_alignment, 1);


      current_alignment += 1 + us.ihmc.idl.CDR.alignment(current_alignment, 1);


      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(test.FooYoVariableDefinition data, us.ihmc.idl.CDR cdr)
   {
      cdr.write_type_d(data.getName());

      cdr.write_type_d(data.getDescription());

      cdr.write_type_c(data.getType().ordinal());


      cdr.write_type_3(data.getRegistry());

      cdr.write_type_3(data.getEnumType());

      cdr.write_type_7(data.getAllowNullValues());

      cdr.write_type_7(data.getIsParameter());

      cdr.write_type_6(data.getMin());

      cdr.write_type_6(data.getMax());

      cdr.write_type_c(data.getLoadStatus().ordinal());


   }

   public static void read(test.FooYoVariableDefinition data, us.ihmc.idl.CDR cdr)
   {
      cdr.read_type_d(data.getName());	
      cdr.read_type_d(data.getDescription());	
      data.Type = (test.FooYoType) cdr.read_type_c();
      	
      data.Registry=cdr.read_type_3());
      	
      data.EnumType=cdr.read_type_3());
      	
      data.AllowNullValues=cdr.read_type_7());
      	
      data.IsParameter=cdr.read_type_7());
      	
      data.Min=cdr.read_type_6());
      	
      data.Max=cdr.read_type_6());
      	
      data.LoadStatus = (test.FooLoadStatus) cdr.read_type_c();
      	

   }



   public override string getName()
   {
      return name;
   }
   
   public void serialize(test.FooYoVariableDefinition data, us.ihmc.idl.CDR cdr)
   {
      write(data, cdr);
   }

   public void deserialize(test.FooYoVariableDefinition data, us.ihmc.idl.CDR cdr)
   {
      read(data, cdr);
   }
}


}