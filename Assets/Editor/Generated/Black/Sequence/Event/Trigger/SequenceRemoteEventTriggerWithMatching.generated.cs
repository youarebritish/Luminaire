using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Trigger
{
    public partial class SequenceRemoteEventTriggerWithMatching : Black.Sequence.Event.Trigger.SequenceRemoteEventTrigger
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint labelId_;
		public uint matchingId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceRemoteEventTriggerWithMatching();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Trigger.SequenceRemoteEventTriggerWithMatching", 0, Black.Sequence.Event.Trigger.SequenceRemoteEventTriggerWithMatching.ObjectType, null, properties, 0, 328);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Trigger.SequenceRemoteEventTriggerWithMatching", base.GetFieldProperties(), 483763238, -2032179872);
            
			
			
			return fieldProperties;
        }

		
    }
}