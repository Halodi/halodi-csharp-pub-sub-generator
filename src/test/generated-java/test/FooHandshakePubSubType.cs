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

      cdr.write_type_e(data.getRegistries());

      cdr.write_type_e(data.getVariables());

      cdr.write_type_e(data.getJoints());

      cdr.write_type_e(data.getGraphicObjects());

      cdr.write_type_e(data.getArtifacts());

      cdr.write_type_e(data.getEnumTypes());

      test.FooSummaryPubSubType.write(data.getSummary(), cdr);
   }

   public static void read(test.FooHandshake data, us.ihmc.idl.CDR cdr)
   {
      data.Dt=cdr.read_type_6());
      	

      int Registries_length = cdr.read_type_2();
      data.Registries = new System.Collections.Generic.List<test.FooYoRegistryDefinition>(Registries_length);
      for(int i = 0; i < Registries_length; i++)
      {
      	test.FooYoRegistryDefinitionPubSubType.read(data.Registries, cdr);	
      	
      }
      	

      int Variables_length = cdr.read_type_2();
      data.Variables = new System.Collections.Generic.List<test.FooYoVariableDefinition>(Variables_length);
      for(int i = 0; i < Variables_length; i++)
      {
      	test.FooYoVariableDefinitionPubSubType.read(data.Variables, cdr);	
      	
      }
      	

      int Joints_length = cdr.read_type_2();
      data.Joints = new System.Collections.Generic.List<test.FooJointDefinition>(Joints_length);
      for(int i = 0; i < Joints_length; i++)
      {
      	test.FooJointDefinitionPubSubType.read(data.Joints, cdr);	
      	
      }
      	

      int GraphicObjects_length = cdr.read_type_2();
      data.GraphicObjects = new System.Collections.Generic.List<test.FooGraphicObjectMessage>(GraphicObjects_length);
      for(int i = 0; i < GraphicObjects_length; i++)
      {
      	test.FooGraphicObjectMessagePubSubType.read(data.GraphicObjects, cdr);	
      	
      }
      	

      int Artifacts_length = cdr.read_type_2();
      data.Artifacts = new System.Collections.Generic.List<test.FooGraphicObjectMessage>(Artifacts_length);
      for(int i = 0; i < Artifacts_length; i++)
      {
      	test.FooGraphicObjectMessagePubSubType.read(data.Artifacts, cdr);	
      	
      }
      	

      int EnumTypes_length = cdr.read_type_2();
      data.EnumTypes = new System.Collections.Generic.List<test.FooEnumType>(EnumTypes_length);
      for(int i = 0; i < EnumTypes_length; i++)
      {
      	test.FooEnumTypePubSubType.read(data.EnumTypes, cdr);	
      	
      }
      	
      test.FooSummaryPubSubType.read(data.Summary, cdr);
      	

   }


   public override int getTypeSize()
   {
      return us.ihmc.idl.CDR.getTypeSize(getMaxCdrSerializedSize());
   }

   public override string getName()
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
}


}