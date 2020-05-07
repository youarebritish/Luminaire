using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move
{
    public partial class AILeafNodeFlyingRandomMove : Black.AIGraph.LeafNode.AI.Move.AILeafNodeRandomMove
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat maxAltitude_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat minAltitude_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeFlyingRandomMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.AILeafNodeFlyingRandomMove", 0, Black.AIGraph.LeafNode.AI.Move.AILeafNodeFlyingRandomMove.ObjectType, null, properties, 0, 848);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.AILeafNodeFlyingRandomMove", base.GetFieldProperties(), -1350268240, 208495156);
            
			
			
			return fieldProperties;
        }

		
    }
}