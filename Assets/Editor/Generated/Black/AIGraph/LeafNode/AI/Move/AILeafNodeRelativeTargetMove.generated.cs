using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move
{
    public partial class AILeafNodeRelativeTargetMove : Black.AIGraph.LeafNode.AI.Move.AILeafNodeMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyString searchLabel_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat arrivalInnnerDistance_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat arrivalOuterDistance_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat failedDistance_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat moveSpeed_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum atLocationPreference;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeRelativeTargetMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.AILeafNodeRelativeTargetMove", 0, Black.AIGraph.LeafNode.AI.Move.AILeafNodeRelativeTargetMove.ObjectType, null, properties, 0, 896);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.AILeafNodeRelativeTargetMove", base.GetFieldProperties(), -1989151084, -485637426);
            
			fieldProperties.AddProperty(new Property("targetType_", 4725453, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 568, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("searchLabel_", 3037400282, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyString", 600, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("arrivalInnnerDistance_", 3211809926, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 656, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("arrivalOuterDistance_", 185253379, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 688, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("failedDistance_", 3209868480, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 720, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveSpeed_", 113149984, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 752, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("atLocationPreference", 1680432498, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 784, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}