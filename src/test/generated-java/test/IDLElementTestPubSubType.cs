namespace test
{

/**
* 
* Topic data type of the struct "IDLElementTest" defined in "IDLElementTest.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from IDLElementTest.idl by us.ihmc.idl.generator.IDLGenerator. 
* Do not update this file directly, edit IDLElementTest.idl instead.
*
*/
public class IDLElementTestPubSubType : Halodi.TopicDataType<test.IDLElementTest>
{
   public const string name = "test::IDLElementTest";


   private final us.ihmc.idl.CDR serializeCDR = new us.ihmc.idl.CDR();
   private final us.ihmc.idl.CDR deserializeCDR = new us.ihmc.idl.CDR();

   @Override
   public void serialize(test.IDLElementTest data, us.ihmc.pubsub.common.SerializedPayload serializedPayload) throws java.io.IOException
   {
      serializeCDR.serialize(serializedPayload);
      write(data, serializeCDR);
      serializeCDR.finishSerialize();
   }

   @Override
   public void deserialize(us.ihmc.pubsub.common.SerializedPayload serializedPayload, test.IDLElementTest data) throws java.io.IOException
   {
      deserializeCDR.deserialize(serializedPayload);
      read(data, deserializeCDR);
      deserializeCDR.finishDeserialize();
   }

   public final static int getCdrSerializedSize(test.IDLElementTest data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(test.IDLElementTest data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 1 + us.ihmc.idl.CDR.alignment(current_alignment, 1);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);


      current_alignment += 1 + us.ihmc.idl.CDR.alignment(current_alignment, 1);


      current_alignment += 2 + us.ihmc.idl.CDR.alignment(current_alignment, 2);


      current_alignment += 2 + us.ihmc.idl.CDR.alignment(current_alignment, 2);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);


      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);


      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      current_alignment += 1 + us.ihmc.idl.CDR.alignment(current_alignment, 1);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);


      current_alignment += nested.NestedElementPubSubType.getCdrSerializedSize(data.getNestedElementTest(), current_alignment);

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4) + data.getStringTest().length() + 1;

      current_alignment += ((10) * 4) + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getNestedArray().length; ++i0)
      {
          for(int i1 = 0; i1 < data.getNestedArray()[i0].length; ++i1)
          {
                  current_alignment += nested.NestedElementPubSubType.getCdrSerializedSize(data.getNestedArray()[i0][i1], current_alignment);
          }
      }
      for(int i0 = 0; i0 < data.getStringArray().length; ++i0)
      {
              current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4) + data.getStringArray()[i0].length() + 1;

      }
      current_alignment += ((6) * 4) + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      current_alignment += (data.getCharSeqTest().size() * 1) + us.ihmc.idl.CDR.alignment(current_alignment, 1);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      current_alignment += (data.getWcharSeqTest().size() * 4) + us.ihmc.idl.CDR.alignment(current_alignment, 4);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      current_alignment += (data.getOctetSeqTest().size() * 1) + us.ihmc.idl.CDR.alignment(current_alignment, 1);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      current_alignment += (data.getShortSeqTest().size() * 2) + us.ihmc.idl.CDR.alignment(current_alignment, 2);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      current_alignment += (data.getUshortSeqTest().size() * 2) + us.ihmc.idl.CDR.alignment(current_alignment, 2);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      current_alignment += (data.getLongSeqTest().size() * 4) + us.ihmc.idl.CDR.alignment(current_alignment, 4);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      current_alignment += (data.getUlongSeqTest().size() * 4) + us.ihmc.idl.CDR.alignment(current_alignment, 4);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      current_alignment += (data.getLonglongSeqtest().size() * 8) + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      current_alignment += (data.getUlonglongSeqTest().size() * 8) + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      current_alignment += (data.getFloatSeqTest().size() * 4) + us.ihmc.idl.CDR.alignment(current_alignment, 4);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      current_alignment += (data.getDoubleSeqTest().size() * 8) + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      current_alignment += (data.getBooleanSeqTest().size() * 1) + us.ihmc.idl.CDR.alignment(current_alignment, 1);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getNestedSeqTest().size(); ++i0)
      {
          current_alignment += nested.NestedElementPubSubType.getCdrSerializedSize(data.getNestedSeqTest().get(i0), current_alignment);}

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      current_alignment += (data.getEnumSeqTest().size() * 4) + us.ihmc.idl.CDR.alignment(current_alignment, 4);


      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getStringSeqTest().size(); ++i0)
      {
          current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4) + data.getStringSeqTest().get(i0).length() + 1;
      }

      return current_alignment - initial_alignment;
   }

   public static void write(test.IDLElementTest data, us.ihmc.idl.CDR cdr)
   {
      cdr.write_type_8(data.getCharTest());

      cdr.write_type_14(data.getWcharTest());

      cdr.write_type_9(data.getOctetTest());

      cdr.write_type_1(data.getShortTest());

      cdr.write_type_3(data.getUshortTest());

      cdr.write_type_2(data.getLongTest());

      cdr.write_type_4(data.getUlongTest());

      cdr.write_type_11(data.getLonglongTest());

      cdr.write_type_12(data.getUlonglongTest());

      cdr.write_type_5(data.getFloatTest());

      cdr.write_type_6(data.getDoubleTest());

      cdr.write_type_7(data.getBooleanTest());

      cdr.write_type_c(data.getColorTest().ordinal());


      nested.NestedElementPubSubType.write(data.getNestedElementTest(), cdr);
      cdr.write_type_d(data.getStringTest());

      for(int i0 = 0; i0 < data.getLongArray().length; ++i0)
      {
        	cdr.write_type_2(data.getLongArray()[i0]);	
      }

      for(int i0 = 0; i0 < data.getNestedArray().length; ++i0)
      {
        for(int i1 = 0; i1 < data.getNestedArray()[i0].length; ++i1)
        {
          	nested.NestedElementPubSubType.write(data.getNestedArray()[i0][i1], cdr);		
        }
      }

      for(int i0 = 0; i0 < data.getStringArray().length; ++i0)
      {
        	cdr.write_type_d(data.getStringArray()[i0]);	
      }

      for(int i0 = 0; i0 < data.getEnumArray().length; ++i0)
      {
            if (data.getEnumArray()[i0] == null)
        	   cdr.write_type_c(-1);
            else
        	   cdr.write_type_c(data.getEnumArray()[i0].ordinal());
        	
      }

      cdr.write_type_e(data.getCharSeqTest());

      cdr.write_type_e(data.getWcharSeqTest());

      cdr.write_type_e(data.getOctetSeqTest());

      cdr.write_type_e(data.getShortSeqTest());

      cdr.write_type_e(data.getUshortSeqTest());

      cdr.write_type_e(data.getLongSeqTest());

      cdr.write_type_e(data.getUlongSeqTest());

      cdr.write_type_e(data.getLonglongSeqtest());

      cdr.write_type_e(data.getUlonglongSeqTest());

      cdr.write_type_e(data.getFloatSeqTest());

      cdr.write_type_e(data.getDoubleSeqTest());

      cdr.write_type_e(data.getBooleanSeqTest());

      cdr.write_type_e(data.getNestedSeqTest());

      cdr.write_type_e(data.getEnumSeqTest());

      cdr.write_type_e(data.getStringSeqTest());

   }

   public static void read(test.IDLElementTest data, us.ihmc.idl.CDR cdr)
   {
      data.CharTest=cdr.read_type_8());
      	
      data.WcharTest=cdr.read_type_14());
      	
      data.OctetTest=cdr.read_type_9());
      	
      data.ShortTest=cdr.read_type_1());
      	
      data.UshortTest=cdr.read_type_3());
      	
      data.LongTest=cdr.read_type_2());
      	
      data.UlongTest=cdr.read_type_4());
      	
      data.LonglongTest=cdr.read_type_11());
      	
      data.UlonglongTest=cdr.read_type_12());
      	
      data.FloatTest=cdr.read_type_5());
      	
      data.DoubleTest=cdr.read_type_6());
      	
      data.BooleanTest=cdr.read_type_7());
      	
      data.ColorTest = (test.Color) cdr.read_type_c();
      	
      nested.NestedElementPubSubType.read(data.NestedElementTest, cdr);
      	
      cdr.read_type_d(data.getStringTest());	
      for(int i0 = 0; i0 < data.LongArray.length; ++i0)
      {
        	data.LongArray[i0] = cdr.read_type_2();
        	
      }
      	
      for(int i0 = 0; i0 < data.NestedArray.length; ++i0)
      {
        for(int i1 = 0; i1 < data.NestedArray[i0].length; ++i1)
        {
          	nested.NestedElementPubSubType.read(data.NestedArray[i0][i1], cdr);	
        }
      }
      	
      for(int i0 = 0; i0 < data.StringArray.length; ++i0)
      {
        	data.StringArray[i0].Add(cdr.read_type_d());	
      }
      	
      for(int i0 = 0; i0 < data.EnumArray.length; ++i0)
      {
           int ordinal = cdr.read_type_c();
           if (ordinal < 0)
        	  ordinal = 0;
          data.EnumArray[i0] = (test.Color) ordinal;
        	
      }
      	

      int CharSeqTest_length = cdr.read_type_2();
      data.CharSeqTest = new System.Collections.Generic.List<char>(CharSeqTest_length);
      for(int i = 0; i < CharSeqTest_length; i++)
      {
      	data.CharSeqTest.Add(cdr.read_type_8());
      	
      	
      }
      	

      int WcharSeqTest_length = cdr.read_type_2();
      data.WcharSeqTest = new System.Collections.Generic.List<char>(WcharSeqTest_length);
      for(int i = 0; i < WcharSeqTest_length; i++)
      {
      	data.WcharSeqTest.Add(cdr.read_type_14());
      	
      	
      }
      	

      int OctetSeqTest_length = cdr.read_type_2();
      data.OctetSeqTest = new System.Collections.Generic.List<byte>(OctetSeqTest_length);
      for(int i = 0; i < OctetSeqTest_length; i++)
      {
      	data.OctetSeqTest.Add(cdr.read_type_9());
      	
      	
      }
      	

      int ShortSeqTest_length = cdr.read_type_2();
      data.ShortSeqTest = new System.Collections.Generic.List<short>(ShortSeqTest_length);
      for(int i = 0; i < ShortSeqTest_length; i++)
      {
      	data.ShortSeqTest.Add(cdr.read_type_1());
      	
      	
      }
      	

      int UshortSeqTest_length = cdr.read_type_2();
      data.UshortSeqTest = new System.Collections.Generic.List<ushort>(UshortSeqTest_length);
      for(int i = 0; i < UshortSeqTest_length; i++)
      {
      	data.UshortSeqTest.Add(cdr.read_type_3());
      	
      	
      }
      	

      int LongSeqTest_length = cdr.read_type_2();
      data.LongSeqTest = new System.Collections.Generic.List<int>(LongSeqTest_length);
      for(int i = 0; i < LongSeqTest_length; i++)
      {
      	data.LongSeqTest.Add(cdr.read_type_2());
      	
      	
      }
      	

      int UlongSeqTest_length = cdr.read_type_2();
      data.UlongSeqTest = new System.Collections.Generic.List<uint>(UlongSeqTest_length);
      for(int i = 0; i < UlongSeqTest_length; i++)
      {
      	data.UlongSeqTest.Add(cdr.read_type_4());
      	
      	
      }
      	

      int LonglongSeqtest_length = cdr.read_type_2();
      data.LonglongSeqtest = new System.Collections.Generic.List<long>(LonglongSeqtest_length);
      for(int i = 0; i < LonglongSeqtest_length; i++)
      {
      	data.LonglongSeqtest.Add(cdr.read_type_11());
      	
      	
      }
      	

      int UlonglongSeqTest_length = cdr.read_type_2();
      data.UlonglongSeqTest = new System.Collections.Generic.List<ulong>(UlonglongSeqTest_length);
      for(int i = 0; i < UlonglongSeqTest_length; i++)
      {
      	data.UlonglongSeqTest.Add(cdr.read_type_12());
      	
      	
      }
      	

      int FloatSeqTest_length = cdr.read_type_2();
      data.FloatSeqTest = new System.Collections.Generic.List<float>(FloatSeqTest_length);
      for(int i = 0; i < FloatSeqTest_length; i++)
      {
      	data.FloatSeqTest.Add(cdr.read_type_5());
      	
      	
      }
      	

      int DoubleSeqTest_length = cdr.read_type_2();
      data.DoubleSeqTest = new System.Collections.Generic.List<double>(DoubleSeqTest_length);
      for(int i = 0; i < DoubleSeqTest_length; i++)
      {
      	data.DoubleSeqTest.Add(cdr.read_type_6());
      	
      	
      }
      	

      int BooleanSeqTest_length = cdr.read_type_2();
      data.BooleanSeqTest = new System.Collections.Generic.List<bool>(BooleanSeqTest_length);
      for(int i = 0; i < BooleanSeqTest_length; i++)
      {
      	data.BooleanSeqTest.Add(cdr.read_type_7());
      	
      	
      }
      	

      int NestedSeqTest_length = cdr.read_type_2();
      data.NestedSeqTest = new System.Collections.Generic.List<nested.NestedElement>(NestedSeqTest_length);
      for(int i = 0; i < NestedSeqTest_length; i++)
      {
      	nested.NestedElementPubSubType.read(data.NestedSeqTest, cdr);	
      	
      }
      	

      int EnumSeqTest_length = cdr.read_type_2();
      data.EnumSeqTest = new us.ihmc.idl.IDLSequence.Enum<test.Color>(EnumSeqTest_length);
      for(int i = 0; i < EnumSeqTest_length; i++)
      {
         int ordinal = cdr.read_type_c();
         if (ordinal < 0)
      	  ordinal = 0;
         data.EnumSeqTest.Add((us.ihmc.idl.IDLSequence.Enum<test.Color>) ordinal);
      	
      	
      }
      	

      int StringSeqTest_length = cdr.read_type_2();
      data.StringSeqTest = new System.Collections.Generic.List<string>(StringSeqTest_length);
      for(int i = 0; i < StringSeqTest_length; i++)
      {
      	data.StringSeqTest.Add(cdr.read_type_d());	
      	
      }
      	

   }


   public override int getTypeSize()
   {
      return us.ihmc.idl.CDR.getTypeSize(getMaxCdrSerializedSize());
   }

   public override string getName()
   {
      return name;
   }
   
   public void serialize(test.IDLElementTest data, us.ihmc.idl.CDR cdr)
   {
      write(data, cdr);
   }

   public void deserialize(test.IDLElementTest data, us.ihmc.idl.CDR cdr)
   {
      read(data, cdr);
   }
}


}