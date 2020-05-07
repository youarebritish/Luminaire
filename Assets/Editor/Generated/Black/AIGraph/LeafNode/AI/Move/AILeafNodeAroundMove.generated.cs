using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move
{
    public partial class AILeafNodeAroundMove : Black.AIGraph.LeafNode.AI.Move.AILeafNodeMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum aroundType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat offsetNear_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat offsetFar_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat offsetAngleDeg_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat moveSpeed;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool ignoreRadiusForArrival;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeAroundMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.AILeafNodeAroundMove", 0, Black.AIGraph.LeafNode.AI.Move.AILeafNodeAroundMove.ObjectType, null, properties, 0, 808);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.AILeafNodeAroundMove", base.GetFieldProperties(), -2041733061, 1932227569);
            return fieldProperties;
        }

		
    }
}