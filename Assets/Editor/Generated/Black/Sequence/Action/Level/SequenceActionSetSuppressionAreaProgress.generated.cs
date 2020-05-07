using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionSetSuppressionAreaProgress : Black.Sequence.Action.Level.SequenceActionSuppressionAreaBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin progressPercentIn_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin progressPercentOut_;
		public int progressPercent_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetSuppressionAreaProgress();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionSetSuppressionAreaProgress", 0, Black.Sequence.Action.Level.SequenceActionSetSuppressionAreaProgress.ObjectType, null, properties, 0, 808);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionSetSuppressionAreaProgress", base.GetFieldProperties(), -2111490433, -1695153001);
            
			
			
			return fieldProperties;
        }

		
    }
}