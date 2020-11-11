using System.IO;
namespace test
{

/**
* 
* Topic data type of the struct "IDLElementTest" defined in "IDLElementTest.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from IDLElementTest.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit IDLElementTest.idl instead.
*
*/
public class IDLElementTestPubSubType : Halodi.CDR.TopicDataType<test.IDLElementTest>
{
   public const string name = "test::IDLElementTest";


   
   public override void serialize(test.IDLElementTest data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, test.IDLElementTest data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(stream);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(test.IDLElementTest data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(test.IDLElementTest data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 2 + Halodi.CDR.CDRCommon.alignment(current_alignment, 2);


      current_alignment += 2 + Halodi.CDR.CDRCommon.alignment(current_alignment, 2);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += nested.NestedElementPubSubType.getCdrSerializedSize(data.getNestedElementTest(), current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.getStringTest().length() + 1;

      current_alignment += ((10) * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getNestedArray().Length; ++i0)
      {
          for(int i1 = 0; i1 < data.getNestedArray()[i0].Length; ++i1)
          {
                  current_alignment += nested.NestedElementPubSubType.getCdrSerializedSize(data.getNestedArray()[i0][i1], current_alignment);
          }
      }
      for(int i0 = 0; i0 < data.getStringArray().Length; ++i0)
      {
              current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.getStringArray()[i0].Length + 1;

      }
      current_alignment += ((6) * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.getCharSeqTest().size() * 1) + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.getWcharSeqTest().size() * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.getOctetSeqTest().size() * 1) + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.getShortSeqTest().size() * 2) + Halodi.CDR.CDRCommon.alignment(current_alignment, 2);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.getUshortSeqTest().size() * 2) + Halodi.CDR.CDRCommon.alignment(current_alignment, 2);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.getLongSeqTest().size() * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.getUlongSeqTest().size() * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.getLonglongSeqtest().size() * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.getUlonglongSeqTest().size() * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.getFloatSeqTest().size() * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.getDoubleSeqTest().size() * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.getBooleanSeqTest().size() * 1) + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getNestedSeqTest().size(); ++i0)
      {
          current_alignment += nested.NestedElementPubSubType.getCdrSerializedSize(data.getNestedSeqTest().get(i0), current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.getEnumSeqTest().size() * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getStringSeqTest().size(); ++i0)
      {
          current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.getStringSeqTest().get(i0).length() + 1;
      }

      return current_alignment - initial_alignment;
   }

   public static void write(test.IDLElementTest data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_8(data.charTest);

      cdr.write_type_14(data.wcharTest);

      cdr.write_type_9(data.octetTest);

      cdr.write_type_1(data.shortTest);

      cdr.write_type_3(data.ushortTest);

      cdr.write_type_2(data.longTest);

      cdr.write_type_4(data.ulongTest);

      cdr.write_type_11(data.longlongTest);

      cdr.write_type_12(data.ulonglongTest);

      cdr.write_type_5(data.floatTest);

      cdr.write_type_6(data.doubleTest);

      cdr.write_type_7(data.booleanTest);

      cdr.write_type_c(data.colorTest.ordinal());


      nested.NestedElementPubSubType.write(data.nestedElementTest, cdr);
      cdr.write_type_d(data.stringTest);

      for(int i0 = 0; i0 < data.longArray.length; ++i0)
      {
        	cdr.write_type_2(data.longArray[i0]);	
      }

      for(int i0 = 0; i0 < data.nestedArray.length; ++i0)
      {
        for(int i1 = 0; i1 < data.nestedArray[i0].length; ++i1)
        {
          	nested.NestedElementPubSubType.write(data.nestedArray[i0][i1], cdr);		
        }
      }

      for(int i0 = 0; i0 < data.stringArray.length; ++i0)
      {
        	cdr.write_type_d(data.stringArray[i0]);	
      }

      for(int i0 = 0; i0 < data.enumArray.length; ++i0)
      {
            if (data.enumArray[i0] == null)
        	   cdr.write_type_c(-1);
            else
        	   cdr.write_type_c(data.enumArray[i0].ordinal());
        	
      }

      cdr.write_type_e(data.charSeqTest);

      cdr.write_type_e(data.wcharSeqTest);

      cdr.write_type_e(data.octetSeqTest);

      cdr.write_type_e(data.shortSeqTest);

      cdr.write_type_e(data.ushortSeqTest);

      cdr.write_type_e(data.longSeqTest);

      cdr.write_type_e(data.ulongSeqTest);

      cdr.write_type_e(data.longlongSeqtest);

      cdr.write_type_e(data.ulonglongSeqTest);

      cdr.write_type_e(data.floatSeqTest);

      cdr.write_type_e(data.doubleSeqTest);

      cdr.write_type_e(data.booleanSeqTest);

      cdr.write_type_e(data.nestedSeqTest);

      cdr.write_type_e(data.enumSeqTest);

      cdr.write_type_e(data.stringSeqTest);

   }

