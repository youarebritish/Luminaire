using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action
{
    public partial class AILeafNodeSetCloserLinkAnim : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid linkanimMessage1_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid linkanimMessage2_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid resultMessage_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeSetCloserLinkAnim();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.AILeafNodeSetCloserLinkAnim", 0, Black.AIGraph.LeafNode.AI.Action.AILeafNodeSetCloserLinkAnim.ObjectType, null, properties, 0, 192);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.AILeafNodeSetCloserLinkAnim", base.GetFieldProperties(), -644957379, -1737957089);
            
			
			
			return fieldProperties;
        }

		
    }
}