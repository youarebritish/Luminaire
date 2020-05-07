using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move.Levia
{
    public partial class AIGraphLeafNodeLeviaMoveToRandom : Black.AIGraph.LeafNode.AI.Move.Levia.AIGraphLeafNodeLeviaMovePointBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
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

            var dummy = new AIGraphLeafNodeLeviaMoveToRandom();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.Levia.AIGraphLeafNodeLeviaMoveToRandom", 0, Black.AIGraph.LeafNode.AI.Move.Levia.AIGraphLeafNodeLeviaMoveToRandom.ObjectType, null, properties, 0, 1176);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.Levia.AIGraphLeafNodeLeviaMoveToRandom", base.GetFieldProperties(), 1993238195, -1078501750);
            
			fieldProperties.AddProperty(new Property("randRadiusInner_", 3955115281, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 1048, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("randRadiusOuter_", 2601551056, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 1080, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("randHeightMin_", 2377517776, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 1112, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("randHeightMax_", 650835162, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 1144, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}