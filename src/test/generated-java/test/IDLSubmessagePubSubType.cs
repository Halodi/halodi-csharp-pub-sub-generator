namespace test
{

/**
* 
* Topic data type of the struct "IDLSubmessage" defined in "IDLSubmessage.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from IDLSubmessage.idl by us.ihmc.idl.generator.IDLGenerator. 
* Do not update this file directly, edit IDLSubmessage.idl instead.
*
*/
public class IDLSubmessagePubSubType : Halodi.TopicDataType<test.IDLSubmessage>
{
   public const string name = "test::IDLSubmessage";


   private final us.ihmc.idl.CDR serializeCDR = new us.ihmc.idl.CDR();
   private final us.ihmc.idl.CDR deserializeCDR = new us.ihmc.idl.CDR();

   @Override
   public void serialize(test.IDLSubmessage data, us.ihmc.pubsub.common.SerializedPayload serializedPayload) throws java.io.IOException
   {
      serializeCDR.serialize(serializedPayload);
      write(data, serializeCDR);
      serializeCDR.finishSerialize();
   }

   @Override
   public void deserialize(us.ihmc.pubsub.common.SerializedPayload serializedPayload, test.IDLSubmessage data) throws java.io.IOException
   {
      deserializeCDR.deserialize(serializedPayload);
      read(data, deserializeCDR);
      deserializeCDR.finishDeserialize();
   }

   public final static int getCdrSerializedSize(test.IDLSubmessage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.IDLSubmessage data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(test.IDLSubmessage data, us.ihmc.idl.CDR cdr)
   {
      cdr.write_type_11(data.getNum());

      cdr.write_type_11(data.getNoDefaultWithDoc());

      cdr.write_type_11(data.getNoDocNum());

      cdr.write_type_2(data.getHello());

   }

   public static void read(test.IDLSubmessage data, us.ihmc.idl.CDR cdr)
   {
      data.Num=cdr.read_type_11());
      	
      data.NoDefaultWithDoc=cdr.read_type_11());
      	
      data.NoDocNum=cdr.read_type_11());
      	
      data.Hello=cdr.read_type_2());
      	

   }


   public override int getTypeSize()
   {
      return us.ihmc.idl.CDR.getTypeSize(getMaxCdrSerializedSize());
   }

   public override string getName()
   {
      return name;
   }
   
   public void serialize(test.IDLSubmessage data, us.ihmc.idl.CDR cdr)
   {
      write(data, cdr);
   }

   public void deserialize(test.IDLSubmessage data, us.ihmc.idl.CDR cdr)
   {
      read(data, cdr);
   }
}


}