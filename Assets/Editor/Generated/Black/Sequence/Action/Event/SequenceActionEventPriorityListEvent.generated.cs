using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Event
{
    public partial class SequenceActionEventPriorityListEvent : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin startCheckRequest_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin reserveRequest_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin reserveListPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin startCheckListPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionEventPriorityListEvent();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Event.SequenceActionEventPriorityListEvent", 0, Black.Sequence.Action.Event.SequenceActionEventPriorityListEvent.ObjectType, null, properties, 0, 552);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Event.SequenceActionEventPriorityListEvent", base.GetFieldProperties(), 1333187795, 1223019326);
            return fieldProperties;
        }

		
    }
}