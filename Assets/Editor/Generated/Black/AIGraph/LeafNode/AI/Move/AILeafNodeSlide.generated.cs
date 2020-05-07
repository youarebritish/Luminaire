using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move
{
    public partial class AILeafNodeSlide : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector targetPosition_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector targetPositionOffset_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat arrivalDistance_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat slideTime_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool obstructed_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum easing_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeSlide();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.AILeafNodeSlide", 0, Black.AIGraph.LeafNode.AI.Move.AILeafNodeSlide.ObjectType, null, properties, 0, 496);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.AILeafNodeSlide", base.GetFieldProperties(), 860796891, -130004804);
            return fieldProperties;
        }

		
    }
}