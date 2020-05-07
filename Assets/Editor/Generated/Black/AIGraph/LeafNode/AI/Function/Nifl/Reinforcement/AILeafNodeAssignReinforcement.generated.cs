using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function.Nifl.Reinforcement
{
    public partial class AILeafNodeAssignReinforcement : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid reinforceLabel;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeAssignReinforcement();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.Nifl.Reinforcement.AILeafNodeAssignReinforcement", 0, Black.AIGraph.LeafNode.AI.Function.Nifl.Reinforcement.AILeafNodeAssignReinforcement.ObjectType, null, properties, 0, 96);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.Nifl.Reinforcement.AILeafNodeAssignReinforcement", base.GetFieldProperties(), -800664659, 1988472706);
            return fieldProperties;
        }

		
    }
}