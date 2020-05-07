using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function
{
    public partial class AILeafNodeAIInteractionNotifyTarget : Black.AIGraph.LeafNode.AI.Action.Ambient.AILeafNodeAmbientBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid predicate_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool add_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool removePrior_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeAIInteractionNotifyTarget();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.AILeafNodeAIInteractionNotifyTarget", 0, Black.AIGraph.LeafNode.AI.Function.AILeafNodeAIInteractionNotifyTarget.ObjectType, null, properties, 0, 200);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.AILeafNodeAIInteractionNotifyTarget", base.GetFieldProperties(), 788309914, -493751425);
            
			
			
			return fieldProperties;
        }

		
    }
}