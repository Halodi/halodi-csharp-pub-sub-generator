using System.IO;
namespace test
{

/**
* 
* Topic data type of the struct "IDLFeatureMessage" defined in "IDLFeatureMessage.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from IDLFeatureMessage.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit IDLFeatureMessage.idl instead.
*
*/
public class IDLFeatureMessagePubSubType : Halodi.CDR.TopicDataType<test.IDLFeatureMessage>
{
   public override string Name => "test::IDLFeatureMessage";


   
   public override void serialize(test.IDLFeatureMessage data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, test.IDLFeatureMessage data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(test.IDLFeatureMessage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(test.IDLFeatureMessage data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += test.IDLSubmessagePubSubType.getCdrSerializedSize(data.num1, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.num2.Count; ++i0)
      {
          current_alignment += test.IDLSubmessagePubSubType.getCdrSerializedSize(data.num2[i0], current_alignment);}

      for(int i0 = 0; i0 < 3; ++i0)
      {
              current_alignment += test.IDLSubmessagePubSubType.getCdrSerializedSize(data.num3[i0], current_alignment);
      }
      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.num4.Count; ++i0)
      {
          current_alignment += test.IDLSubmessagePubSubType.getCdrSerializedSize(data.num4[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.str1.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.str2.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.str3.Count; ++i0)
      {
          current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.str3[i0].Length + 1;
      }
      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.str4.Count; ++i0)
      {
          current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.str4[i0].Length + 1;
      }
      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.str5.Count; ++i0)
      {
          current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.str5[i0].Length + 1;
      }

      return current_alignment - initial_alignment;
   }

   public static void write(test.IDLFeatureMessage data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_11(data.num);

      cdr.write_type_11(data.no_default_with_doc);

      cdr.write_type_11(data.no_doc_num);

      cdr.write_type_2(data.hello);

      test.IDLSubmessagePubSubType.write(data.num1, cdr);

      	if(data.num2 == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int num2_length = data.num2.Count;
            cdr.write_type_2(num2_length);
            for (int i0 = 0; i0 < num2_length; i0++)
            {
      			test.IDLSubmessagePubSubType.write(data.num2[i0], cdr);	      }
        }
      for(int i0 = 0; i0 < 3; ++i0)
      {
        	test.IDLSubmessagePubSubType.write(data.num3[i0], cdr);		
      }

      	if(data.num4 == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int num4_length = data.num4.Count;
            cdr.write_type_2(num4_length);
            for (int i0 = 0; i0 < num4_length; i0++)
            {
      			test.IDLSubmessagePubSubType.write(data.num4[i0], cdr);	      }
        }
      cdr.write_type_d(data.str1);

      cdr.write_type_d(data.str2);

      	if(data.str3 == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int str3_length = data.str3.Count;
            cdr.write_type_2(str3_length);
            for (int i0 = 0; i0 < str3_length; i0++)
            {
      			cdr.write_type_d(data.str3[i0]);
            }
        }
      	if(data.str4 == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int str4_length = data.str4.Count;
            cdr.write_type_2(str4_length);
            for (int i0 = 0; i0 < str4_length; i0++)
            {
      			cdr.write_type_d(data.str4[i0]);
            }
        }
      	if(data.str5 == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int str5_length = data.str5.Count;
            cdr.write_type_2(str5_length);
            for (int i0 = 0; i0 < str5_length; i0++)
            {
      			cdr.write_type_d(data.str5[i0]);
            }
        }
   }

   public static void read(test.IDLFeatureMessage data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.num=cdr.read_type_11();
      	
      data.no_default_with_doc=cdr.read_type_11();
      	
      data.no_doc_num=cdr.read_type_11();
      	
      data.hello=cdr.read_type_2();
      	
      data.num1 = test.IDLSubmessagePubSubType.Create();
      test.IDLSubmessagePubSubType.read(data.num1, cdr);
      	

      int num2_length = cdr.read_type_2();
      data.num2 = new System.Collections.Generic.List<test.IDLSubmessage>(num2_length);
      for(int i = 0; i < num2_length; i++)
      {
      	test.IDLSubmessage new_num2 = test.IDLSubmessagePubSubType.Create(); 
      	test.IDLSubmessagePubSubType.read(new_num2, cdr);
      	data.num2.Add(new_num2);	
      	
      }

      	
      for(int i0 = 0; i0 < 3; ++i0)
      {
        	test.IDLSubmessagePubSubType.read(data.num3[i0], cdr);	
      }
      	

      int num4_length = cdr.read_type_2();
      data.num4 = new System.Collections.Generic.List<test.IDLSubmessage>(num4_length);
      for(int i = 0; i < num4_length; i++)
      {
      	test.IDLSubmessage new_num4 = test.IDLSubmessagePubSubType.Create(); 
      	test.IDLSubmessagePubSubType.read(new_num4, cdr);
      	data.num4.Add(new_num4);	
      	
      }

      	
      data.str1 = cdr.read_type_d();	
      data.str2 = cdr.read_type_d();	

      int str3_length = cdr.read_type_2();
      data.str3 = new System.Collections.Generic.List<string>(str3_length);
      for(int i = 0; i < str3_length; i++)
      {
      	data.str3.Add(cdr.read_type_d());	
      	
      }

      	

      int str4_length = cdr.read_type_2();
      data.str4 = new System.Collections.Generic.List<string>(str4_length);
      for(int i = 0; i < str4_length; i++)
      {
      	data.str4.Add(cdr.read_type_d());	
      	
      }

      	

      int str5_length = cdr.read_type_2();
      data.str5 = new System.Collections.Generic.List<string>(str5_length);
      for(int i = 0; i < str5_length; i++)
      {
      	data.str5.Add(cdr.read_type_d());	
      	
      }

      	

   }


    public static void Copy(test.IDLFeatureMessage src, test.IDLFeatureMessage target)
    {
        target.Set(src);
    }


}


}