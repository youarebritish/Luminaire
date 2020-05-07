using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function
{
    public partial class AIGraphNodeLeafBattleStatusEPI : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeLeafBattleStatusEPI();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.AIGraphNodeLeafBattleStatusEPI", 0, Black.AIGraph.LeafNode.AI.Function.AIGraphNodeLeafBattleStatusEPI.ObjectType, null, properties, 0, 56);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.AIGraphNodeLeafBattleStatusEPI", base.GetFieldProperties(), -1721833372, 2048155544);
            return fieldProperties;
        }

		
    }
}