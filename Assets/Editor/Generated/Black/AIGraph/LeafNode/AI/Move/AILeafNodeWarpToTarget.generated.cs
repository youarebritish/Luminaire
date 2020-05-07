using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move
{
    public partial class AILeafNodeWarpToTarget : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum positionType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum warpTarget;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool obstructed;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool useNearestPointOnNavMesh;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector warpOffset;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat maxMoveDistance;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool useRotateTarget;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum rotationType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum rotateTarget;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt divisionNumber;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool resetMotion;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeWarpToTarget();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.AILeafNodeWarpToTarget", 0, Black.AIGraph.LeafNode.AI.Move.AILeafNodeWarpToTarget.ObjectType, null, properties, 0, 544);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.AILeafNodeWarpToTarget", base.GetFieldProperties(), 415373291, 1099973546);
            return fieldProperties;
        }

		
    }
}