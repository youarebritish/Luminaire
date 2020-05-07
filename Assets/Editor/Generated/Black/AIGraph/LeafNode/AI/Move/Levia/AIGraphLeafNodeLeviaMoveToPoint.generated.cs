using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move.Levia
{
    public partial class AIGraphLeafNodeLeviaMoveToPoint : Black.AIGraph.LeafNode.AI.Move.Levia.AIGraphLeafNodeLeviaMovePointBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector point_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat randRadiusInner_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat randRadiusOuter_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat randHeightMin_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat randHeightMax_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphLeafNodeLeviaMoveToPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.Levia.AIGraphLeafNodeLeviaMoveToPoint", 0, Black.AIGraph.LeafNode.AI.Move.Levia.AIGraphLeafNodeLeviaMoveToPoint.ObjectType, null, properties, 0, 1248);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.Levia.AIGraphLeafNodeLeviaMoveToPoint", base.GetFieldProperties(), -1552003355, 1543745075);
            
			fieldProperties.AddProperty(new Property("point_", 2828355658, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector", 1056, 64, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("randRadiusInner_", 3955115281, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 1120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("randRadiusOuter_", 2601551056, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 1152, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("randHeightMin_", 2377517776, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 1184, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("randHeightMax_", 650835162, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 1216, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}