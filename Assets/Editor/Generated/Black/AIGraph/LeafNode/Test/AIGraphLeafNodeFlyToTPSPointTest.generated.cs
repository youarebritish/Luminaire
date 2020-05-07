using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Test
{
    public partial class AIGraphLeafNodeFlyToTPSPointTest : Black.AIGraph.LeafNode.AI.Move.AILeafNodeMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat movingHeightOffset_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid fixid;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat moveSpeed;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphLeafNodeFlyToTPSPointTest();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Test.AIGraphLeafNodeFlyToTPSPointTest", 0, Black.AIGraph.LeafNode.Test.AIGraphLeafNodeFlyToTPSPointTest.ObjectType, null, properties, 0, 720);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Test.AIGraphLeafNodeFlyToTPSPointTest", base.GetFieldProperties(), 1179528515, -2099778836);
            
			
			
			return fieldProperties;
        }

		
    }
}