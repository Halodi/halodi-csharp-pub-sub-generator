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
public class VectorPubSubType : Halodi.TopicDataType<geometry.Vector>
{
   public const string name = "geometry::Vector";


   @Override
   public void serialize(geometry.Vector data, MemoryStream stream) throws java.io.IOException
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   @Override
   public void deserialize(MemoryStream stream, geometry.Vector data) throws java.io.IOException
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(stream);
   	   		read(data, cdr); 
   	   }
   }

   public final static int getCdrSerializedSize(geometry.Vector data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(geometry.Vector data, int current_alignment)
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
      cdr.write_type_d(data.getFrame());

      cdr.write_type_6(data.getX());

      cdr.write_type_6(data.getY());

      cdr.write_type_6(data.getZ());

      cdr.write_type_e(data.getBla());

      for(int i0 = 0; i0 < data.getWaa().length; ++i0)
      {
        	cdr.write_type_6(data.getWaa()[i0]);	
      }

   }

   public static void read(geometry.Vector data, Halodi.CDR.CDRDeserializer cdr)
   {
      cdr.read_type_d(data.getFrame());	
      data.X=cdr.read_type_6());
      	
      data.Y=cdr.read_type_6());
      	
      data.Z=cdr.read_type_6());
      	

      int Bla_length = cdr.read_type_2();
      data.Bla = new System.Collections.Generic.List<double>(Bla_length);
      for(int i = 0; i < Bla_length; i++)
      {
      	data.Bla.Add(cdr.read_type_6());
      	
      	
      }
      	
      for(int i0 = 0; i0 < data.Waa.length; ++i0)
      {
        	data.Waa[i0] = cdr.read_type_6();
        	
      }
      	

   }



   public override string getName()
   {
      return name;
   }
   

}


}