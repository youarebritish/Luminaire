using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event
{
    public partial class SequenceEventTriggerMultiStatus : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin triggerPointPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin remoteEvent_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin touch_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin unTouch_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin attackIn_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin attackOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin causedActorList_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin causedActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin triggerActor_;
		public uint eventId_;
		public string eventString_;
		public bool waitEntity_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventTriggerMultiStatus();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.SequenceEventTriggerMultiStatus", 0, Black.Sequence.Event.SequenceEventTriggerMultiStatus.ObjectType, null, properties, 0, 1256);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.SequenceEventTriggerMultiStatus", base.GetFieldProperties(), -1156489521, 1893751096);
            return fieldProperties;
        }

		
    }
}