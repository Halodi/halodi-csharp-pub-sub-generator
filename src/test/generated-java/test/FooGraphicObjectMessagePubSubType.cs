namespace test
{

/**
* 
* Topic data type of the struct "FooGraphicObjectMessage" defined in "FooHandshake.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from FooHandshake.idl by us.ihmc.idl.generator.IDLGenerator. 
* Do not update this file directly, edit FooHandshake.idl instead.
*
*/
public class FooGraphicObjectMessagePubSubType : Halodi.TopicDataType<test.FooGraphicObjectMessage>
{
   public const string name = "test::FooGraphicObjectMessage";


   private final us.ihmc.idl.CDR serializeCDR = new us.ihmc.idl.CDR();
   private final us.ihmc.idl.CDR deserializeCDR = new us.ihmc.idl.CDR();

   @Override
   public void serialize(test.FooGraphicObjectMessage data, us.ihmc.pubsub.common.SerializedPayload serializedPayload) throws java.io.IOException
   {
      serializeCDR.serialize(serializedPayload);
      write(data, serializeCDR);
      serializeCDR.finishSerialize();
   }

   @Override
   public void deserialize(us.ihmc.pubsub.common.SerializedPayload serializedPayload, test.FooGraphicObjectMessage data) throws java.io.IOException
   {
      deserializeCDR.deserialize(serializedPayload);
      read(data, deserializeCDR);
      deserializeCDR.finishDeserialize();
   }

   public static int getMaxCdrSerializedSize()
   {
      return getMaxCdrSerializedSize(0);
   }

   public static int getMaxCdrSerializedSize(int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4) + 255 + 1;
      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);current_alignment += (1024 * 2) + us.ihmc.idl.CDR.alignment(current_alignment, 2);

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);current_alignment += (128 * 8) + us.ihmc.idl.CDR.alignment(current_alignment, 8);

      current_alignment += test.FooAppearanceDefinitionMessagePubSubType.getMaxCdrSerializedSize(current_alignment);

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4) + 255 + 1;

      return current_alignment - initial_alignment;
   }

   public final static int getCdrSerializedSize(test.FooGraphicObjectMessage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.FooGraphicObjectMessage data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4) + data.getName().length() + 1;

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      current_alignment += (data.getYoVariableIndex().size() * 2) + us.ihmc.idl.CDR.alignment(current_alignment, 2);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      current_alignment += (data.getConstants().size() * 8) + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      current_alignment += test.FooAppearanceDefinitionMessagePubSubType.getCdrSerializedSize(data.getAppearance(), current_alignment);

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4) + data.getListName().length() + 1;


      return current_alignment - initial_alignment;
   }

   public static void write(test.FooGraphicObjectMessage data, us.ihmc.idl.CDR cdr)
   {
      cdr.write_type_2(data.getRegistrationID());

      if(data.getName().length() <= 255)
      cdr.write_type_d(data.getName());else
          throw new RuntimeException("name field exceeds the maximum length");

      if(data.getYoVariableIndex().size() <= 1024)
      cdr.write_type_e(data.getYoVariableIndex());else
          throw new RuntimeException("yoVariableIndex field exceeds the maximum length");

      if(data.getConstants().size() <= 128)
      cdr.write_type_e(data.getConstants());else
          throw new RuntimeException("constants field exceeds the maximum length");

      test.FooAppearanceDefinitionMessagePubSubType.write(data.getAppearance(), cdr);
      if(data.getListName().length() <= 255)
      cdr.write_type_d(data.getListName());else
          throw new RuntimeException("listName field exceeds the maximum length");

   }

   public static void read(test.FooGraphicObjectMessage data, us.ihmc.idl.CDR cdr)
   {
      data.setRegistrationID(cdr.read_type_2());
      	
      cdr.read_type_d(data.getName());	
      cdr.read_type_e(data.getYoVariableIndex());	
      cdr.read_type_e(data.getConstants());	
      test.FooAppearanceDefinitionMessagePubSubType.read(data.getAppearance(), cdr);	
      cdr.read_type_d(data.getListName());	

   }

   @Override
   public final void serialize(test.FooGraphicObjectMessage data, us.ihmc.idl.InterchangeSerializer ser)
   {
      ser.write_type_2("registrationID", data.getRegistrationID());
      ser.write_type_d("name", data.getName());
      ser.write_type_e("yoVariableIndex", data.getYoVariableIndex());
      ser.write_type_e("constants", data.getConstants());
      ser.write_type_a("appearance", new test.FooAppearanceDefinitionMessagePubSubType(), data.getAppearance());

      ser.write_type_d("listName", data.getListName());
   }

   @Override
   public final void deserialize(us.ihmc.idl.InterchangeSerializer ser, test.FooGraphicObjectMessage data)
   {
      data.setRegistrationID(ser.read_type_2("registrationID"));
      ser.read_type_d("name", data.getName());
      ser.read_type_e("yoVariableIndex", data.getYoVariableIndex());
      ser.read_type_e("constants", data.getConstants());
      ser.read_type_a("appearance", new test.FooAppearanceDefinitionMessagePubSubType(), data.getAppearance());

      ser.read_type_d("listName", data.getListName());
   }

   public static void staticCopy(test.FooGraphicObjectMessage src, test.FooGraphicObjectMessage dest)
   {
      dest.set(src);
   }

   @Override
   public test.FooGraphicObjectMessage createData()
   {
      return new test.FooGraphicObjectMessage();
   }

   @Override
   public int getTypeSize()
   {
      return us.ihmc.idl.CDR.getTypeSize(getMaxCdrSerializedSize());
   }

   @Override
   public java.lang.String getName()
   {
      return name;
   }
   
   public void serialize(test.FooGraphicObjectMessage data, us.ihmc.idl.CDR cdr)
   {
      write(data, cdr);
   }

   public void deserialize(test.FooGraphicObjectMessage data, us.ihmc.idl.CDR cdr)
   {
      read(data, cdr);
   }
   
   public void copy(test.FooGraphicObjectMessage src, test.FooGraphicObjectMessage dest)
   {
      staticCopy(src, dest);
   }

   @Override
   public FooGraphicObjectMessagePubSubType newInstance()
   {
      return new FooGraphicObjectMessagePubSubType();
   }
}


}