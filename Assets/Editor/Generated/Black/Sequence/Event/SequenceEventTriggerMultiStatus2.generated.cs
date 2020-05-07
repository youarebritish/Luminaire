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
            
			fieldProperties.AddProperty(new Property("eventType_", 1538691464, "Black.Actor.Node.ActorNodeTrigger.EventIDType", 1256, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("eventTypeLast_", 1300223960, "Black.Actor.Node.ActorNodeTrigger.EventIDType", 1260, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("canCatchSameTimeEvents_", 3277120883, "bool", 1264, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("canCatchSameTimeEventsPerfectly_", 1825747537, "bool", 1265, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}