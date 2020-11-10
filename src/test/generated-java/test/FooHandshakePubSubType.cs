namespace test
{

/**
* 
* Topic data type of the struct "FooHandshake" defined in "FooHandshake.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from FooHandshake.idl by us.ihmc.idl.generator.IDLGenerator. 
* Do not update this file directly, edit FooHandshake.idl instead.
*
*/
public class FooHandshakePubSubType : Halodi.TopicDataType<test.FooHandshake>
{
   public const string name = "test::FooHandshake";


   private final us.ihmc.idl.CDR serializeCDR = new us.ihmc.idl.CDR();
   private final us.ihmc.idl.CDR deserializeCDR = new us.ihmc.idl.CDR();

   @Override
   public void serialize(test.FooHandshake data, us.ihmc.pubsub.common.SerializedPayload serializedPayload) throws java.io.IOException
   {
      serializeCDR.serialize(serializedPayload);
      write(data, serializeCDR);
      serializeCDR.finishSerialize();
   }

   @Override
   public void deserialize(us.ihmc.pubsub.common.SerializedPayload serializedPayload, test.FooHandshake data) throws java.io.IOException
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

      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);for(int i0 = 0; i0 < 1024; ++i0)
      {
          current_alignment += test.FooYoRegistryDefinitionPubSubType.getMaxCdrSerializedSize(current_alignment);}
      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);for(int i0 = 0; i0 < 32767; ++i0)
      {
          current_alignment += test.FooYoVariableDefinitionPubSubType.getMaxCdrSerializedSize(current_alignment);}
      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);for(int i0 = 0; i0 < 128; ++i0)
      {
          current_alignment += test.FooJointDefinitionPubSubType.getMaxCdrSerializedSize(current_alignment);}
      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);for(int i0 = 0; i0 < 2048; ++i0)
      {
          current_alignment += test.FooGraphicObjectMessagePubSubType.getMaxCdrSerializedSize(current_alignment);}
      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);for(int i0 = 0; i0 < 2048; ++i0)
      {
          current_alignment += test.FooGraphicObjectMessagePubSubType.getMaxCdrSerializedSize(current_alignment);}
      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);for(int i0 = 0; i0 < 1024; ++i0)
      {
          current_alignment += test.FooEnumTypePubSubType.getMaxCdrSerializedSize(current_alignment);}
      current_alignment += test.FooSummaryPubSubType.getMaxCdrSerializedSize(current_alignment);


      return current_alignment - initial_alignment;
   }

   public final static int getCdrSerializedSize(test.FooHandshake data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.FooHandshake data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getRegistries().size(); ++i0)
      {
          current_alignment += test.FooYoRegistryDefinitionPubSubType.getCdrSerializedSize(data.getRegistries().get(i0), current_alignment);}

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getVariables().size(); ++i0)
      {
          current_alignment += test.FooYoVariableDefinitionPubSubType.getCdrSerializedSize(data.getVariables().get(i0), current_alignment);}

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getJoints().size(); ++i0)
      {
          current_alignment += test.FooJointDefinitionPubSubType.getCdrSerializedSize(data.getJoints().get(i0), current_alignment);}

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getGraphicObjects().size(); ++i0)
      {
          current_alignment += test.FooGraphicObjectMessagePubSubType.getCdrSerializedSize(data.getGraphicObjects().get(i0), current_alignment);}

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getArtifacts().size(); ++i0)
      {
          current_alignment += test.FooGraphicObjectMessagePubSubType.getCdrSerializedSize(data.getArtifacts().get(i0), current_alignment);}

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getEnumTypes().size(); ++i0)
      {
          current_alignment += test.FooEnumTypePubSubType.getCdrSerializedSize(data.getEnumTypes().get(i0), current_alignment);}

      current_alignment += test.FooSummaryPubSubType.getCdrSerializedSize(data.getSummary(), current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(test.FooHandshake data, us.ihmc.idl.CDR cdr)
   {
      cdr.write_type_6(data.getDt());

      if(data.getRegistries().size() <= 1024)
      cdr.write_type_e(data.getRegistries());else
          throw new RuntimeException("registries field exceeds the maximum length");

      if(data.getVariables().size() <= 32767)
      cdr.write_type_e(data.getVariables());else
          throw new RuntimeException("variables field exceeds the maximum length");

      if(data.getJoints().size() <= 128)
      cdr.write_type_e(data.getJoints());else
          throw new RuntimeException("joints field exceeds the maximum length");

      if(data.getGraphicObjects().size() <= 2048)
      cdr.write_type_e(data.getGraphicObjects());else
          throw new RuntimeException("graphicObjects field exceeds the maximum length");

      if(data.getArtifacts().size() <= 2048)
      cdr.write_type_e(data.getArtifacts());else
          throw new RuntimeException("artifacts field exceeds the maximum length");

      if(data.getEnumTypes().size() <= 1024)
      cdr.write_type_e(data.getEnumTypes());else
          throw new RuntimeException("enumTypes field exceeds the maximum length");

      test.FooSummaryPubSubType.write(data.getSummary(), cdr);
   }

   public static void read(test.FooHandshake data, us.ihmc.idl.CDR cdr)
   {
      data.setDt(cdr.read_type_6());
      	
      cdr.read_type_e(data.getRegistries());	
      cdr.read_type_e(data.getVariables());	
      cdr.read_type_e(data.getJoints());	
      cdr.read_type_e(data.getGraphicObjects());	
      cdr.read_type_e(data.getArtifacts());	
      cdr.read_type_e(data.getEnumTypes());	
      test.FooSummaryPubSubType.read(data.getSummary(), cdr);	

   }

   @Override
   public final void serialize(test.FooHandshake data, us.ihmc.idl.InterchangeSerializer ser)
   {
      ser.write_type_6("dt", data.getDt());
      ser.write_type_e("registries", data.getRegistries());
      ser.write_type_e("variables", data.getVariables());
      ser.write_type_e("joints", data.getJoints());
      ser.write_type_e("graphicObjects", data.getGraphicObjects());
      ser.write_type_e("artifacts", data.getArtifacts());
      ser.write_type_e("enumTypes", data.getEnumTypes());
      ser.write_type_a("summary", new test.FooSummaryPubSubType(), data.getSummary());

   }

   @Override
   public final void deserialize(us.ihmc.idl.InterchangeSerializer ser, test.FooHandshake data)
   {
      data.setDt(ser.read_type_6("dt"));
      ser.read_type_e("registries", data.getRegistries());
      ser.read_type_e("variables", data.getVariables());
      ser.read_type_e("joints", data.getJoints());
      ser.read_type_e("graphicObjects", data.getGraphicObjects());
      ser.read_type_e("artifacts", data.getArtifacts());
      ser.read_type_e("enumTypes", data.getEnumTypes());
      ser.read_type_a("summary", new test.FooSummaryPubSubType(), data.getSummary());

   }

   public static void staticCopy(test.FooHandshake src, test.FooHandshake dest)
   {
      dest.set(src);
   }

   @Override
   public test.FooHandshake createData()
   {
      return new test.FooHandshake();
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
   
   public void serialize(test.FooHandshake data, us.ihmc.idl.CDR cdr)
   {
      write(data, cdr);
   }

   public void deserialize(test.FooHandshake data, us.ihmc.idl.CDR cdr)
   {
      read(data, cdr);
   }
   
   public void copy(test.FooHandshake src, test.FooHandshake dest)
   {
      staticCopy(src, dest);
   }

   @Override
   public FooHandshakePubSubType newInstance()
   {
      return new FooHandshakePubSubType();
   }
}


}