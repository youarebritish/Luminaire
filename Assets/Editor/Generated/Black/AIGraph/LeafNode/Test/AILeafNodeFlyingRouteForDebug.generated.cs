using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Test
{
    public partial class AILeafNodeFlyingRouteForDebug : Black.AIGraph.LeafNode.AI.Move.AILeafNodeRouteMove
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeFlyingRouteForDebug();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Test.AILeafNodeFlyingRouteForDebug", 0, Black.AIGraph.LeafNode.Test.AILeafNodeFlyingRouteForDebug.ObjectType, null, properties, 0, 1136);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Test.AILeafNodeFlyingRouteForDebug", base.GetFieldProperties(), -598326805, -1884042923);
            
			
			
			return fieldProperties;
        }

		
    }
}