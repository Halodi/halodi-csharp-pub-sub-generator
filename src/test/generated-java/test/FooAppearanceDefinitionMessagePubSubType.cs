namespace test
{

/**
* 
* Topic data type of the struct "FooAppearanceDefinitionMessage" defined in "FooHandshake.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from FooHandshake.idl by us.ihmc.idl.generator.IDLGenerator. 
* Do not update this file directly, edit FooHandshake.idl instead.
*
*/
public class FooAppearanceDefinitionMessagePubSubType : Halodi.TopicDataType<test.FooAppearanceDefinitionMessage>
{
   public const string name = "test::FooAppearanceDefinitionMessage";


   private final us.ihmc.idl.CDR serializeCDR = new us.ihmc.idl.CDR();
   private final us.ihmc.idl.CDR deserializeCDR = new us.ihmc.idl.CDR();

   @Override
   public void serialize(test.FooAppearanceDefinitionMessage data, us.ihmc.pubsub.common.SerializedPayload serializedPayload) throws java.io.IOException
   {
      serializeCDR.serialize(serializedPayload);
      write(data, serializeCDR);
      serializeCDR.finishSerialize();
   }

   @Override
   public void deserialize(us.ihmc.pubsub.common.SerializedPayload serializedPayload, test.FooAppearanceDefinitionMessage data) throws java.io.IOException
   {
      deserializeCDR.deserialize(serializedPayload);
      read(data, deserializeCDR);
      deserializeCDR.finishDeserialize();
   }

   public final static int getCdrSerializedSize(test.FooAppearanceDefinitionMessage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.FooAppearanceDefinitionMessage data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(test.FooAppearanceDefinitionMessage data, us.ihmc.idl.CDR cdr)
   {
      cdr.write_type_6(data.getR());

      cdr.write_type_6(data.getG());

      cdr.write_type_6(data.getB());

      cdr.write_type_6(data.getTransparency());

   }

   public static void read(test.FooAppearanceDefinitionMessage data, us.ihmc.idl.CDR cdr)
   {
      data.R=cdr.read_type_6());
      	
      data.G=cdr.read_type_6());
      	
      data.B=cdr.read_type_6());
      	
      data.Transparency=cdr.read_type_6());
      	

   }



   public override string getName()
   {
      return name;
   }
   
   public void serialize(test.FooAppearanceDefinitionMessage data, us.ihmc.idl.CDR cdr)
   {
      write(data, cdr);
   }

   public void deserialize(test.FooAppearanceDefinitionMessage data, us.ihmc.idl.CDR cdr)
   {
      read(data, cdr);
   }
}


}