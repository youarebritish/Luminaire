using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action.Buddy
{
    public partial class AILeafNodeRotateToCameraInVehicle : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeRotateToCameraInVehicle();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.Buddy.AILeafNodeRotateToCameraInVehicle", 0, Black.AIGraph.LeafNode.AI.Action.Buddy.AILeafNodeRotateToCameraInVehicle.ObjectType, null, properties, 0, 80);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.Buddy.AILeafNodeRotateToCameraInVehicle", base.GetFieldProperties(), 1473783212, 1338595106);
            return fieldProperties;
        }

		
    }
}