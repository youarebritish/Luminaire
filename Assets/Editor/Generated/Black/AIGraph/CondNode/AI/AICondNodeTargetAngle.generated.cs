using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.CondNode.AI
{
    public partial class AICondNodeTargetAngle : SQEX.Ebony.AIGraph.Node.BT.Decorator.AIGraphNodeBTDecoratorCondition
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum compareType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum dir4Type_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum dirLRType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool Not_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AICondNodeTargetAngle();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.CondNode.AI.AICondNodeTargetAngle", 0, Black.AIGraph.CondNode.AI.AICondNodeTargetAngle.ObjectType, null, properties, 0, 504);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.CondNode.AI.AICondNodeTargetAngle", base.GetFieldProperties(), 2083356863, -1108957010);
            
			fieldProperties.AddProperty(new Property("targetSlotType_", 102733177, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 344, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("compareType_", 1545781657, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 376, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dir4Type_", 357450325, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 408, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dirLRType_", 1639992547, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 440, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Not_", 977337647, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 472, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}