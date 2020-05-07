using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Decision
{
    public partial class SequenceActionDecisionPointInArea : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin inside_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outside_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin checkPointPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin centerPointPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin radiusPin_;
		public float radius_;
		public float areaRatioMin_;
		public float areaRatioMax_;
		public bool isCheckY_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDecisionPointInArea();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Decision.SequenceActionDecisionPointInArea", 0, Black.Sequence.Action.Level.Decision.SequenceActionDecisionPointInArea.ObjectType, null, properties, 0, 744);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Decision.SequenceActionDecisionPointInArea", base.GetFieldProperties(), -902795351, 794370782);
            return fieldProperties;
        }

		
    }
}