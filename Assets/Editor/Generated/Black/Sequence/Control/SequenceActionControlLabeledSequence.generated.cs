using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Control
{
    public partial class SequenceActionControlLabeledSequence : Black.Sequence.Control.SequenceActionControlLabeled
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inReset_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin abort_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionControlLabeledSequence();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Control.SequenceActionControlLabeledSequence", 0, Black.Sequence.Control.SequenceActionControlLabeledSequence.ObjectType, null, properties, 0, 584);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Control.SequenceActionControlLabeledSequence", base.GetFieldProperties(), 739400600, 1870408840);
            return fieldProperties;
        }

		
    }
}