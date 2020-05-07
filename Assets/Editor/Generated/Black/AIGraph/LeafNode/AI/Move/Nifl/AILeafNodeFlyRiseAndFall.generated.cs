using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move.Nifl
{
    public partial class AILeafNodeFlyRiseAndFall : Black.AIGraph.LeafNode.AI.Move.AILeafNodeMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat movingHeightOffset_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool useFixedHeight_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat movingHeightPlayerInside_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat maxSpeedRatio_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeFlyRiseAndFall();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.Nifl.AILeafNodeFlyRiseAndFall", 0, Black.AIGraph.LeafNode.AI.Move.Nifl.AILeafNodeFlyRiseAndFall.ObjectType, null, properties, 0, 704);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.Nifl.AILeafNodeFlyRiseAndFall", base.GetFieldProperties(), -241739656, -1608612264);
            
			
			
			return fieldProperties;
        }

		
    }
}