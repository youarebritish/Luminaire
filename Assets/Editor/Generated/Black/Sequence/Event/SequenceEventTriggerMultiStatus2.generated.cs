using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event
{
    public partial class SequenceEventTriggerMultiStatus2 : Black.Sequence.Event.SequenceEventTriggerMultiStatus
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int eventType_;
		public int eventTypeLast_;
		public bool canCatchSameTimeEvents_;
		public bool canCatchSameTimeEventsPerfectly_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventTriggerMultiStatus2();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.SequenceEventTriggerMultiStatus2", 0, Black.Sequence.Event.SequenceEventTriggerMultiStatus2.ObjectType, null, properties, 0, 1272);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.SequenceEventTriggerMultiStatus2", base.GetFieldProperties(), -216561193, 1251124514);
            return fieldProperties;
        }

		
    }
}