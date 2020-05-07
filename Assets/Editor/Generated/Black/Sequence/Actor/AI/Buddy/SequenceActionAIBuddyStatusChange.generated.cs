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
            
			
			
			return fieldProperties;
        }

		
    }
}