using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Test
{
    public partial class AIGraphLeafNodeFlyingWithLandingTest : Black.AIGraph.LeafNode.AI.Move.AILeafNodeMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat moveSpeed;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat allowableDistanceError_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum landingType;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphLeafNodeFlyingWithLandingTest();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Test.AIGraphLeafNodeFlyingWithLandingTest", 0, Black.AIGraph.LeafNode.Test.AIGraphLeafNodeFlyingWithLandingTest.ObjectType, null, properties, 0, 704);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Test.AIGraphLeafNodeFlyingWithLandingTest", base.GetFieldProperties(), -553278335, 1721353094);
            return fieldProperties;
        }

		
    }
}