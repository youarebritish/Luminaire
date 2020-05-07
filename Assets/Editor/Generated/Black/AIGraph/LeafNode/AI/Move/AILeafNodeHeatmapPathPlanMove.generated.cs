using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move
{
    public partial class AILeafNodeHeatmapPathPlanMove : Black.AIGraph.LeafNode.AI.Move.AILeafNodeMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat arrivalDistance;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat failedDistance;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat moveSpeed;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat heatHeuristicPower;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid heatMapFixid_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid TPSfixid;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeHeatmapPathPlanMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.AILeafNodeHeatmapPathPlanMove", 0, Black.AIGraph.LeafNode.AI.Move.AILeafNodeHeatmapPathPlanMove.ObjectType, null, properties, 0, 776);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.AILeafNodeHeatmapPathPlanMove", base.GetFieldProperties(), -468951171, 1777268169);
            
			
			
			return fieldProperties;
        }

		
    }
}