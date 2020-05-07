using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action
{
    public partial class AILeafNodeExecHookAction : Black.AIGraph.LeafNode.AI.Action.AILeafNodeSendMessageWithCheckCanControl
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid animId;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid facialAnimId;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat timeout;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat blendDuration;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bUseTarget;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeExecHookAction();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.AILeafNodeExecHookAction", 0, Black.AIGraph.LeafNode.AI.Action.AILeafNodeExecHookAction.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.AILeafNodeExecHookAction", base.GetFieldProperties(), 562811921, -2092608153);
            return fieldProperties;
        }

		
    }
}