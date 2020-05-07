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
            
			fieldProperties.AddProperty(new Property("predicate_", 506888531, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 64, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetSlotType_", 102733177, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 96, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("add_", 1708628401, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 128, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("removePrior_", 990578304, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 160, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}