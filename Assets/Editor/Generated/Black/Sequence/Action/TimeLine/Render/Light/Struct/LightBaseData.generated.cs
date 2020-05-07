using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Render.Light.Struct
{
    public partial class LightBaseData : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enabled_;
		public bool diffuseOnly_;
		public bool smoothFalloff_;
		public UnityEngine.Color color_;
		public float intensity_;
		public float intensityEV_;
		public float radius_;
		public float range_;
		public bool shadowEnabled_;
		public int shadowResolution_;
		public float shadowZNear_;
		public float shadowZBias_;
		public float shadowSlopeBias_;
		public float shadowPower_;
		public float shadowPowerHair_;
		public float saoTerm_;
		public bool chrOnlyShadow_;
		public bool shadowWarpEnabled_;
		public bool volLightEnabled_;
		public float volLightIntensity_;
		public float volLightDistantIntensity_;
		public float volLightZOffset_;
		public bool lpvEnabled_;
		public bool vsglEnabled_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LightBaseData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Render.Light.Struct.LightBaseData", 0, Black.Sequence.Action.TimeLine.Render.Light.Struct.LightBaseData.ObjectType, null, properties, 0, 112);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Render.Light.Struct.LightBaseData", base.GetFieldProperties(), -1869542781, -1078376669);
            
			
			
			fieldProperties.AddProperty(new Property("enabled_", 1722022099, "bool", 8, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("diffuseOnly_", 1220725680, "bool", 9, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("smoothFalloff_", 181256924, "bool", 10, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("color_", 3572781317, "SQEX.Luminous.RenderInterface.Color", 16, 16, 1, Property.PrimitiveType.Color, 0, (char)1));
			fieldProperties.AddProperty(new Property("intensity_", 1363281103, "float", 32, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("intensityEV_", 2764622858, "float", 36, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("radius_", 2286360452, "float", 40, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("range_", 1969734135, "float", 44, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("shadowEnabled_", 3882039727, "bool", 48, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("shadowResolution_", 1208541428, "int", 52, 4, 1, Property.PrimitiveType.Int32, 0, (char)1));
			fieldProperties.AddProperty(new Property("shadowZNear_", 2446145452, "float", 56, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("shadowZBias_", 2446539005, "float", 60, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("shadowSlopeBias_", 2830696338, "float", 64, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("shadowPower_", 2925680519, "float", 68, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("shadowPowerHair_", 1876796191, "float", 72, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("saoTerm_", 711051605, "float", 76, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("chrOnlyShadow_", 75793315, "bool", 80, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("shadowWarpEnabled_", 3628345333, "bool", 81, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("volLightEnabled_", 308339756, "bool", 82, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("volLightIntensity_", 2359384144, "float", 84, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("volLightDistantIntensity_", 1545324381, "float", 88, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("volLightZOffset_", 2307886776, "float", 92, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("lpvEnabled_", 2490550915, "bool", 96, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("vsglEnabled_", 3587658515, "bool", 97, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			
			
			return fieldProperties;
        }

		
    }
}