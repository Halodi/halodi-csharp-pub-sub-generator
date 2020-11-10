namespace geometry
{

/**
* 
* Topic data type of the struct "Polygon" defined in "Vector.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Vector.idl by us.ihmc.idl.generator.IDLGenerator. 
* Do not update this file directly, edit Vector.idl instead.
*
*/
public class PolygonPubSubType : Halodi.TopicDataType<geometry.Polygon>
{
   public const string name = "geometry::Polygon";


   private final us.ihmc.idl.CDR serializeCDR = new us.ihmc.idl.CDR();
   private final us.ihmc.idl.CDR deserializeCDR = new us.ihmc.idl.CDR();

   @Override
   public void serialize(geometry.Polygon data, us.ihmc.pubsub.common.SerializedPayload serializedPayload) throws java.io.IOException
   {
      serializeCDR.serialize(serializedPayload);
      write(data, serializeCDR);
      serializeCDR.finishSerialize();
   }

   @Override
   public void deserialize(us.ihmc.pubsub.common.SerializedPayload serializedPayload, geometry.Polygon data) throws java.io.IOException
   {
      deserializeCDR.deserialize(serializedPayload);
      read(data, deserializeCDR);
      deserializeCDR.finishDeserialize();
   }

   public final static int getCdrSerializedSize(geometry.Polygon data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public final static int getCdrSerializedSize(geometry.Polygon data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.getPoints().size(); ++i0)
      {
          current_alignment += geometry.VectorPubSubType.getCdrSerializedSize(data.getPoints().get(i0), current_alignment);}

      return current_alignment - initial_alignment;
   }

   public static void write(geometry.Polygon data, us.ihmc.idl.CDR cdr)
   {
      cdr.write_type_e(data.getPoints());

   }

   public static void read(geometry.Polygon data, us.ihmc.idl.CDR cdr)
   {

      int Points_length = cdr.read_type_2();
      data.Points = new System.Collections.Generic.List<geometry.Vector>(Points_length);
      for(int i = 0; i < Points_length; i++)
      {
      	geometry.VectorPubSubType.read(data.Points, cdr);	
      	
      }
      	

   }



   public override string getName()
   {
      return name;
   }
   
   public void serialize(geometry.Polygon data, us.ihmc.idl.CDR cdr)
   {
      write(data, cdr);
   }

   public void deserialize(geometry.Polygon data, us.ihmc.idl.CDR cdr)
   {
      read(data, cdr);
   }
}


}