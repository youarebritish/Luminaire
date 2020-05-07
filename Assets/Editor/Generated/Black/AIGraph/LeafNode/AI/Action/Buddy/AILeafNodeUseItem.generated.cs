using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action.Buddy
{
    public partial class AILeafNodeUseItem : Black.AIGraph.LeafNode.AI.Action.AILeafNodeExecMoveAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid itemId_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bConsume_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeUseItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.Buddy.AILeafNodeUseItem", 0, Black.AIGraph.LeafNode.AI.Action.Buddy.AILeafNodeUseItem.ObjectType, null, properties, 0, 472);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.Buddy.AILeafNodeUseItem", base.GetFieldProperties(), -501003054, 1672610888);
            
			fieldProperties.AddProperty(new Property("itemId_", 2463901516, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 400, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bConsume_", 3783788730, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 432, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}