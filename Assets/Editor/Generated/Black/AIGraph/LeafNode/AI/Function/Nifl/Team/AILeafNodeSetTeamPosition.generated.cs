using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function.Nifl.Team
{
    public partial class AILeafNodeSetTeamPosition : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeSetTeamPosition();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.Nifl.Team.AILeafNodeSetTeamPosition", 0, Black.AIGraph.LeafNode.AI.Function.Nifl.Team.AILeafNodeSetTeamPosition.ObjectType, null, properties, 0, 112);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.Nifl.Team.AILeafNodeSetTeamPosition", base.GetFieldProperties(), -2021910841, -413101474);
            return fieldProperties;
        }

		
    }
}