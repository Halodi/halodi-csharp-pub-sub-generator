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
   public int[] longArray;
   public nested.NestedElement[][] nestedArray;
   public string[] stringArray;
   public test.Color[] enumArray;
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
   public us.ihmc.idl.IDLSequence.Enum<test.Color> enumSeqTest;
   public System.Collections.Generic.List<string> stringSeqTest;


   public void set(IDLElementTest other)
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

      nested.NestedElementPubSubType.staticCopy(other.nestedElementTest, nestedElementTest);
      stringTest = other.stringTest;

      for(int i1 = 0; i1 < longArray.length; ++i1)
      {
            longArray[i1] = other.longArray[i1];

      }

      for(int i3 = 0; i3 < nestedArray.length; ++i3)
      {
         for(int i4 = 0; i4 < nestedArray[i3].length; ++i4)
         {
               nested.NestedElementPubSubType.staticCopy(other.nestedArray[i3][i4], nestedArray[i3][i4]);}
      }

      for(int i6 = 0; i6 < stringArray.length; ++i6)
      {
            stringArray[i6].setLength(0);
            stringArray[i6].append(other.stringArray[i6]);
      }

      for(int i8 = 0; i8 < enumArray.length; ++i8)
      {
            enumArray[i8] = other.enumArray[i8];

      }

      charSeqTest.set(other.charSeqTest);
      wcharSeqTest.set(other.wcharSeqTest);
      octetSeqTest.set(other.octetSeqTest);
      shortSeqTest.set(other.shortSeqTest);
      ushortSeqTest.set(other.ushortSeqTest);
      longSeqTest.set(other.longSeqTest);
      ulongSeqTest.set(other.ulongSeqTest);
      longlongSeqtest.set(other.longlongSeqtest);
      ulonglongSeqTest.set(other.ulonglongSeqTest);
      floatSeqTest.set(other.floatSeqTest);
      doubleSeqTest.set(other.doubleSeqTest);
      booleanSeqTest.set(other.booleanSeqTest);
      nestedSeqTest.set(other.nestedSeqTest);
      enumSeqTest.set(other.enumSeqTest);
      stringSeqTest.set(other.stringSeqTest);
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("IDLElementTest {");
      builder.Append("charTest=");
      builder.Append(this.charTest_);      Append.append(", ");
      builder.Append("wcharTest=");
      builder.Append(this.wcharTest_);      Append.append(", ");
      builder.Append("octetTest=");
      builder.Append(this.octetTest_);      Append.append(", ");
      builder.Append("shortTest=");
      builder.Append(this.shortTest_);      Append.append(", ");
      builder.Append("ushortTest=");
      builder.Append(this.ushortTest_);      Append.append(", ");
      builder.Append("longTest=");
      builder.Append(this.longTest_);      Append.append(", ");
      builder.Append("ulongTest=");
      builder.Append(this.ulongTest_);      Append.append(", ");
      builder.Append("longlongTest=");
      builder.Append(this.longlongTest_);      Append.append(", ");
      builder.Append("ulonglongTest=");
      builder.Append(this.ulonglongTest_);      Append.append(", ");
      builder.Append("floatTest=");
      builder.Append(this.floatTest_);      Append.append(", ");
      builder.Append("doubleTest=");
      builder.Append(this.doubleTest_);      Append.append(", ");
      builder.Append("booleanTest=");
      builder.Append(this.booleanTest_);      Append.append(", ");
      builder.Append("colorTest=");
      builder.Append(this.colorTest_);      Append.append(", ");
      builder.Append("nestedElementTest=");
      builder.Append(this.nestedElementTest_);      Append.append(", ");
      builder.Append("stringTest=");
      builder.Append(this.stringTest_);      Append.append(", ");
      builder.Append("longArray=");
      builder.Append(java.util.Arrays.toString(this.longArray_));      Append.append(", ");
      builder.Append("nestedArray=");
      builder.Append(java.util.Arrays.deepToString(this.nestedArray_));      Append.append(", ");
      builder.Append("stringArray=");
      builder.Append(java.util.Arrays.toString(this.stringArray_));      Append.append(", ");
      builder.Append("enumArray=");
      builder.Append(java.util.Arrays.toString(this.enumArray_));      Append.append(", ");
      builder.Append("charSeqTest=");
      builder.Append(this.charSeqTest_);      Append.append(", ");
      builder.Append("wcharSeqTest=");
      builder.Append(this.wcharSeqTest_);      Append.append(", ");
      builder.Append("octetSeqTest=");
      builder.Append(this.octetSeqTest_);      Append.append(", ");
      builder.Append("shortSeqTest=");
      builder.Append(this.shortSeqTest_);      Append.append(", ");
      builder.Append("ushortSeqTest=");
      builder.Append(this.ushortSeqTest_);      Append.append(", ");
      builder.Append("longSeqTest=");
      builder.Append(this.longSeqTest_);      Append.append(", ");
      builder.Append("ulongSeqTest=");
      builder.Append(this.ulongSeqTest_);      Append.append(", ");
      builder.Append("longlongSeqtest=");
      builder.Append(this.longlongSeqtest_);      Append.append(", ");
      builder.Append("ulonglongSeqTest=");
      builder.Append(this.ulonglongSeqTest_);      Append.append(", ");
      builder.Append("floatSeqTest=");
      builder.Append(this.floatSeqTest_);      Append.append(", ");
      builder.Append("doubleSeqTest=");
      builder.Append(this.doubleSeqTest_);      Append.append(", ");
      builder.Append("booleanSeqTest=");
      builder.Append(this.booleanSeqTest_);      Append.append(", ");
      builder.Append("nestedSeqTest=");
      builder.Append(this.nestedSeqTest_);      Append.append(", ");
      builder.Append("enumSeqTest=");
      builder.Append(this.enumSeqTest_);      Append.append(", ");
      builder.Append("stringSeqTest=");
      builder.Append(this.stringSeqTest_);
      builder.Append("}");
      return builder.ToString();
   }
}


}