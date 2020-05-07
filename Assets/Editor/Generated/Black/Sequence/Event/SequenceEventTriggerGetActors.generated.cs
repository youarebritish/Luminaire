using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event
{
    public partial class SequenceEventTriggerGetActors : SQEX.Ebony.Framework.Sequence.SequenceActivatableNode
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin triggerPointPin_;
		public int touchStatus_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventTriggerGetActors();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.SequenceEventTriggerGetActors", 0, Black.Sequence.Event.SequenceEventTriggerGetActors.ObjectType, null, properties, 0, 592);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.SequenceEventTriggerGetActors", base.GetFieldProperties(), 62774272, 578613706);
            return fieldProperties;
        }

		
    }
}