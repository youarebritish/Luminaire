using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action
{
    public partial class AILeafNodeMeleeAttack : Black.AIGraph.LeafNode.AI.Action.AILeafNodeSendMessageWithCheckCanControl
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat attackDistanceMin;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat attackDistanceMax;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat attackAngleMin;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat attackAngleMax;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool canCloseStraight;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum minRecogLv;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeMeleeAttack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.AILeafNodeMeleeAttack", 0, Black.AIGraph.LeafNode.AI.Action.AILeafNodeMeleeAttack.ObjectType, null, properties, 0, 480);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.AILeafNodeMeleeAttack", base.GetFieldProperties(), 127072209, -396267751);
            return fieldProperties;
        }

		
    }
}