using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event
{
    public partial class SequenceEventOnchangedLabeledVariable : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin error_;
		public string labelName_;
		public string labelNames_;
		public int value_;
		public int condition_;
		public bool suppressTriggerAtLoading_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventOnchangedLabeledVariable();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.SequenceEventOnchangedLabeledVariable", 0, Black.Sequence.Event.SequenceEventOnchangedLabeledVariable.ObjectType, null, properties, 0, 416);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.SequenceEventOnchangedLabeledVariable", base.GetFieldProperties(), 1129894125, -192124905);
            return fieldProperties;
        }

		
    }
}