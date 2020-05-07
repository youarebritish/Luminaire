using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action
{
    public partial class AILeafNodeExecPassedMessageAction : Black.AIGraph.LeafNode.AI.Action.AILeafNodeExecAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeExecPassedMessageAction();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.AILeafNodeExecPassedMessageAction", 0, Black.AIGraph.LeafNode.AI.Action.AILeafNodeExecPassedMessageAction.ObjectType, null, properties, 0, 328);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.AILeafNodeExecPassedMessageAction", base.GetFieldProperties(), 1955319883, -1515530164);
            return fieldProperties;
        }

		
    }
}