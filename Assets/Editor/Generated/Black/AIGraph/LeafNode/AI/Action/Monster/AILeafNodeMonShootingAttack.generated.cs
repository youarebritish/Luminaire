using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action.Monster
{
    public partial class AILeafNodeMonShootingAttack : Black.AIGraph.LeafNode.AI.Action.AILeafNodeShootingAttack
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

            var dummy = new AILeafNodeMonShootingAttack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.Monster.AILeafNodeMonShootingAttack", 0, Black.AIGraph.LeafNode.AI.Action.Monster.AILeafNodeMonShootingAttack.ObjectType, null, properties, 0, 544);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.Monster.AILeafNodeMonShootingAttack", base.GetFieldProperties(), -477336185, 2145255272);
            
			
			
			return fieldProperties;
        }

		
    }
}