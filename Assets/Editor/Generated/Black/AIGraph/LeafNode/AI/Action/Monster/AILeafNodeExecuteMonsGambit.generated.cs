using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action.Monster
{
    public partial class AILeafNodeExecuteMonsGambit : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum gambitTag;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid gambitTagFixid;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeExecuteMonsGambit();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.Monster.AILeafNodeExecuteMonsGambit", 0, Black.AIGraph.LeafNode.AI.Action.Monster.AILeafNodeExecuteMonsGambit.ObjectType, null, properties, 0, 288);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.Monster.AILeafNodeExecuteMonsGambit", base.GetFieldProperties(), -971663726, 861236132);
            return fieldProperties;
        }

		
    }
}