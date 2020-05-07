using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move.Buddy
{
    public partial class AILeafNodePseudoInertia : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bEnable_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat airResistance_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodePseudoInertia();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.Buddy.AILeafNodePseudoInertia", 0, Black.AIGraph.LeafNode.AI.Move.Buddy.AILeafNodePseudoInertia.ObjectType, null, properties, 0, 136);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.Buddy.AILeafNodePseudoInertia", base.GetFieldProperties(), -2098539722, -1559506100);
            return fieldProperties;
        }

		
    }
}