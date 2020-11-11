using System.Text;
namespace test
{


[System.Serializable]
public class IDLElementTest
{
   public char charTest;
   public char wcharTest;
   public byte octetTest;
   public short shortTest;
   public ushort ushortTest;
   public int longTest;
   public uint ulongTest;
   public long longlongTest;
   public ulong ulonglongTest;
   public float floatTest;
   public double doubleTest;
   public bool booleanTest;
   public test.Color colorTest;
   public nested.NestedElement nestedElementTest;
   public string stringTest;
   public readonly int[] longArray = new int[10];
   public readonly nested.NestedElement[,] nestedArray = new nested.NestedElement[5, 3];
   public readonly string[] stringArray = new string[4];
   public readonly test.Color[] enumArray = new test.Color[6];
   public System.Collections.Generic.List<char> charSeqTest;
   public System.Collections.Generic.List<char> wcharSeqTest;
   public System.Collections.Generic.List<byte> octetSeqTest;
   public System.Collections.Generic.List<short> shortSeqTest;
   public System.Collections.Generic.List<ushort> ushortSeqTest;
   public System.Collections.Generic.List<int> longSeqTest;
   public System.Collections.Generic.List<uint> ulongSeqTest;
   public System.Collections.Generic.List<long> longlongSeqtest;
   public System.Collections.Generic.List<ulong> ulonglongSeqTest;
   public System.Collections.Generic.List<float> floatSeqTest;
   public System.Collections.Generic.List<double> doubleSeqTest;
   public System.Collections.Generic.List<bool> booleanSeqTest;
   public System.Collections.Generic.List<nested.NestedElement> nestedSeqTest;
   public System.Collections.Generic.List<test.Color> enumSeqTest;
   public System.Collections.Generic.List<string> stringSeqTest;


