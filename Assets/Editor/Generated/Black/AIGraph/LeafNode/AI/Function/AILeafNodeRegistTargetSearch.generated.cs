using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function
{
    public partial class AILeafNodeRegistTargetSearch : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid searchLabelFixid;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid pointSearchLabelFixid;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isPreferObsessionTarget;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeRegistTargetSearch();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.AILeafNodeRegistTargetSearch", 0, Black.AIGraph.LeafNode.AI.Function.AILeafNodeRegistTargetSearch.ObjectType, null, properties, 0, 184);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.AILeafNodeRegistTargetSearch", base.GetFieldProperties(), 2042645159, 782585703);
            return fieldProperties;
        }

		
    }
}