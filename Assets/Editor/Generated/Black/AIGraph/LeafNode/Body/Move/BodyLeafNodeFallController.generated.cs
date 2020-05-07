using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Body.Move
{
    public partial class BodyLeafNodeFallController : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat MinTimeInVelocityInterpolation;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat MaxTimeInVelocityInterpolation;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat MaxCorrectionVelocity;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat TimeInTurning;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat Gravity;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt ThresholdDetectionFalling;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyLeafNodeFallController();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.Move.BodyLeafNodeFallController", 0, Black.AIGraph.LeafNode.Body.Move.BodyLeafNodeFallController.ObjectType, null, properties, 0, 320);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.Move.BodyLeafNodeFallController", base.GetFieldProperties(), -676116271, -1857563641);
            
			fieldProperties.AddProperty(new Property("MinTimeInVelocityInterpolation", 454119332, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("MaxTimeInVelocityInterpolation", 1070477662, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("MaxCorrectionVelocity", 1706412954, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("TimeInTurning", 4195713304, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 152, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Gravity", 86852581, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 184, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ThresholdDetectionFalling", 2803766230, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 216, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}