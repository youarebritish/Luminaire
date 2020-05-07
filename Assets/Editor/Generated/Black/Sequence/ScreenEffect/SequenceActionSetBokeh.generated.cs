using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.ScreenEffect
{
    public partial class SequenceActionSetBokeh : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool enabled_;
		public int filterLevel_;
		public bool enabledFilterLevel_;
		public bool enableWeather_;
		public int bokehShape_;
		public float bokehShapeRotation_;
		public float foculLength_;
		public float fNumber_;
		public float focalPlane_;
		public float focalPlaneRadius_;
		public float nearCoCMultiplier_;
		public float farCoCMultiplier_;
		public float maxCoCSizeNear_;
		public float maxCoCSizeFar_;
		public bool vignetteBlur_enabled_;
		public float vignetteBlur_yScale_;
		public float vignetteBlur_start_;
		public float vignetteBlur_strength_;
		public float vignetteBlur_power_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin focalPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_bokehShapeRotation_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_foculLength_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_fNumber_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_focalPlaneRadius_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_nearCoCMultiplier_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_farCoCMultiplier_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_maxCoCSizeNear_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_maxCoCSizeFar_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_vignetteBlur_yScale_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_vignetteBlur_start_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_vignetteBlur_strength_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_vignetteBlur_power_;
		public int debugMode_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetBokeh();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.ScreenEffect.SequenceActionSetBokeh", 0, Black.Sequence.ScreenEffect.SequenceActionSetBokeh.ObjectType, null, properties, 0, 1592);
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

            fieldProperties = new PropertyContainer("Black.Sequence.ScreenEffect.SequenceActionSetBokeh", base.GetFieldProperties(), -1520417657, -787462767);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enabled_", 1722022099, "bool", 368, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("filterLevel_", 124193320, "Black.Graphics.ScreenEffect.BokehFilterLevel", 372, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("enabledFilterLevel_", 3117506659, "bool", 376, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableWeather_", 1384777099, "bool", 377, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("bokehShape_", 2200505952, "int", 380, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("bokehShapeRotation_", 2630922490, "float", 384, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("foculLength_", 3442808531, "float", 388, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fNumber_", 2684869345, "float", 392, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("focalPlane_", 219737661, "float", 396, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("focalPlaneRadius_", 2764587371, "float", 400, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("nearCoCMultiplier_", 1139837890, "float", 404, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("farCoCMultiplier_", 3537477447, "float", 408, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxCoCSizeNear_", 2241816492, "float", 412, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxCoCSizeFar_", 3309306271, "float", 416, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("vignetteBlur_enabled_", 2030089333, "bool", 420, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("vignetteBlur_yScale_", 2819584729, "float", 424, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("vignetteBlur_start_", 3713456890, "float", 428, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("vignetteBlur_strength_", 454397675, "float", 432, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("vignetteBlur_power_", 2683979777, "float", 436, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("focalPin_", 2571200878, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 440, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_bokehShapeRotation_", 697494006, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 528, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_foculLength_", 3706381023, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 616, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_fNumber_", 3533880029, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 704, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_focalPlaneRadius_", 3499824391, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 792, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_nearCoCMultiplier_", 3753131166, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 880, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_farCoCMultiplier_", 3444733571, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 968, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_maxCoCSizeNear_", 292096128, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1056, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_maxCoCSizeFar_", 3515722643, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1144, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_vignetteBlur_yScale_", 3755508733, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1232, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_vignetteBlur_start_", 2325051318, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1320, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_vignetteBlur_strength_", 2941976791, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1408, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_vignetteBlur_power_", 817758341, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1496, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("debugMode_", 2053894076, "Black.Sequence.ScreenEffect.SequenceActionSetBokeh.eDebugMode", 1584, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}