   public static void read(test.IDLElementTest data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.charTest=cdr.read_type_8();
      	
      data.wcharTest=cdr.read_type_14();
      	
      data.octetTest=cdr.read_type_9();
      	
      data.shortTest=cdr.read_type_1();
      	
      data.ushortTest=cdr.read_type_3();
      	
      data.longTest=cdr.read_type_2();
      	
      data.ulongTest=cdr.read_type_4();
      	
      data.longlongTest=cdr.read_type_11();
      	
      data.ulonglongTest=cdr.read_type_12();
      	
      data.floatTest=cdr.read_type_5();
      	
      data.doubleTest=cdr.read_type_6();
      	
      data.booleanTest=cdr.read_type_7();
      	
      data.colorTest = (test.Color) cdr.read_type_c();
      	
      nested.NestedElementPubSubType.read(data.nestedElementTest, cdr);
      	
      cdr.read_type_d(data.stringTest);	
      for(int i0 = 0; i0 < data.longArray.length; ++i0)
      {
        	data.longArray[i0] = cdr.read_type_2();
        	
      }
      	
      for(int i0 = 0; i0 < data.nestedArray.length; ++i0)
      {
        for(int i1 = 0; i1 < data.nestedArray[i0].length; ++i1)
        {
          	nested.NestedElementPubSubType.read(data.nestedArray[i0][i1], cdr);	
        }
      }
      	
      for(int i0 = 0; i0 < data.stringArray.length; ++i0)
      {
        	data.stringArray[i0].Add(cdr.read_type_d());	
      }
      	
      for(int i0 = 0; i0 < data.enumArray.length; ++i0)
      {
           int ordinal = cdr.read_type_c();
           if (ordinal < 0)
        	  ordinal = 0;
          data.enumArray[i0] = (test.Color) ordinal;
        	
      }
      	

      int charSeqTest_length = cdr.read_type_2();
      data.charSeqTest = new System.Collections.Generic.List<char>(charSeqTest_length);
      for(int i = 0; i < charSeqTest_length; i++)
      {
      	data.charSeqTest.Add(cdr.read_type_8());
      	
      	
      }
      	

      int wcharSeqTest_length = cdr.read_type_2();
      data.wcharSeqTest = new System.Collections.Generic.List<char>(wcharSeqTest_length);
      for(int i = 0; i < wcharSeqTest_length; i++)
      {
      	data.wcharSeqTest.Add(cdr.read_type_14());
      	
      	
      }
      	

      int octetSeqTest_length = cdr.read_type_2();
      data.octetSeqTest = new System.Collections.Generic.List<byte>(octetSeqTest_length);
      for(int i = 0; i < octetSeqTest_length; i++)
      {
      	data.octetSeqTest.Add(cdr.read_type_9());
      	
      	
      }
      	

      int shortSeqTest_length = cdr.read_type_2();
      data.shortSeqTest = new System.Collections.Generic.List<short>(shortSeqTest_length);
      for(int i = 0; i < shortSeqTest_length; i++)
      {
      	data.shortSeqTest.Add(cdr.read_type_1());
      	
      	
      }
      	

      int ushortSeqTest_length = cdr.read_type_2();
      data.ushortSeqTest = new System.Collections.Generic.List<ushort>(ushortSeqTest_length);
      for(int i = 0; i < ushortSeqTest_length; i++)
      {
      	data.ushortSeqTest.Add(cdr.read_type_3());
      	
      	
      }
      	

      int longSeqTest_length = cdr.read_type_2();
      data.longSeqTest = new System.Collections.Generic.List<int>(longSeqTest_length);
      for(int i = 0; i < longSeqTest_length; i++)
      {
      	data.longSeqTest.Add(cdr.read_type_2());
      	
      	
      }
      	

      int ulongSeqTest_length = cdr.read_type_2();
      data.ulongSeqTest = new System.Collections.Generic.List<uint>(ulongSeqTest_length);
      for(int i = 0; i < ulongSeqTest_length; i++)
      {
      	data.ulongSeqTest.Add(cdr.read_type_4());
      	
      	
      }
      	

      int longlongSeqtest_length = cdr.read_type_2();
      data.longlongSeqtest = new System.Collections.Generic.List<long>(longlongSeqtest_length);
      for(int i = 0; i < longlongSeqtest_length; i++)
      {
      	data.longlongSeqtest.Add(cdr.read_type_11());
      	
      	
      }
      	

      int ulonglongSeqTest_length = cdr.read_type_2();
      data.ulonglongSeqTest = new System.Collections.Generic.List<ulong>(ulonglongSeqTest_length);
      for(int i = 0; i < ulonglongSeqTest_length; i++)
      {
      	data.ulonglongSeqTest.Add(cdr.read_type_12());
      	
      	
      }
      	

      int floatSeqTest_length = cdr.read_type_2();
      data.floatSeqTest = new System.Collections.Generic.List<float>(floatSeqTest_length);
      for(int i = 0; i < floatSeqTest_length; i++)
      {
      	data.floatSeqTest.Add(cdr.read_type_5());
      	
      	
      }
      	

      int doubleSeqTest_length = cdr.read_type_2();
      data.doubleSeqTest = new System.Collections.Generic.List<double>(doubleSeqTest_length);
      for(int i = 0; i < doubleSeqTest_length; i++)
      {
      	data.doubleSeqTest.Add(cdr.read_type_6());
      	
      	
      }
      	

      int booleanSeqTest_length = cdr.read_type_2();
      data.booleanSeqTest = new System.Collections.Generic.List<bool>(booleanSeqTest_length);
      for(int i = 0; i < booleanSeqTest_length; i++)
      {
      	data.booleanSeqTest.Add(cdr.read_type_7());
      	
      	
      }
      	

      int nestedSeqTest_length = cdr.read_type_2();
      data.nestedSeqTest = new System.Collections.Generic.List<nested.NestedElement>(nestedSeqTest_length);
      for(int i = 0; i < nestedSeqTest_length; i++)
      {
      	nested.NestedElementPubSubType.read(data.nestedSeqTest, cdr);	
      	
      }
      	

      int enumSeqTest_length = cdr.read_type_2();
      data.enumSeqTest = new us.ihmc.idl.IDLSequence.Enum<test.Color>(enumSeqTest_length);
      for(int i = 0; i < enumSeqTest_length; i++)
      {
         int ordinal = cdr.read_type_c();
         if (ordinal < 0)
      	  ordinal = 0;
         data.enumSeqTest.Add((us.ihmc.idl.IDLSequence.Enum<test.Color>) ordinal);
      	
      	
      }
      	

      int stringSeqTest_length = cdr.read_type_2();
      data.stringSeqTest = new System.Collections.Generic.List<string>(stringSeqTest_length);
      for(int i = 0; i < stringSeqTest_length; i++)
      {
      	data.stringSeqTest.Add(cdr.read_type_d());	
      	
      }
      	

   }



   public override string getName()
   {
      return name;
   }
   

}


}