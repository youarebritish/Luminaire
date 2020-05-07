using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action
{
    public partial class SequenceActionSetRepressionInfoNOX : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int messageType_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin messageId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetRepressionInfoNOX();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.SequenceActionSetRepressionInfoNOX", 0, Black.Sequence.Action.SequenceActionSetRepressionInfoNOX.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.SequenceActionSetRepressionInfoNOX", base.GetFieldProperties(), 1631953689, -907352845);
            
			
			
			return fieldProperties;
        }

		
    }
}