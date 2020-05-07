using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Buddy
{
    public partial class SequenceActionAIBuddyCheckLocation : Black.Sequence.Actor.AI.SequenceActionAIBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enableAutoCheckPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disableAutoCheckPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin location1Pin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin location2Pin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin location3Pin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin location4Pin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin location5Pin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin otherPin_;
		public bool isEnableAutoCheck_;
		public int targetBuddy_;
		public uint location1ID_;
		public uint location2ID_;
		public uint location3ID_;
		public uint location4ID_;
		public uint location5ID_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIBuddyCheckLocation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyCheckLocation", 0, Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyCheckLocation.ObjectType, null, properties, 0, 1168);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyCheckLocation", base.GetFieldProperties(), -263308833, -1735638706);
            
			
			
			return fieldProperties;
        }

		
    }
}