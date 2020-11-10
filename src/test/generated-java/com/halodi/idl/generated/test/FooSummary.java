package com.halodi.idl.generated.test;

import us.ihmc.communication.packets.Packet;
import us.ihmc.euclid.interfaces.Settable;
import us.ihmc.euclid.interfaces.EpsilonComparable;
import java.util.function.Supplier;
import us.ihmc.pubsub.TopicDataType;

public class FooSummary extends Packet<FooSummary> implements Settable<FooSummary>, EpsilonComparable<FooSummary>
{
   public bool createSummary_;
   public string summaryTriggerVariable_;
   public us.ihmc.idl.IDLSequence.Object<string>  summarizedVariables_;

   public FooSummary()
   {
      summaryTriggerVariable_ = new string(1024);
      summarizedVariables_ = new us.ihmc.idl.IDLSequence.Object<string> (128, "type_d");
   }

   public FooSummary(FooSummary other)
   {
      this();
      set(other);
   }

   public void set(FooSummary other)
   {
      createSummary_ = other.createSummary_;

      summaryTriggerVariable_.setLength(0);
      summaryTriggerVariable_.append(other.summaryTriggerVariable_);

      summarizedVariables_.set(other.summarizedVariables_);
   }

   public void setCreateSummary(bool createSummary)
   {
      createSummary_ = createSummary;
   }
   public bool getCreateSummary()
   {
      return createSummary_;
   }

   public void setSummaryTriggerVariable(java.lang.String summaryTriggerVariable)
   {
      summaryTriggerVariable_.setLength(0);
      summaryTriggerVariable_.append(summaryTriggerVariable);
   }

   public java.lang.String getSummaryTriggerVariableAsString()
   {
      return getSummaryTriggerVariable().toString();
   }
   public string getSummaryTriggerVariable()
   {
      return summaryTriggerVariable_;
   }


   public us.ihmc.idl.IDLSequence.Object<string>  getSummarizedVariables()
   {
      return summarizedVariables_;
   }


   public static Supplier<FooSummaryPubSubType> getPubSubType()
   {
      return FooSummaryPubSubType::new;
   }

   @Override
   public Supplier<TopicDataType> getPubSubTypePacket()
   {
      return FooSummaryPubSubType::new;
   }

   @Override
   public boolean epsilonEquals(FooSummary other, double epsilon)
   {
      if(other == null) return false;
      if(other == this) return true;

      if (!us.ihmc.idl.IDLTools.epsilonEqualsBoolean(this.createSummary_, other.createSummary_, epsilon)) return false;

      if (!us.ihmc.idl.IDLTools.epsilonEqualsStringBuilder(this.summaryTriggerVariable_, other.summaryTriggerVariable_, epsilon)) return false;

      if (this.summarizedVariables_.size() != other.summarizedVariables_.size()) { return false; }
      else
      {
         for (int i = 0; i < this.summarizedVariables_.size(); i++)
         {  if (!this.summarizedVariables_.get(i).epsilonEquals(other.summarizedVariables_.get(i), epsilon)) return false; }
      }


      return true;
   }

   @Override
   public boolean equals(Object other)
   {
      if(other == null) return false;
      if(other == this) return true;
      if(!(other instanceof FooSummary)) return false;

      FooSummary otherMyClass = (FooSummary) other;

      if(this.createSummary_ != otherMyClass.createSummary_) return false;

      if (!us.ihmc.idl.IDLTools.equals(this.summaryTriggerVariable_, otherMyClass.summaryTriggerVariable_)) return false;

      if (!this.summarizedVariables_.equals(otherMyClass.summarizedVariables_)) return false;

      return true;
   }

   @Override
   public java.lang.String toString()
   {
      StringBuilder builder = new StringBuilder();

      builder.append("FooSummary {");
      builder.append("createSummary=");
      builder.append(this.createSummary_);      builder.append(", ");
      builder.append("summaryTriggerVariable=");
      builder.append(this.summaryTriggerVariable_);      builder.append(", ");
      builder.append("summarizedVariables=");
      builder.append(this.summarizedVariables_);
      builder.append("}");
      return builder.toString();
   }
}
