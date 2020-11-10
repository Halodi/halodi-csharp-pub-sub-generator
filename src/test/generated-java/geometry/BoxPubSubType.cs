namespace geometry
{

/**
* 
* Topic data type of the struct "Box" defined in "Vector.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Vector.idl by us.ihmc.idl.generator.IDLGenerator. 
* Do not update this file directly, edit Vector.idl instead.
*
*/
public class BoxPubSubType : Halodi.TopicDataType<geometry.Box>
{
   public const string name = "geometry::Box";


   private final us.ihmc.idl.CDR serializeCDR = new us.ihmc.idl.CDR();
   private final us.ihmc.idl.CDR deserializeCDR = new us.ihmc.idl.CDR();

   @Override
   public void serialize(geometry.Box data, us.ihmc.pubsub.common.SerializedPayload serializedPayload) throws java.io.IOException
   {
      serializeCDR.serialize(serializedPayload);
      write(data, serializeCDR);
      serializeCDR.finishSerialize();
   }

   @Override
   public void deserialize(us.ihmc.pubsub.common.SerializedPayload serializedPayload, geometry.Box data) throws java.io.IOException
   {
      deserializeCDR.deserialize(serializedPayload);
      read(data, deserializeCDR);
      deserializeCDR.finishDeserialize();
   }

   public final static int getCdrSerializedSize(geometry.Box data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(geometry.Box data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += geometry.VectorPubSubType.getCdrSerializedSize(data.getCenter(), current_alignment);

      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);


      current_alignment += 8 + us.ihmc.idl.CDR.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(geometry.Box data, us.ihmc.idl.CDR cdr)
   {
      geometry.VectorPubSubType.write(data.getCenter(), cdr);
      cdr.write_type_6(data.getW());

      cdr.write_type_6(data.getL());

      cdr.write_type_6(data.getH());

   }

   public static void read(geometry.Box data, us.ihmc.idl.CDR cdr)
   {
      geometry.VectorPubSubType.read(data.Center, cdr);
      	
      data.W=cdr.read_type_6());
      	
      data.L=cdr.read_type_6());
      	
      data.H=cdr.read_type_6());
      	

   }



   public override string getName()
   {
      return name;
   }
   
   public void serialize(geometry.Box data, us.ihmc.idl.CDR cdr)
   {
      write(data, cdr);
   }

   public void deserialize(geometry.Box data, us.ihmc.idl.CDR cdr)
   {
      read(data, cdr);
   }
}


}