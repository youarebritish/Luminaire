using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function
{
    public partial class AILeafNodeMapPointSearch : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum outSlotType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid searchLabelFixid;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum criteriaTargetSlotType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat searchCullingRange;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeMapPointSearch();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.AILeafNodeMapPointSearch", 0, Black.AIGraph.LeafNode.AI.Function.AILeafNodeMapPointSearch.ObjectType, null, properties, 0, 184);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.AILeafNodeMapPointSearch", base.GetFieldProperties(), -960657395, 565459907);
            return fieldProperties;
        }

		
    }
}