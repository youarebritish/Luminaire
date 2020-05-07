using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action.Friend
{
    public partial class AILeafNodeLookBeginInVehicle : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool useTarget;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat frameAngle;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isRight;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat initialAngle;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isClockwise;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat rotateAngle;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat minTime;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat maxTime;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum mood;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isLookStarted;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeLookBeginInVehicle();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.Friend.AILeafNodeLookBeginInVehicle", 0, Black.AIGraph.LeafNode.AI.Action.Friend.AILeafNodeLookBeginInVehicle.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.Friend.AILeafNodeLookBeginInVehicle", base.GetFieldProperties(), 1446323538, -2093493660);
            
			fieldProperties.AddProperty(new Property("useTarget", 2383131709, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetSlotType", 999269404, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("frameAngle", 3214986653, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isRight", 4209847093, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 152, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("initialAngle", 2870040290, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 184, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isClockwise", 1499383397, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 216, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotateAngle", 2395448073, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 248, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("minTime", 3757041766, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 280, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxTime", 2251108208, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 312, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("mood", 4219780606, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 344, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isLookStarted", 2404303975, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 376, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}