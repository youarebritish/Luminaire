using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionStrategyTarget : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin selectHostPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin cancelPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin suggestPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin hostSelectedPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin decidedPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin strategySelectedPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin strategySuggestedPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin canceledPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin suggesterPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin suggestedStrategyPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin hostPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin hostNamePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin hostFaceIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin strategyNameIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin strategyInfoIdPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionStrategyTarget();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionStrategyTarget", 0, Black.Sequence.Action.Menu.SequenceActionStrategyTarget.ObjectType, null, properties, 0, 1576);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionStrategyTarget", base.GetFieldProperties(), -647600892, 360717955);
            
			
			
			return fieldProperties;
        }

		
    }
}