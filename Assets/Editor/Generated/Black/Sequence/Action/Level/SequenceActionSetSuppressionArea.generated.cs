using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionSetSuppressionArea : Black.Sequence.Action.Level.SequenceActionSuppressionAreaBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin battleAreaPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enemyListPin_;
		public int enemyToKill_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enemyToKillPin_;
		public IList<SQEX.Ebony.Framework.Utility.FixidArrayItem> battleAreaIdList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetSuppressionArea();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionSetSuppressionArea", 0, Black.Sequence.Action.Level.SequenceActionSetSuppressionArea.ObjectType, null, properties, 0, 912);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionSetSuppressionArea", base.GetFieldProperties(), -304973943, 247361967);
            
			
			
			return fieldProperties;
        }

		
    }
}