using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function
{
    public partial class AILeafNodeSpawnProp : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat offsetX_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat offsetY_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat offsetZ_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat rotationX_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat rotationY_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat rotationZ_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid characterEntry_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool useLocalCoordinates_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool rayCastForGround_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool hide_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeSpawnProp();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.AILeafNodeSpawnProp", 0, Black.AIGraph.LeafNode.AI.Function.AILeafNodeSpawnProp.ObjectType, null, properties, 0, 424);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.AILeafNodeSpawnProp", base.GetFieldProperties(), 1498203738, -192958611);
            
			
			
			return fieldProperties;
        }

		
    }
}