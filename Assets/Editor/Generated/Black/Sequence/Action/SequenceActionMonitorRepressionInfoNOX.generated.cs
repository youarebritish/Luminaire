using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action
{
    public partial class SequenceActionMonitorRepressionInfoNOX : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionMonitorRepressionInfoNOX();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.SequenceActionMonitorRepressionInfoNOX", 0, Black.Sequence.Action.SequenceActionMonitorRepressionInfoNOX.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.SequenceActionMonitorRepressionInfoNOX", base.GetFieldProperties(), 1449938305, -1571494330);
            return fieldProperties;
        }

		
    }
}