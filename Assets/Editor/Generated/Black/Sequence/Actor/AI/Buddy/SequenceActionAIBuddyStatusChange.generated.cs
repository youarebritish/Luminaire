using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Buddy
{
    public partial class SequenceActionAIBuddyStatusChange : Black.Sequence.Actor.AI.SequenceActionAIBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fixidPin_;
		public int targetBuddy_;
		public int statusType_;
		public int paramSetType_;
		public int paramSetFloatType_;
		public int paramSetOnlySetType_;
		public int paramSetListType_;
		public float floatValue_;
		public bool boolValue_;
		public int buddyTypeValue_;
		public int locationTypeValue_;
		public uint locationID_;
		public uint subLocationID_;
		public uint formationTypeID_;
		public int partyStateValue_;
		public int vehicleType_;
		public int temperType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIBuddyStatusChange();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyStatusChange", 0, Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyStatusChange.ObjectType, null, properties, 0, 616);
        }
		
        public override ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected override PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyStatusChange", base.GetFieldProperties(), 770899852, -256569106);
            
			fieldProperties.AddProperty(new Property("inPin_", 3408135614, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 184, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorPin_", 3381458010, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 280, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPin_", 2732252299, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fixidPin_", 1213852305, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 464, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetBuddy_", 156417829, "Black.AI.Buddy.BUDDY_TYPE", 552, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("statusType_", 4144029240, "Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyStatusChange.PARAMETER_TYPE", 556, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("paramSetType_", 775395959, "Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyStatusChange.PARAM_SET_TYPE", 560, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("paramSetFloatType_", 2763947477, "Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyStatusChange.PARAM_SET_FLOAT_TYPE", 564, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("paramSetOnlySetType_", 2181624385, "Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyStatusChange.PARAM_SET_ONLYSET_TYPE", 568, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("paramSetListType_", 1530120019, "Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyStatusChange.PARAM_SET_LIST_TYPE", 572, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("floatValue_", 1151188527, "float", 576, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("boolValue_", 1804834631, "bool", 580, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("buddyTypeValue_", 67093029, "Black.AI.Buddy.BUDDY_TYPE", 584, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("locationTypeValue_", 2408608536, "Black.AI.Buddy.LOCATION_TYPE", 588, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("locationID_", 1729695148, "SQEX.Ebony.Std.Fixid", 592, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("subLocationID_", 1588007804, "SQEX.Ebony.Std.Fixid", 596, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("formationTypeID_", 2852642914, "SQEX.Ebony.Std.Fixid", 600, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("partyStateValue_", 3198519618, "Black.AI.Buddy.PARTY_STATE", 604, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("vehicleType_", 1194594424, "Black.AI.Buddy.BUDDY_VEHICLE_STATE", 608, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("temperType_", 2574535249, "Black.AI.Buddy.TEMPERATURE_TYPE", 612, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}