using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move
{
    public partial class AILeafNodeHeatMapMove : Black.AIGraph.LeafNode.AI.Move.AILeafNodeMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat rangeLowerBound;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat rangeUpperBound;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool ascendHeat;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat moveSpeed;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid mapDescriptorFixid;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeHeatMapMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.AILeafNodeHeatMapMove", 0, Black.AIGraph.LeafNode.AI.Move.AILeafNodeHeatMapMove.ObjectType, null, properties, 0, 728);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.AILeafNodeHeatMapMove", base.GetFieldProperties(), -1444460825, 261695548);
            return fieldProperties;
        }

		
    }
}