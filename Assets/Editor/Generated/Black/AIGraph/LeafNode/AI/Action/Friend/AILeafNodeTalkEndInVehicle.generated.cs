using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action.Friend
{
    public partial class AILeafNodeTalkEndInVehicle : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeTalkEndInVehicle();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.Friend.AILeafNodeTalkEndInVehicle", 0, Black.AIGraph.LeafNode.AI.Action.Friend.AILeafNodeTalkEndInVehicle.ObjectType, null, properties, 0, 64);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.Friend.AILeafNodeTalkEndInVehicle", base.GetFieldProperties(), -899455627, 1679001946);
            return fieldProperties;
        }

		
    }
}