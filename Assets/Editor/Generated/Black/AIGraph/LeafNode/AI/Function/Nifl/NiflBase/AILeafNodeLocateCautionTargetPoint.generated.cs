using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function.Nifl.NiflBase
{
    public partial class AILeafNodeLocateCautionTargetPoint : Black.AIGraph.LeafNode.AI.Move.AILeafNodeApproachMove
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeLocateCautionTargetPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.Nifl.NiflBase.AILeafNodeLocateCautionTargetPoint", 0, Black.AIGraph.LeafNode.AI.Function.Nifl.NiflBase.AILeafNodeLocateCautionTargetPoint.ObjectType, null, properties, 0, 880);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.Nifl.NiflBase.AILeafNodeLocateCautionTargetPoint", base.GetFieldProperties(), -1721927619, 407982526);
            return fieldProperties;
        }

		
    }
}