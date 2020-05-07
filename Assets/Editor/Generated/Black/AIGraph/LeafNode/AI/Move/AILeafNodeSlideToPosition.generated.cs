using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move
{
    public partial class AILeafNodeSlideToPosition : Black.AIGraph.LeafNode.AI.Move.AILeafNodeMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat slideTime;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool rotateActor;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeSlideToPosition();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.AILeafNodeSlideToPosition", 0, Black.AIGraph.LeafNode.AI.Move.AILeafNodeSlideToPosition.ObjectType, null, properties, 0, 752);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.AILeafNodeSlideToPosition", base.GetFieldProperties(), -633063186, 1938960205);
            return fieldProperties;
        }

		
    }
}