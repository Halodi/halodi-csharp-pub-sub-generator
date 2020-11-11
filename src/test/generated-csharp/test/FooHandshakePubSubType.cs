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
public class FooHandshakePubSubType : Halodi.CDR.TopicDataType<test.FooHandshake>
{
   public const string name = "test::FooHandshake";


   
   public override void serialize(test.FooHandshake data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, test.FooHandshake data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(stream);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(test.FooHandshake data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(test.FooHandshake data, int current_alignment)
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
      cdr.write_type_6(data.dt);

      cdr.write_type_e(data.registries);

      cdr.write_type_e(data.variables);

      cdr.write_type_e(data.joints);

      cdr.write_type_e(data.graphicObjects);

      cdr.write_type_e(data.artifacts);

      cdr.write_type_e(data.enumTypes);

      test.FooSummaryPubSubType.write(data.summary, cdr);
   }

   public static void read(test.FooHandshake data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.dt=cdr.read_type_6();
      	

      int registries_length = cdr.read_type_2();
      data.registries = new System.Collections.Generic.List<test.FooYoRegistryDefinition>(registries_length);
      for(int i = 0; i < registries_length; i++)
      {
      	test.FooYoRegistryDefinitionPubSubType.read(data.registries, cdr);	
      	
      }
      	

      int variables_length = cdr.read_type_2();
      data.variables = new System.Collections.Generic.List<test.FooYoVariableDefinition>(variables_length);
      for(int i = 0; i < variables_length; i++)
      {
      	test.FooYoVariableDefinitionPubSubType.read(data.variables, cdr);	
      	
      }
      	

      int joints_length = cdr.read_type_2();
      data.joints = new System.Collections.Generic.List<test.FooJointDefinition>(joints_length);
      for(int i = 0; i < joints_length; i++)
      {
      	test.FooJointDefinitionPubSubType.read(data.joints, cdr);	
      	
      }
      	

      int graphicObjects_length = cdr.read_type_2();
      data.graphicObjects = new System.Collections.Generic.List<test.FooGraphicObjectMessage>(graphicObjects_length);
      for(int i = 0; i < graphicObjects_length; i++)
      {
      	test.FooGraphicObjectMessagePubSubType.read(data.graphicObjects, cdr);	
      	
      }
      	

      int artifacts_length = cdr.read_type_2();
      data.artifacts = new System.Collections.Generic.List<test.FooGraphicObjectMessage>(artifacts_length);
      for(int i = 0; i < artifacts_length; i++)
      {
      	test.FooGraphicObjectMessagePubSubType.read(data.artifacts, cdr);	
      	
      }
      	

      int enumTypes_length = cdr.read_type_2();
      data.enumTypes = new System.Collections.Generic.List<test.FooEnumType>(enumTypes_length);
      for(int i = 0; i < enumTypes_length; i++)
      {
      	test.FooEnumTypePubSubType.read(data.enumTypes, cdr);	
      	
      }
      	
      test.FooSummaryPubSubType.read(data.summary, cdr);
      	

   }



   public override string getName()
   {
      return name;
   }
   

}


}