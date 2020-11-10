package geometry;

/**
* 
* Topic data type of the struct "Polygon" defined in "Vector.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Vector.idl by us.ihmc.idl.generator.IDLGenerator. 
* Do not update this file directly, edit Vector.idl instead.
*
*/
public class PolygonPubSubType implements us.ihmc.pubsub.TopicDataType<geometry.Polygon>
{
   public static final java.lang.String name = "geometry::Polygon";

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

   public static int getMaxCdrSerializedSize()
   {
      return getMaxCdrSerializedSize(0);
   }

   public static int getMaxCdrSerializedSize(int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + us.ihmc.idl.CDR.alignment(current_alignment, 4);for(int i0 = 0; i0 < 100; ++i0)
      {
          current_alignment += geometry.VectorPubSubType.getMaxCdrSerializedSize(current_alignment);}
      return current_alignment - initial_alignment;
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
      if(data.getPoints().size() <= 100)
      cdr.write_type_e(data.getPoints());else
          throw new RuntimeException("points field exceeds the maximum length");

   }

   public static void read(geometry.Polygon data, us.ihmc.idl.CDR cdr)
   {
      cdr.read_type_e(data.getPoints());	

   }

   @Override
   public final void serialize(geometry.Polygon data, us.ihmc.idl.InterchangeSerializer ser)
   {
      ser.write_type_e("points", data.getPoints());
   }

   @Override
   public final void deserialize(us.ihmc.idl.InterchangeSerializer ser, geometry.Polygon data)
   {
      ser.read_type_e("points", data.getPoints());
   }

   public static void staticCopy(geometry.Polygon src, geometry.Polygon dest)
   {
      dest.set(src);
   }

   @Override
   public geometry.Polygon createData()
   {
      return new geometry.Polygon();
   }
   @Override
   public int getTypeSize()
   {
      return us.ihmc.idl.CDR.getTypeSize(getMaxCdrSerializedSize());
   }

   @Override
   public java.lang.String getName()
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
   
   public void copy(geometry.Polygon src, geometry.Polygon dest)
   {
      staticCopy(src, dest);
   }

   @Override
   public PolygonPubSubType newInstance()
   {
      return new PolygonPubSubType();
   }
}
