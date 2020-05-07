using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move
{
    public partial class AILeafNodeFlyingApproachMove : Black.AIGraph.LeafNode.AI.Move.AILeafNodeApproachMove
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat targetDiffHeight;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat lowAltitudeLimit;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeFlyingApproachMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.AILeafNodeFlyingApproachMove", 0, Black.AIGraph.LeafNode.AI.Move.AILeafNodeFlyingApproachMove.ObjectType, null, properties, 0, 896);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.AILeafNodeFlyingApproachMove", base.GetFieldProperties(), -304386129, 705458077);
            return fieldProperties;
        }

		
    }
}