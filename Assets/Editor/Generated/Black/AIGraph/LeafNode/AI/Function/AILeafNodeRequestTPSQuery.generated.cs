using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function
{
    public partial class AILeafNodeRequestTPSQuery : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid fixid;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum priority;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool Reserve;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool OverrideReservationSize;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat ReservationSize;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt ValidationLimit;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat distanceCoefficient;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeRequestTPSQuery();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.AILeafNodeRequestTPSQuery", 0, Black.AIGraph.LeafNode.AI.Function.AILeafNodeRequestTPSQuery.ObjectType, null, properties, 0, 296);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.AILeafNodeRequestTPSQuery", base.GetFieldProperties(), 2096236001, 1327612314);
            
			fieldProperties.AddProperty(new Property("fixid", 3017230053, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("priority", 2498028297, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Reserve", 1473378027, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("OverrideReservationSize", 1839550976, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 152, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ReservationSize", 1179375464, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 184, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ValidationLimit", 591487401, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 216, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("distanceCoefficient", 2103527983, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 248, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}