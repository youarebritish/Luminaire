using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function
{
    public partial class AILeafNodeRequestTPSQuerySpecifiedCenter : Black.AIGraph.LeafNode.AI.Function.AILeafNodeRequestTPSQuery
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum centerTargetSlotType;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeRequestTPSQuerySpecifiedCenter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.AILeafNodeRequestTPSQuerySpecifiedCenter", 0, Black.AIGraph.LeafNode.AI.Function.AILeafNodeRequestTPSQuerySpecifiedCenter.ObjectType, null, properties, 0, 336);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.AILeafNodeRequestTPSQuerySpecifiedCenter", base.GetFieldProperties(), -1044370077, -1435813197);
            
			fieldProperties.AddProperty(new Property("centerTargetSlotType", 2169573105, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 296, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}