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
public class IDLFeatureMessagePubSubType : Halodi.TopicDataType<test.IDLFeatureMessage>
{
   public const string name = "test::IDLFeatureMessage";


   @Override
   public void serialize(test.IDLFeatureMessage data, MemoryStream stream) throws java.io.IOException
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   @Override
   public void deserialize(MemoryStream stream, test.IDLFeatureMessage data) throws java.io.IOException
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(stream);
   	   		read(data, cdr); 
   	   }
   }

   public final static int getCdrSerializedSize(test.IDLFeatureMessage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.IDLFeatureMessage data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += test.IDLSubmessagePubSubType.getCdrSerializedSize(data.getNum1(), current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getNum2().size(); ++i0)
      {
          current_alignment += test.IDLSubmessagePubSubType.getCdrSerializedSize(data.getNum2().get(i0), current_alignment);}

      for(int i0 = 0; i0 < data.getNum3().length; ++i0)
      {
              current_alignment += test.IDLSubmessagePubSubType.getCdrSerializedSize(data.getNum3()[i0], current_alignment);
      }
      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getNum4().size(); ++i0)
      {
          current_alignment += test.IDLSubmessagePubSubType.getCdrSerializedSize(data.getNum4().get(i0), current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.getStr1().length() + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.getStr2().length() + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getStr3().size(); ++i0)
      {
          current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.getStr3().get(i0).length() + 1;
      }
      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getStr4().size(); ++i0)
      {
          current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.getStr4().get(i0).length() + 1;
      }
      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getStr5().size(); ++i0)
      {
          current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.getStr5().get(i0).length() + 1;
      }

      return current_alignment - initial_alignment;
   }

   public static void write(test.IDLFeatureMessage data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_11(data.getNum());

      cdr.write_type_11(data.getNoDefaultWithDoc());

      cdr.write_type_11(data.getNoDocNum());

      cdr.write_type_2(data.getHello());

      test.IDLSubmessagePubSubType.write(data.getNum1(), cdr);
      cdr.write_type_e(data.getNum2());

      for(int i0 = 0; i0 < data.getNum3().length; ++i0)
      {
        	test.IDLSubmessagePubSubType.write(data.getNum3()[i0], cdr);		
      }

      cdr.write_type_e(data.getNum4());

      cdr.write_type_d(data.getStr1());

      cdr.write_type_d(data.getStr2());

      cdr.write_type_e(data.getStr3());

      cdr.write_type_e(data.getStr4());

      cdr.write_type_e(data.getStr5());

   }

   public static void read(test.IDLFeatureMessage data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.Num=cdr.read_type_11());
      	
      data.NoDefaultWithDoc=cdr.read_type_11());
      	
      data.NoDocNum=cdr.read_type_11());
      	
      data.Hello=cdr.read_type_2());
      	
      test.IDLSubmessagePubSubType.read(data.Num1, cdr);
      	

      int Num2_length = cdr.read_type_2();
      data.Num2 = new System.Collections.Generic.List<test.IDLSubmessage>(Num2_length);
      for(int i = 0; i < Num2_length; i++)
      {
      	test.IDLSubmessagePubSubType.read(data.Num2, cdr);	
      	
      }
      	
      for(int i0 = 0; i0 < data.Num3.length; ++i0)
      {
        	test.IDLSubmessagePubSubType.read(data.Num3[i0], cdr);	
      }
      	

      int Num4_length = cdr.read_type_2();
      data.Num4 = new System.Collections.Generic.List<test.IDLSubmessage>(Num4_length);
      for(int i = 0; i < Num4_length; i++)
      {
      	test.IDLSubmessagePubSubType.read(data.Num4, cdr);	
      	
      }
      	
      cdr.read_type_d(data.getStr1());	
      cdr.read_type_d(data.getStr2());	

      int Str3_length = cdr.read_type_2();
      data.Str3 = new System.Collections.Generic.List<string>(Str3_length);
      for(int i = 0; i < Str3_length; i++)
      {
      	data.Str3.Add(cdr.read_type_d());	
      	
      }
      	

      int Str4_length = cdr.read_type_2();
      data.Str4 = new System.Collections.Generic.List<string>(Str4_length);
      for(int i = 0; i < Str4_length; i++)
      {
      	data.Str4.Add(cdr.read_type_d());	
      	
      }
      	

      int Str5_length = cdr.read_type_2();
      data.Str5 = new System.Collections.Generic.List<string>(Str5_length);
      for(int i = 0; i < Str5_length; i++)
      {
      	data.Str5.Add(cdr.read_type_d());	
      	
      }
      	

   }



   public override string getName()
   {
      return name;
   }
   

}


}