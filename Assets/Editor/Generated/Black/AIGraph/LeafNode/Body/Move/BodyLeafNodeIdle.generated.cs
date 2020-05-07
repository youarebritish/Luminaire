using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Body.Move
{
    public partial class BodyLeafNodeIdle : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat timeForMaskingNextTurn;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat timeForMaskingMove;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat thresholdMoveBeginVelocity;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyLeafNodeIdle();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.Move.BodyLeafNodeIdle", 0, Black.AIGraph.LeafNode.Body.Move.BodyLeafNodeIdle.ObjectType, null, properties, 0, 160);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.Move.BodyLeafNodeIdle", base.GetFieldProperties(), -1416090386, 740873848);
            
			
			
			return fieldProperties;
        }

		
    }
}