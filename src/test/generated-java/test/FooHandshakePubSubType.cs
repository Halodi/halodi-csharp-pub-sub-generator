using System.IO;
namespace test
{

/**
* 
* Topic data type of the struct "FooHandshake" defined in "FooHandshake.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from FooHandshake.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit FooHandshake.idl instead.
*
*/
public class FooHandshakePubSubType : Halodi.TopicDataType<test.FooHandshake>
{
   public const string name = "test::FooHandshake";


   @Override
   public void serialize(test.FooHandshake data, MemoryStream stream) throws java.io.IOException
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   @Override
   public void deserialize(MemoryStream stream, test.FooHandshake data) throws java.io.IOException
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(stream);
   	   		read(data, cdr); 
   	   }
   }

   public final static int getCdrSerializedSize(test.FooHandshake data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.FooHandshake data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getRegistries().size(); ++i0)
      {
          current_alignment += test.FooYoRegistryDefinitionPubSubType.getCdrSerializedSize(data.getRegistries().get(i0), current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getVariables().size(); ++i0)
      {
          current_alignment += test.FooYoVariableDefinitionPubSubType.getCdrSerializedSize(data.getVariables().get(i0), current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getJoints().size(); ++i0)
      {
          current_alignment += test.FooJointDefinitionPubSubType.getCdrSerializedSize(data.getJoints().get(i0), current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getGraphicObjects().size(); ++i0)
      {
          current_alignment += test.FooGraphicObjectMessagePubSubType.getCdrSerializedSize(data.getGraphicObjects().get(i0), current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getArtifacts().size(); ++i0)
      {
          current_alignment += test.FooGraphicObjectMessagePubSubType.getCdrSerializedSize(data.getArtifacts().get(i0), current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getEnumTypes().size(); ++i0)
      {
          current_alignment += test.FooEnumTypePubSubType.getCdrSerializedSize(data.getEnumTypes().get(i0), current_alignment);}

      current_alignment += test.FooSummaryPubSubType.getCdrSerializedSize(data.getSummary(), current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(test.FooHandshake data, Halodi.CDR.CDRSerializer cdr)
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

   public static void read(test.FooHandshake data, Halodi.CDR.CDRDeserializer cdr)
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



   public override string getName()
   {
      return name;
   }
   

}


}