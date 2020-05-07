using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function
{
    public partial class AILeafNodeAreaSearch : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector startPoint_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector endPoint_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat radius_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat searchTimeMax_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeAreaSearch();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.AILeafNodeAreaSearch", 0, Black.AIGraph.LeafNode.AI.Function.AILeafNodeAreaSearch.ObjectType, null, properties, 0, 320);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.AILeafNodeAreaSearch", base.GetFieldProperties(), -781361834, -1406616210);
            
			fieldProperties.AddIndirectlyProperty(new Property("uid_", 2695886806, "int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startNodeUid_", 2715036948, "int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bDisable_", 54874740, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bSkipblackBoardInitialization_", 1945287384, "bool", 25, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startPoint_.propertyId_", 2627029151, "int", 72, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startPoint_.indexOfLinkedProperty_", 1195699536, "int", 76, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startPoint_.value_", 3461962684, "Luminous.Math.VectorA", 96, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endPoint_.propertyId_", 30361902, "int", 136, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endPoint_.indexOfLinkedProperty_", 1121703371, "int", 140, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endPoint_.value_", 107374559, "Luminous.Math.VectorA", 160, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("radius_.propertyId_", 36182267, "int", 200, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("radius_.indexOfLinkedProperty_", 1468599876, "int", 204, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("radius_.value_", 2186456192, "float", 216, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("searchTimeMax_.propertyId_", 4100844140, "int", 232, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("searchTimeMax_.indexOfLinkedProperty_", 2549958393, "int", 236, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("searchTimeMax_.value_", 694522793, "float", 248, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("startPoint_", 3190872664, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector", 64, 64, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("endPoint_", 3329959993, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector", 128, 64, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("radius_", 2286360452, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 192, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("searchTimeMax_", 1734607299, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 224, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}