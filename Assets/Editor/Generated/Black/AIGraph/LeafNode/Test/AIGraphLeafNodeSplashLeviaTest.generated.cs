using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Test
{
    public partial class AIGraphLeafNodeSplashLeviaTest : Black.AIGraph.LeafNode.AI.Move.AILeafNodeMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat moveSpeed_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat movingHeightOffset_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphLeafNodeSplashLeviaTest();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Test.AIGraphLeafNodeSplashLeviaTest", 0, Black.AIGraph.LeafNode.Test.AIGraphLeafNodeSplashLeviaTest.ObjectType, null, properties, 0, 664);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Test.AIGraphLeafNodeSplashLeviaTest", base.GetFieldProperties(), 1269738655, 1757338731);
            return fieldProperties;
        }

		
    }
}