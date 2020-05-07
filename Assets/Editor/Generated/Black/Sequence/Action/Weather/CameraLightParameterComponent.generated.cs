using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Weather
{
    public partial class CameraLightParameterComponent : Black.Sequence.Action.Weather.ParameterComponentBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int category_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CameraLightParameterComponent();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Weather.CameraLightParameterComponent", 0, Black.Sequence.Action.Weather.CameraLightParameterComponent.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Weather.CameraLightParameterComponent", base.GetFieldProperties(), 1607401127, 1115526627);
            
			fieldProperties.AddIndirectlyProperty(new Property("operation_", 1684381467, "Black.Weather.WEATHER_PARAM_OPERATION", 8, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("index_", 801737500, "uint32_t", 12, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("value_", 273093519, "float", 16, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("category_", 1432694378, "Black.Sequence.Action.Weather.CameraLightParameterComponent.CAMERALIGHT_PARAM_CATEGORY", 24, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}