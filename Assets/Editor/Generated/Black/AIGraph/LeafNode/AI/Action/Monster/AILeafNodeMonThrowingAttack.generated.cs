using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action.Monster
{
    public partial class AILeafNodeMonThrowingAttack : Black.AIGraph.LeafNode.AI.Action.AILeafNodeThrowingAttack
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt monActionType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt dirType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeMonThrowingAttack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.Monster.AILeafNodeMonThrowingAttack", 0, Black.AIGraph.LeafNode.AI.Action.Monster.AILeafNodeMonThrowingAttack.ObjectType, null, properties, 0, 512);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.Monster.AILeafNodeMonThrowingAttack", base.GetFieldProperties(), 159423444, -357011012);
            return fieldProperties;
        }

		
    }
}