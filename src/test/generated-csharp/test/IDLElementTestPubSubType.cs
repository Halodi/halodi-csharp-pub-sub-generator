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
   public override string Name => "test::IDLElementTest";


   
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
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
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


      current_alignment += nested.NestedElementPubSubType.getCdrSerializedSize(data.nestedElementTest, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.stringTest.Length + 1;

      current_alignment += ((10) * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < 5; ++i0)
      {
          for(int i1 = 0; i1 < 3; ++i1)
          {
                  current_alignment += nested.NestedElementPubSubType.getCdrSerializedSize(data.nestedArray[i0, i1], current_alignment);
          }
      }
      for(int i0 = 0; i0 < 4; ++i0)
      {
              current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.stringArray[i0].Length + 1;

      }
      current_alignment += ((6) * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.charSeqTest.Count * 1) + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.wcharSeqTest.Count * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.octetSeqTest.Count * 1) + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.shortSeqTest.Count * 2) + Halodi.CDR.CDRCommon.alignment(current_alignment, 2);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.ushortSeqTest.Count * 2) + Halodi.CDR.CDRCommon.alignment(current_alignment, 2);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.longSeqTest.Count * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.ulongSeqTest.Count * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.longlongSeqtest.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.ulonglongSeqTest.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.floatSeqTest.Count * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.doubleSeqTest.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.booleanSeqTest.Count * 1) + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.nestedSeqTest.Count; ++i0)
      {
          current_alignment += nested.NestedElementPubSubType.getCdrSerializedSize(data.nestedSeqTest[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.enumSeqTest.Count * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.stringSeqTest.Count; ++i0)
      {
          current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.stringSeqTest[i0].Length + 1;
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

      cdr.write_type_c((int)data.colorTest);


      nested.NestedElementPubSubType.write(data.nestedElementTest, cdr);

      cdr.write_type_d(data.stringTest);

      for(int i0 = 0; i0 < 10; ++i0)
      {
        	cdr.write_type_2(data.longArray[i0]);	
      }

      for(int i0 = 0; i0 < 5; ++i0)
      {
        for(int i1 = 0; i1 < 3; ++i1)
        {
          	nested.NestedElementPubSubType.write(data.nestedArray[i0, i1], cdr);		
        }
      }

      for(int i0 = 0; i0 < 4; ++i0)
      {
        	cdr.write_type_d(data.stringArray[i0]);	
      }

      for(int i0 = 0; i0 < 6; ++i0)
      {
        	   cdr.write_type_c((int)data.enumArray[i0]);
        	
      }

      	if(data.charSeqTest == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int charSeqTest_length = data.charSeqTest.Count;
            cdr.write_type_2(charSeqTest_length);
            for (int i0 = 0; i0 < charSeqTest_length; i0++)
            {
      			cdr.write_type_8(data.charSeqTest[i0]);
            }
        }
      	if(data.wcharSeqTest == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int wcharSeqTest_length = data.wcharSeqTest.Count;
            cdr.write_type_2(wcharSeqTest_length);
            for (int i0 = 0; i0 < wcharSeqTest_length; i0++)
            {
      			cdr.write_type_14(data.wcharSeqTest[i0]);
            }
        }
      	if(data.octetSeqTest == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int octetSeqTest_length = data.octetSeqTest.Count;
            cdr.write_type_2(octetSeqTest_length);
            for (int i0 = 0; i0 < octetSeqTest_length; i0++)
            {
      			cdr.write_type_9(data.octetSeqTest[i0]);
            }
        }
      	if(data.shortSeqTest == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int shortSeqTest_length = data.shortSeqTest.Count;
            cdr.write_type_2(shortSeqTest_length);
            for (int i0 = 0; i0 < shortSeqTest_length; i0++)
            {
      			cdr.write_type_1(data.shortSeqTest[i0]);
            }
        }
      	if(data.ushortSeqTest == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int ushortSeqTest_length = data.ushortSeqTest.Count;
            cdr.write_type_2(ushortSeqTest_length);
            for (int i0 = 0; i0 < ushortSeqTest_length; i0++)
            {
      			cdr.write_type_3(data.ushortSeqTest[i0]);
            }
        }
      	if(data.longSeqTest == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int longSeqTest_length = data.longSeqTest.Count;
            cdr.write_type_2(longSeqTest_length);
            for (int i0 = 0; i0 < longSeqTest_length; i0++)
            {
      			cdr.write_type_2(data.longSeqTest[i0]);
            }
        }
      	if(data.ulongSeqTest == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int ulongSeqTest_length = data.ulongSeqTest.Count;
            cdr.write_type_2(ulongSeqTest_length);
            for (int i0 = 0; i0 < ulongSeqTest_length; i0++)
            {
      			cdr.write_type_4(data.ulongSeqTest[i0]);
            }
        }
      	if(data.longlongSeqtest == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int longlongSeqtest_length = data.longlongSeqtest.Count;
            cdr.write_type_2(longlongSeqtest_length);
            for (int i0 = 0; i0 < longlongSeqtest_length; i0++)
            {
      			cdr.write_type_11(data.longlongSeqtest[i0]);
            }
        }
      	if(data.ulonglongSeqTest == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int ulonglongSeqTest_length = data.ulonglongSeqTest.Count;
            cdr.write_type_2(ulonglongSeqTest_length);
            for (int i0 = 0; i0 < ulonglongSeqTest_length; i0++)
            {
      			cdr.write_type_12(data.ulonglongSeqTest[i0]);
            }
        }
      	if(data.floatSeqTest == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int floatSeqTest_length = data.floatSeqTest.Count;
            cdr.write_type_2(floatSeqTest_length);
            for (int i0 = 0; i0 < floatSeqTest_length; i0++)
            {
      			cdr.write_type_5(data.floatSeqTest[i0]);
            }
        }
      	if(data.doubleSeqTest == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int doubleSeqTest_length = data.doubleSeqTest.Count;
            cdr.write_type_2(doubleSeqTest_length);
            for (int i0 = 0; i0 < doubleSeqTest_length; i0++)
            {
      			cdr.write_type_6(data.doubleSeqTest[i0]);
            }
        }
      	if(data.booleanSeqTest == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int booleanSeqTest_length = data.booleanSeqTest.Count;
            cdr.write_type_2(booleanSeqTest_length);
            for (int i0 = 0; i0 < booleanSeqTest_length; i0++)
            {
      			cdr.write_type_7(data.booleanSeqTest[i0]);
            }
        }
      	if(data.nestedSeqTest == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int nestedSeqTest_length = data.nestedSeqTest.Count;
            cdr.write_type_2(nestedSeqTest_length);
            for (int i0 = 0; i0 < nestedSeqTest_length; i0++)
            {
      			nested.NestedElementPubSubType.write(data.nestedSeqTest[i0], cdr);	      }
        }
      	if(data.enumSeqTest == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int enumSeqTest_length = data.enumSeqTest.Count;
            cdr.write_type_2(enumSeqTest_length);
            for (int i0 = 0; i0 < enumSeqTest_length; i0++)
            {
      	   		cdr.write_type_c((int) data.enumSeqTest[i0]);

            }
        }
      	if(data.stringSeqTest == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int stringSeqTest_length = data.stringSeqTest.Count;
            cdr.write_type_2(stringSeqTest_length);
            for (int i0 = 0; i0 < stringSeqTest_length; i0++)
            {
      			cdr.write_type_d(data.stringSeqTest[i0]);
            }
        }
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
      	
      data.nestedElementTest = nested.NestedElementPubSubType.Create();
      nested.NestedElementPubSubType.read(data.nestedElementTest, cdr);
      	
      data.stringTest = cdr.read_type_d();	
      for(int i0 = 0; i0 < 10; ++i0)
      {
        	data.longArray[i0] = cdr.read_type_2();
        	
      }
      	
      for(int i0 = 0; i0 < 5; ++i0)
      {
        for(int i1 = 0; i1 < 3; ++i1)
        {
          	nested.NestedElementPubSubType.read(data.nestedArray[i0, i1], cdr);	
        }
      }
      	
      for(int i0 = 0; i0 < 4; ++i0)
      {
        	data.stringArray[i0] = cdr.read_type_d();	
      }
      	
      for(int i0 = 0; i0 < 6; ++i0)
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
      	nested.NestedElement new_nestedSeqTest = nested.NestedElementPubSubType.Create(); 
      	nested.NestedElementPubSubType.read(new_nestedSeqTest, cdr);
      	data.nestedSeqTest.Add(new_nestedSeqTest);	
      	
      }

      	

      int enumSeqTest_length = cdr.read_type_2();
      data.enumSeqTest = new System.Collections.Generic.List<test.Color>(enumSeqTest_length);
      for(int i = 0; i < enumSeqTest_length; i++)
      {
         int ordinal = cdr.read_type_c();
         if (ordinal < 0)
      	  ordinal = 0;
         data.enumSeqTest.Add((test.Color) ordinal);
      	
      	
      }

      	

      int stringSeqTest_length = cdr.read_type_2();
      data.stringSeqTest = new System.Collections.Generic.List<string>(stringSeqTest_length);
      for(int i = 0; i < stringSeqTest_length; i++)
      {
      	data.stringSeqTest.Add(cdr.read_type_d());	
      	
      }

      	

   }


    public static void Copy(test.IDLElementTest src, test.IDLElementTest target)
    {
        target.Set(src);
    }


}


}