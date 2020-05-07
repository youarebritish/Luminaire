using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event
{
    public partial class SequenceEventTitleFinished : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finish_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin isFinished_pin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventTitleFinished();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.SequenceEventTitleFinished", 0, Black.Sequence.Event.SequenceEventTitleFinished.ObjectType, null, properties, 0, 552);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.SequenceEventTitleFinished", base.GetFieldProperties(), -1707911744, -1977306550);
            return fieldProperties;
        }

		
    }
}