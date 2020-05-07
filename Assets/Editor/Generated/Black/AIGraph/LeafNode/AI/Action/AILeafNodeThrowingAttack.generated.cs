using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action
{
    public partial class AILeafNodeThrowingAttack : Black.AIGraph.LeafNode.AI.Action.AILeafNodeSendMessageWithCheckCanControl
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat attackDistanceMin_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat attackDistanceMax_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat attackAngleMin_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat attackAngleMax_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum minRecogLv;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeThrowingAttack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.AILeafNodeThrowingAttack", 0, Black.AIGraph.LeafNode.AI.Action.AILeafNodeThrowingAttack.ObjectType, null, properties, 0, 448);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.AILeafNodeThrowingAttack", base.GetFieldProperties(), -1401675510, -471400165);
            return fieldProperties;
        }

		
    }
}