using System.IO;
namespace geometry
{

/**
* 
* Topic data type of the struct "Vector" defined in "Vector.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Vector.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Vector.idl instead.
*
*/
public class VectorPubSubType : Halodi.CDR.TopicDataType<geometry.Vector>
{
   public const string name = "geometry::Vector";


   
   public override void serialize(geometry.Vector data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, geometry.Vector data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(stream);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(geometry.Vector data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry.Vector data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.getFrame().length() + 1;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.getBla().size() * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += ((3) * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);

      return current_alignment - initial_alignment;
   }

   public static void write(geometry.Vector data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_d(data.frame);

      cdr.write_type_6(data.x);

      cdr.write_type_6(data.y);

      cdr.write_type_6(data.z);


      	int bla_length = data.bla.Count;
            cdr.write_type_2(bla_length);
            for (int i0 = 0; i0 < bla_length; i0++)
            {
      			cdr.write_type_6(data.bla[i0]);
            }
      for(int i0 = 0; i0 < data.waa.length; ++i0)
      {
        	cdr.write_type_6(data.waa[i0]);	
      }

   }

   public static void read(geometry.Vector data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.frame = cdr.read_type_d();	
      data.x=cdr.read_type_6();
      	
      data.y=cdr.read_type_6();
      	
      data.z=cdr.read_type_6();
      	

      int bla_length = cdr.read_type_2();
      data.bla = new System.Collections.Generic.List<double>(bla_length);
      for(int i = 0; i < bla_length; i++)
      {
      	data.bla.Add(cdr.read_type_6());
      	
      	
      }

      	
      for(int i0 = 0; i0 < data.waa.Length; ++i0)
      {
        	data.waa[i0] = cdr.read_type_6();
        	
      }
      	

   }



   public override string getName()
   {
      return name;
   }
   

}


}