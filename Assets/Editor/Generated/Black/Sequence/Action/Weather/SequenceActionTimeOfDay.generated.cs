using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Weather
{
    public partial class SequenceActionTimeOfDay : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public float timeOfDay_;
		public float axisTilt_;
		public float axisAzimuth_;
		public float moonAxisTilt_;
		public float moonAxisAzimuth_;
		public float moonCenterOfRotationHeightOffset_;
		public UnityEngine.Color mainLightMoonColor_;
		public UnityEngine.Color mainLightSunColor_;
		public float moonLightScale_;
		public float sunLightScale_;
		public float moonLightAnisotropyForCloud_;
		public float sunLightAnisotropyForCloud_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin timeOfDay_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin axisTilt_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin axisAzimuth_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin mainLightDirection_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin mainLightColor_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin mainLightColorWithScale_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin sunAzimuth_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin sunElevation_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin moonAzimuth_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin moonElevation_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin mainLightAzimuth_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin mainLightElevation_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin mainLightAnisotropyForCloud_pin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeOfDay();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Weather.SequenceActionTimeOfDay", 0, Black.Sequence.Action.Weather.SequenceActionTimeOfDay.ObjectType, null, properties, 0, 1680);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Weather.SequenceActionTimeOfDay", base.GetFieldProperties(), 1371863222, -1288463538);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 256, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 352, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeOfDay_", 926921430, "float", 448, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("axisTilt_", 1271777844, "float", 452, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("axisAzimuth_", 3753876753, "float", 456, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonAxisTilt_", 79685647, "float", 460, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonAxisAzimuth_", 3430599188, "float", 464, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonCenterOfRotationHeightOffset_", 110503819, "float", 468, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("mainLightMoonColor_", 1783833389, "Luminous.RenderInterface.Color", 480, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("mainLightSunColor_", 59584030, "Luminous.RenderInterface.Color", 496, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonLightScale_", 3703143299, "float", 512, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunLightScale_", 851310164, "float", 516, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonLightAnisotropyForCloud_", 3584833213, "float", 520, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunLightAnisotropyForCloud_", 1144960352, "float", 524, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeOfDay_pin_", 1043636198, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 528, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("axisTilt_pin_", 323266836, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 616, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("axisAzimuth_pin_", 2154957389, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 704, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("mainLightDirection_pin_", 3477340358, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 792, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("mainLightColor_pin_", 852388692, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 880, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("mainLightColorWithScale_pin_", 2261749844, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 968, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunAzimuth_pin_", 1449103924, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1056, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunElevation_pin_", 1956808745, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1144, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonAzimuth_pin_", 3626423465, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1232, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonElevation_pin_", 1256464808, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1320, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("mainLightAzimuth_pin_", 664735285, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1408, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("mainLightElevation_pin_", 2174686004, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1496, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("mainLightAnisotropyForCloud_pin_", 1128140497, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1584, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}