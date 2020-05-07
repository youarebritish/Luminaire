using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move.Nifl
{
    public partial class AILeafNodeFlyReinforceMove : Black.AIGraph.LeafNode.AI.Move.AILeafNodeMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat goalHeightOffset_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat goalOffsetHorizonal_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat destinationUpdateTime_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool forceUseReinforceDestination_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool noUpdateReinfoceDestination_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid queryFixid_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat descendingPointLockDistance_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat destinationRefreshTime_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat destinationRefreshDistance_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt combatEnemiesObservationModeCount_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool ignoreObservationMode_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeFlyReinforceMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.Nifl.AILeafNodeFlyReinforceMove", 0, Black.AIGraph.LeafNode.AI.Move.Nifl.AILeafNodeFlyReinforceMove.ObjectType, null, properties, 0, 1136);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.Nifl.AILeafNodeFlyReinforceMove", base.GetFieldProperties(), 247789990, -1131115834);
            
			
			
			return fieldProperties;
        }

		
    }
}