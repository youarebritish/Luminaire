using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionTryDinerFirstTimeCondition : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dinerIdPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin yesPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin noPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTryDinerFirstTimeCondition();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionTryDinerFirstTimeCondition", 0, Black.Sequence.Action.Level.SequenceActionTryDinerFirstTimeCondition.ObjectType, null, properties, 0, 648);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionTryDinerFirstTimeCondition", base.GetFieldProperties(), -388789525, 607777187);
            
			
			
			return fieldProperties;
        }

		
    }
}