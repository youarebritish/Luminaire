using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move
{
    public partial class AILeafNodeAlignWithTarget : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat thresholdAngle_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat offsetAngle_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat timeOut_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeAlignWithTarget();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.AILeafNodeAlignWithTarget", 0, Black.AIGraph.LeafNode.AI.Move.AILeafNodeAlignWithTarget.ObjectType, null, properties, 0, 200);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.AILeafNodeAlignWithTarget", base.GetFieldProperties(), -458626031, -1093489149);
            return fieldProperties;
        }

		
    }
}