   public void Set(IDLElementTest other)
   {
      charTest = other.charTest;

      wcharTest = other.wcharTest;

      octetTest = other.octetTest;

      shortTest = other.shortTest;

      ushortTest = other.ushortTest;

      longTest = other.longTest;

      ulongTest = other.ulongTest;

      longlongTest = other.longlongTest;

      ulonglongTest = other.ulonglongTest;

      floatTest = other.floatTest;

      doubleTest = other.doubleTest;

      booleanTest = other.booleanTest;

      colorTest = other.colorTest;

      nested.NestedElementPubSubType.Copy(other.nestedElementTest, nestedElementTest);

      stringTest = other.stringTest;

      for(int i1 = 0; i1 < 10; ++i1)
      {
            longArray[i1] = other.longArray[i1];

      }

      for(int i3 = 0; i3 < 5; ++i3)
      {
         for(int i4 = 0; i4 < 3; ++i4)
         {
               nested.NestedElementPubSubType.Copy(other.nestedArray[i3, i4], nestedArray[i3, i4]);}
      }

      for(int i6 = 0; i6 < 4; ++i6)
      {
            stringArray[i6] = other.stringArray[i6];
      }

      for(int i8 = 0; i8 < 6; ++i8)
      {
            enumArray[i8] = other.enumArray[i8];

      }


      if(other.charSeqTest == null)
      {
      	charSeqTest = null;
      }
      else
      {
      	charSeqTest = new System.Collections.Generic.List<char>(other.charSeqTest.Count);
      	for(int i10 = 0; i10 < other.charSeqTest.Count; i10++)
      	{
         		charSeqTest.Add(other.charSeqTest[i10]);
      	}
      }

      if(other.wcharSeqTest == null)
      {
      	wcharSeqTest = null;
      }
      else
      {
      	wcharSeqTest = new System.Collections.Generic.List<char>(other.wcharSeqTest.Count);
      	for(int i11 = 0; i11 < other.wcharSeqTest.Count; i11++)
      	{
         		wcharSeqTest.Add(other.wcharSeqTest[i11]);
      	}
      }

      if(other.octetSeqTest == null)
      {
      	octetSeqTest = null;
      }
      else
      {
      	octetSeqTest = new System.Collections.Generic.List<byte>(other.octetSeqTest.Count);
      	for(int i12 = 0; i12 < other.octetSeqTest.Count; i12++)
      	{
         		octetSeqTest.Add(other.octetSeqTest[i12]);
      	}
      }

      if(other.shortSeqTest == null)
      {
      	shortSeqTest = null;
      }
      else
      {
      	shortSeqTest = new System.Collections.Generic.List<short>(other.shortSeqTest.Count);
      	for(int i13 = 0; i13 < other.shortSeqTest.Count; i13++)
      	{
         		shortSeqTest.Add(other.shortSeqTest[i13]);
      	}
      }

      if(other.ushortSeqTest == null)
      {
      	ushortSeqTest = null;
      }
      else
      {
      	ushortSeqTest = new System.Collections.Generic.List<ushort>(other.ushortSeqTest.Count);
      	for(int i14 = 0; i14 < other.ushortSeqTest.Count; i14++)
      	{
         		ushortSeqTest.Add(other.ushortSeqTest[i14]);
      	}
      }

      if(other.longSeqTest == null)
      {
      	longSeqTest = null;
      }
      else
      {
      	longSeqTest = new System.Collections.Generic.List<int>(other.longSeqTest.Count);
      	for(int i15 = 0; i15 < other.longSeqTest.Count; i15++)
      	{
         		longSeqTest.Add(other.longSeqTest[i15]);
      	}
      }

      if(other.ulongSeqTest == null)
      {
      	ulongSeqTest = null;
      }
      else
      {
      	ulongSeqTest = new System.Collections.Generic.List<uint>(other.ulongSeqTest.Count);
      	for(int i16 = 0; i16 < other.ulongSeqTest.Count; i16++)
      	{
         		ulongSeqTest.Add(other.ulongSeqTest[i16]);
      	}
      }

      if(other.longlongSeqtest == null)
      {
      	longlongSeqtest = null;
      }
      else
      {
      	longlongSeqtest = new System.Collections.Generic.List<long>(other.longlongSeqtest.Count);
      	for(int i17 = 0; i17 < other.longlongSeqtest.Count; i17++)
      	{
         		longlongSeqtest.Add(other.longlongSeqtest[i17]);
      	}
      }

      if(other.ulonglongSeqTest == null)
      {
      	ulonglongSeqTest = null;
      }
      else
      {
      	ulonglongSeqTest = new System.Collections.Generic.List<ulong>(other.ulonglongSeqTest.Count);
      	for(int i18 = 0; i18 < other.ulonglongSeqTest.Count; i18++)
      	{
         		ulonglongSeqTest.Add(other.ulonglongSeqTest[i18]);
      	}
      }

      if(other.floatSeqTest == null)
      {
      	floatSeqTest = null;
      }
      else
      {
      	floatSeqTest = new System.Collections.Generic.List<float>(other.floatSeqTest.Count);
      	for(int i19 = 0; i19 < other.floatSeqTest.Count; i19++)
      	{
         		floatSeqTest.Add(other.floatSeqTest[i19]);
      	}
      }

      if(other.doubleSeqTest == null)
      {
      	doubleSeqTest = null;
      }
      else
      {
      	doubleSeqTest = new System.Collections.Generic.List<double>(other.doubleSeqTest.Count);
      	for(int i20 = 0; i20 < other.doubleSeqTest.Count; i20++)
      	{
         		doubleSeqTest.Add(other.doubleSeqTest[i20]);
      	}
      }

      if(other.booleanSeqTest == null)
      {
      	booleanSeqTest = null;
      }
      else
      {
      	booleanSeqTest = new System.Collections.Generic.List<bool>(other.booleanSeqTest.Count);
      	for(int i21 = 0; i21 < other.booleanSeqTest.Count; i21++)
      	{
         		booleanSeqTest.Add(other.booleanSeqTest[i21]);
      	}
      }

      if(other.nestedSeqTest == null)
      {
      	nestedSeqTest = null;
      }
      else
      {
      	nestedSeqTest = new System.Collections.Generic.List<nested.NestedElement>(other.nestedSeqTest.Count);
      	for(int i22 = 0; i22 < other.nestedSeqTest.Count; i22++)
      	{
      		if(other.nestedSeqTest[i22] == null)
      		{
      			nestedSeqTest.Add(null);
      		}
      		else
      		{
      			nested.NestedElement newElement = nested.NestedElementPubSubType.Create();
      	   		nested.NestedElementPubSubType.Copy(other.nestedSeqTest[i22], newElement);
      	   		nestedSeqTest.Add(newElement);
      		}	}
      }

      if(other.enumSeqTest == null)
      {
      	enumSeqTest = null;
      }
      else
      {
      	enumSeqTest = new System.Collections.Generic.List<test.Color>(other.enumSeqTest.Count);
      	for(int i23 = 0; i23 < other.enumSeqTest.Count; i23++)
      	{
         		enumSeqTest.Add(other.enumSeqTest[i23]);
      	}
      }

      if(other.stringSeqTest == null)
      {
      	stringSeqTest = null;
      }
      else
      {
      	stringSeqTest = new System.Collections.Generic.List<string>(other.stringSeqTest.Count);
      	for(int i24 = 0; i24 < other.stringSeqTest.Count; i24++)
      	{
         		stringSeqTest.Add(other.stringSeqTest[i24]);
      	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("IDLElementTest {");
      builder.Append("charTest=");
      builder.Append(this.charTest);      builder.Append(", ");
      builder.Append("wcharTest=");
      builder.Append(this.wcharTest);      builder.Append(", ");
      builder.Append("octetTest=");
      builder.Append(this.octetTest);      builder.Append(", ");
      builder.Append("shortTest=");
      builder.Append(this.shortTest);      builder.Append(", ");
      builder.Append("ushortTest=");
      builder.Append(this.ushortTest);      builder.Append(", ");
      builder.Append("longTest=");
      builder.Append(this.longTest);      builder.Append(", ");
      builder.Append("ulongTest=");
      builder.Append(this.ulongTest);      builder.Append(", ");
      builder.Append("longlongTest=");
      builder.Append(this.longlongTest);      builder.Append(", ");
      builder.Append("ulonglongTest=");
      builder.Append(this.ulonglongTest);      builder.Append(", ");
      builder.Append("floatTest=");
      builder.Append(this.floatTest);      builder.Append(", ");
      builder.Append("doubleTest=");
      builder.Append(this.doubleTest);      builder.Append(", ");
      builder.Append("booleanTest=");
      builder.Append(this.booleanTest);      builder.Append(", ");
      builder.Append("colorTest=");
      builder.Append(this.colorTest);      builder.Append(", ");
      builder.Append("nestedElementTest=");
      builder.Append(this.nestedElementTest);      builder.Append(", ");
      builder.Append("stringTest=");
      builder.Append(this.stringTest);      builder.Append(", ");
      builder.Append("longArray=");
      builder.Append(Halodi.CDR.CDRCommon.ArrayToString(",", this.longArray));      builder.Append(", ");
      builder.Append("nestedArray=");
      builder.Append(Halodi.CDR.CDRCommon.DeepArrayToString(",", this.nestedArray));      builder.Append(", ");
      builder.Append("stringArray=");
      builder.Append(Halodi.CDR.CDRCommon.ArrayToString(",", this.stringArray));      builder.Append(", ");
      builder.Append("enumArray=");
      builder.Append(Halodi.CDR.CDRCommon.ArrayToString(",", this.enumArray));      builder.Append(", ");
      builder.Append("charSeqTest=");
      builder.Append(this.charSeqTest);      builder.Append(", ");
      builder.Append("wcharSeqTest=");
      builder.Append(this.wcharSeqTest);      builder.Append(", ");
      builder.Append("octetSeqTest=");
      builder.Append(this.octetSeqTest);      builder.Append(", ");
      builder.Append("shortSeqTest=");
      builder.Append(this.shortSeqTest);      builder.Append(", ");
      builder.Append("ushortSeqTest=");
      builder.Append(this.ushortSeqTest);      builder.Append(", ");
      builder.Append("longSeqTest=");
      builder.Append(this.longSeqTest);      builder.Append(", ");
      builder.Append("ulongSeqTest=");
      builder.Append(this.ulongSeqTest);      builder.Append(", ");
      builder.Append("longlongSeqtest=");
      builder.Append(this.longlongSeqtest);      builder.Append(", ");
      builder.Append("ulonglongSeqTest=");
      builder.Append(this.ulonglongSeqTest);      builder.Append(", ");
      builder.Append("floatSeqTest=");
      builder.Append(this.floatSeqTest);      builder.Append(", ");
      builder.Append("doubleSeqTest=");
      builder.Append(this.doubleSeqTest);      builder.Append(", ");
      builder.Append("booleanSeqTest=");
      builder.Append(this.booleanSeqTest);      builder.Append(", ");
      builder.Append("nestedSeqTest=");
      builder.Append(this.nestedSeqTest);      builder.Append(", ");
      builder.Append("enumSeqTest=");
      builder.Append(this.enumSeqTest);      builder.Append(", ");
      builder.Append("stringSeqTest=");
      builder.Append(this.stringSeqTest);
      builder.Append("}");
      return builder.ToString();
   }
}


}