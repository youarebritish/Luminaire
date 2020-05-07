using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move
{
    public partial class AILeafNodeRelativeTargetFlyingMove : Black.AIGraph.LeafNode.AI.Move.AILeafNodeRelativeTargetMove
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat height_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool keepHeight_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeRelativeTargetFlyingMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.AILeafNodeRelativeTargetFlyingMove", 0, Black.AIGraph.LeafNode.AI.Move.AILeafNodeRelativeTargetFlyingMove.ObjectType, null, properties, 0, 960);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.AILeafNodeRelativeTargetFlyingMove", base.GetFieldProperties(), -1667761898, 371320134);
            return fieldProperties;
        }

		
    }
}