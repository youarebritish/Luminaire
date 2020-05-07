using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Node
{
    public partial class GraphTriggerInputPin : SQEX.Ebony.Framework.Node.GraphInputPin
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int delayType_;
		public float delayTime_;
		public float delayMaxTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new GraphTriggerInputPin();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 0, SQEX.Ebony.Framework.Node.GraphTriggerInputPin.ObjectType, null, properties, 0, 96);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Node.GraphTriggerInputPin", base.GetFieldProperties(), 853632623, -1641886137);
            
			fieldProperties.AddIndirectlyProperty(new Property("pinName_", 1657142480, "Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("name_", 182823483, "Base.String", 24, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("connections_", 1444105939, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			
			
			fieldProperties.AddProperty(new Property("delayType_", 3980331453, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 72, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("delayTime_", 258900106, "float", 76, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("delayMaxTime_", 2659674896, "float", 80, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}