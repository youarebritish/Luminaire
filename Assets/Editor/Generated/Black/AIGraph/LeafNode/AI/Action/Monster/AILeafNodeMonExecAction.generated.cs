using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action.Monster
{
    public partial class AILeafNodeMonExecAction : Black.AIGraph.LeafNode.AI.Action.AILeafNodeExecAction
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

            var dummy = new AILeafNodeMonExecAction();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.Monster.AILeafNodeMonExecAction", 0, Black.AIGraph.LeafNode.AI.Action.Monster.AILeafNodeMonExecAction.ObjectType, null, properties, 0, 384);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.Monster.AILeafNodeMonExecAction", base.GetFieldProperties(), -1396401743, -1636733066);
            
			
			
			return fieldProperties;
        }

		
    }
}