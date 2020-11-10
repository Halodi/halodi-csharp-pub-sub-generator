namespace geometry
{

/**
* 
* Topic data type of the struct "Triangle" defined in "Vector.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Vector.idl by us.ihmc.idl.generator.IDLGenerator. 
* Do not update this file directly, edit Vector.idl instead.
*
*/
public class TrianglePubSubType : Halodi.TopicDataType<geometry.Triangle>
{
   public const string name = "geometry::Triangle";


   private final us.ihmc.idl.CDR serializeCDR = new us.ihmc.idl.CDR();
   private final us.ihmc.idl.CDR deserializeCDR = new us.ihmc.idl.CDR();

   @Override
   public void serialize(geometry.Triangle data, us.ihmc.pubsub.common.SerializedPayload serializedPayload) throws java.io.IOException
   {
      serializeCDR.serialize(serializedPayload);
      write(data, serializeCDR);
      serializeCDR.finishSerialize();
   }

   @Override
   public void deserialize(us.ihmc.pubsub.common.SerializedPayload serializedPayload, geometry.Triangle data) throws java.io.IOException
   {
      deserializeCDR.deserialize(serializedPayload);
      read(data, deserializeCDR);
      deserializeCDR.finishDeserialize();
   }

   public final static int getCdrSerializedSize(geometry.Triangle data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(geometry.Triangle data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      for(int i0 = 0; i0 < data.getPoints().length; ++i0)
      {
              current_alignment += geometry.VectorPubSubType.getCdrSerializedSize(data.getPoints()[i0], current_alignment);
      }
      return current_alignment - initial_alignment;
   }

   public static void write(geometry.Triangle data, us.ihmc.idl.CDR cdr)
   {
      for(int i0 = 0; i0 < data.getPoints().length; ++i0)
      {
        	geometry.VectorPubSubType.write(data.getPoints()[i0], cdr);		
      }
   }

   public static void read(geometry.Triangle data, us.ihmc.idl.CDR cdr)
   {
      for(int i0 = 0; i0 < data.Points.length; ++i0)
      {
        	geometry.VectorPubSubType.read(data.Points[i0], cdr);	
      }
      	

   }



   public override string getName()
   {
      return name;
   }
   
   public void serialize(geometry.Triangle data, us.ihmc.idl.CDR cdr)
   {
      write(data, cdr);
   }

   public void deserialize(geometry.Triangle data, us.ihmc.idl.CDR cdr)
   {
      read(data, cdr);
   }
}


}