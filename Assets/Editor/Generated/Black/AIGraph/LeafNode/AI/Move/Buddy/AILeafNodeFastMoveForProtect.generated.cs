using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move.Buddy
{
    public partial class AILeafNodeFastMoveForProtect : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt step;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat stepSpeed;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeFastMoveForProtect();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.Buddy.AILeafNodeFastMoveForProtect", 0, Black.AIGraph.LeafNode.AI.Move.Buddy.AILeafNodeFastMoveForProtect.ObjectType, null, properties, 0, 136);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.Buddy.AILeafNodeFastMoveForProtect", base.GetFieldProperties(), 1573168182, -10279742);
            return fieldProperties;
        }

		
    }
}