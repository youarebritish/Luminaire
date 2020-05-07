using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Buddy
{
    public partial class SequenceActionAIBuddyCheckSubLocation : Black.Sequence.Actor.AI.SequenceActionAIBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin manualCheckPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enableAutoCheckPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disableAutoCheckPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin manualTruePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin manualFalsePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin autoTagInPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin autoTagOutPin_;
		public bool isEnableAutoCheck_;
		public int targetBuddy_;
		public int checkMode_;
		public uint tag1ID_;
		public uint tag2ID_;
		public uint tag3ID_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIBuddyCheckSubLocation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyCheckSubLocation", 0, Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyCheckSubLocation.ObjectType, null, properties, 0, 1072);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyCheckSubLocation", base.GetFieldProperties(), 2040144236, -572741183);
            
			
			
			return fieldProperties;
        }

		
    }
}