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
            
			fieldProperties.AddProperty(new Property("triggerPointPin_", 846860007, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 176, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("remoteEvent_", 3639870650, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 264, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("touch_", 2860744581, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 360, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("unTouch_", 2975892838, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 456, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("attackIn_", 2471703499, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 552, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("attackOut_", 2947025912, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 648, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("causedActorList_", 2501124410, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 744, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("causedActor_", 1920287630, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 832, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("triggerActor_", 3722828613, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 920, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("eventId_", 548562519, "SQEX.Ebony.Std.Fixid", 1008, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("eventString_", 3649127407, "Ebony.Base.String", 1016, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("waitEntity_", 3335877996, "bool", 1032, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}