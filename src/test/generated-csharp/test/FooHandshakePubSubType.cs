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
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
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
      for(int i0 = 0; i0 < data.registries.Count; ++i0)
      {
          current_alignment += test.FooYoRegistryDefinitionPubSubType.getCdrSerializedSize(data.registries[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.variables.Count; ++i0)
      {
          current_alignment += test.FooYoVariableDefinitionPubSubType.getCdrSerializedSize(data.variables[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.joints.Count; ++i0)
      {
          current_alignment += test.FooJointDefinitionPubSubType.getCdrSerializedSize(data.joints[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.graphicObjects.Count; ++i0)
      {
          current_alignment += test.FooGraphicObjectMessagePubSubType.getCdrSerializedSize(data.graphicObjects[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.artifacts.Count; ++i0)
      {
          current_alignment += test.FooGraphicObjectMessagePubSubType.getCdrSerializedSize(data.artifacts[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.enumTypes.Count; ++i0)
      {
          current_alignment += test.FooEnumTypePubSubType.getCdrSerializedSize(data.enumTypes[i0], current_alignment);}

      current_alignment += test.FooSummaryPubSubType.getCdrSerializedSize(data.summary, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(test.FooHandshake data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_6(data.dt);


      	int registries_length = data.registries.Count;
            cdr.write_type_2(registries_length);
            for (int i0 = 0; i0 < registries_length; i0++)
            {
      			test.FooYoRegistryDefinitionPubSubType.write(data.registries[i0], cdr);	      }

      	int variables_length = data.variables.Count;
            cdr.write_type_2(variables_length);
            for (int i0 = 0; i0 < variables_length; i0++)
            {
      			test.FooYoVariableDefinitionPubSubType.write(data.variables[i0], cdr);	      }

      	int joints_length = data.joints.Count;
            cdr.write_type_2(joints_length);
            for (int i0 = 0; i0 < joints_length; i0++)
            {
      			test.FooJointDefinitionPubSubType.write(data.joints[i0], cdr);	      }

      	int graphicObjects_length = data.graphicObjects.Count;
            cdr.write_type_2(graphicObjects_length);
            for (int i0 = 0; i0 < graphicObjects_length; i0++)
            {
      			test.FooGraphicObjectMessagePubSubType.write(data.graphicObjects[i0], cdr);	      }

      	int artifacts_length = data.artifacts.Count;
            cdr.write_type_2(artifacts_length);
            for (int i0 = 0; i0 < artifacts_length; i0++)
            {
      			test.FooGraphicObjectMessagePubSubType.write(data.artifacts[i0], cdr);	      }

      	int enumTypes_length = data.enumTypes.Count;
            cdr.write_type_2(enumTypes_length);
            for (int i0 = 0; i0 < enumTypes_length; i0++)
            {
      			test.FooEnumTypePubSubType.write(data.enumTypes[i0], cdr);	      }
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