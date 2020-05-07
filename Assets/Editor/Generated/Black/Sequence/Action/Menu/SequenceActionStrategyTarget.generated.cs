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
            
			fieldProperties.AddProperty(new Property("selectHostPin_", 3711539, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cancelPin_", 1871818839, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("suggestPin_", 3469779441, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("hostSelectedPin_", 947422846, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("decidedPin_", 501229515, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("strategySelectedPin_", 852167977, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("strategySuggestedPin_", 3872969419, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 752, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("canceledPin_", 2029360058, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 848, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("suggesterPin_", 4000660038, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 944, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("suggestedStrategyPin_", 3392160653, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1032, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("hostPin_", 2952162907, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1120, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("hostNamePin_", 980870460, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1208, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("hostFaceIdPin_", 774153015, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1296, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("strategyNameIdPin_", 1899696290, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1384, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("strategyInfoIdPin_", 565937553, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1472, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}