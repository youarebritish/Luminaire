using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move
{
    public partial class AILeafNodeApproachPoint : Black.AIGraph.LeafNode.AI.Move.AILeafNodeMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector targetPoint;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat arrivalDistance;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat failedDistance;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat moveSpeed;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool ignoreRadiusForArrival;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool checkVisiblityClearingForArrival;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeApproachPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.AILeafNodeApproachPoint", 0, Black.AIGraph.LeafNode.AI.Move.AILeafNodeApproachPoint.ObjectType, null, properties, 0, 800);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.AILeafNodeApproachPoint", base.GetFieldProperties(), -392406948, 1209729843);
            
			
			
			return fieldProperties;
        }

		
    }
}