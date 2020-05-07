using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event
{
    public partial class SequenceEventTriggerMultiStatusNew : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int eventType_;
		public uint eventId_;
		public bool canCatchSameTimeEvents_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventTriggerMultiStatusNew();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.SequenceEventTriggerMultiStatusNew", 0, Black.Sequence.Event.SequenceEventTriggerMultiStatusNew.ObjectType, null, properties, 0, 192);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.SequenceEventTriggerMultiStatusNew", base.GetFieldProperties(), -1010569147, 566084068);
            return fieldProperties;
        }

		
    }
}