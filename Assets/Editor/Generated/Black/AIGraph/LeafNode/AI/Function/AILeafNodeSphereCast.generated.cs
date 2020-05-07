using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function
{
    public partial class AILeafNodeSphereCast : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector startPosition_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector startOffset_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector endPosition_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector endOffset_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector direction_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat distance_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat sphereRadius_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool hasHit_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector hitPosition_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat hitDistance_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat timeout_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeSphereCast();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.AILeafNodeSphereCast", 0, Black.AIGraph.LeafNode.AI.Function.AILeafNodeSphereCast.ObjectType, null, properties, 0, 624);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.AILeafNodeSphereCast", base.GetFieldProperties(), -150567363, -158273098);
            
			fieldProperties.AddProperty(new Property("startPosition_", 3770512409, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector", 64, 64, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("startOffset_", 3433044225, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector", 128, 64, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("endPosition_", 1641034046, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector", 192, 64, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("endOffset_", 2614378470, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector", 256, 64, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("direction_", 4006647919, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector", 320, 64, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("distance_", 3236486151, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 384, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sphereRadius_", 1763032771, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 416, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("hasHit_", 4113841649, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 448, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("hitPosition_", 4108044862, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector", 480, 64, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("hitDistance_", 2905122538, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 544, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeout_", 269585269, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 576, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}