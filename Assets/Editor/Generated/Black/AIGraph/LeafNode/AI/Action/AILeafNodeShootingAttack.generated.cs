using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action
{
    public partial class AILeafNodeShootingAttack : Black.AIGraph.LeafNode.AI.Action.AILeafNodeSendMessageWithCheckCanControl
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat attackDistanceMin_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat attackDistanceMax_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat attackAngleMin_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat attackAngleMax_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool canThroughLineOfFire;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum minRecogLv;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeShootingAttack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.AILeafNodeShootingAttack", 0, Black.AIGraph.LeafNode.AI.Action.AILeafNodeShootingAttack.ObjectType, null, properties, 0, 480);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.AILeafNodeShootingAttack", base.GetFieldProperties(), 2007572756, 1092845544);
            
			
			
			return fieldProperties;
        }

		
    }
}