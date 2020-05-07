using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move.Nifl
{
    public partial class AILeafNodeJumpMove : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat jumpDistanceMin;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat jumpDistanceMax;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat jumpEnableAngle;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat jumpTimeMin;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat jumpTimeMax;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeJumpMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.Nifl.AILeafNodeJumpMove", 0, Black.AIGraph.LeafNode.AI.Move.Nifl.AILeafNodeJumpMove.ObjectType, null, properties, 0, 272);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.Nifl.AILeafNodeJumpMove", base.GetFieldProperties(), -2140785399, -1932789268);
            
			
			
			return fieldProperties;
        }

		
    }
}