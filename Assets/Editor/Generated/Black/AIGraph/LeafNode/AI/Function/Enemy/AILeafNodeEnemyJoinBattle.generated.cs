using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function.Enemy
{
    public partial class AILeafNodeEnemyJoinBattle : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isJoinBattle;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum battleTargetSlotType;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeEnemyJoinBattle();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.Enemy.AILeafNodeEnemyJoinBattle", 0, Black.AIGraph.LeafNode.AI.Function.Enemy.AILeafNodeEnemyJoinBattle.ObjectType, null, properties, 0, 120);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.Enemy.AILeafNodeEnemyJoinBattle", base.GetFieldProperties(), -1700146201, 647223415);
            
			
			
			return fieldProperties;
        }

		
    }
}