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
            
			fieldProperties.AddProperty(new Property("startPoint_", 3190872664, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector", 64, 64, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("endPoint_", 3329959993, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector", 128, 64, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("radius_", 2286360452, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 192, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("searchTimeMax_", 1734607299, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 224, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}