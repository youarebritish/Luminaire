using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event
{
    public partial class SequenceEventRectangleTrigger : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin triggerPointPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin touch_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin back_;
		public uint eventId_;
		public string eventString_;
		public int eventType_;
		public SQEX.Ebony.Framework.Entity.TransformEntity entityPointer_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventRectangleTrigger();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.SequenceEventRectangleTrigger", 0, Black.Sequence.Event.SequenceEventRectangleTrigger.ObjectType, null, properties, 0, 520);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.SequenceEventRectangleTrigger", base.GetFieldProperties(), -791579074, 1065401547);
            
			
			
			return fieldProperties;
        }

		
    }
}