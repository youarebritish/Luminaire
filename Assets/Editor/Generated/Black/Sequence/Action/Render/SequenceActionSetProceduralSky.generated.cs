using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Render
{
    public partial class SequenceActionSetProceduralSky : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool enableWeather_;
		public bool enableEVControl_;
		public float sunBrightness_;
		public float sunBrightnessEV_;
		public float moonBrightness_;
		public float moonBrightnessEV_;
		public float airThickness_;
		public float turbidityR_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turbidityRPin_;
		public float rayleighOvercastRate_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rayleighOvercastRatePin_;
		public float turbidityM_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turbidityMPin_;
		public float sunAsymmetry_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunAsymetryPin_;
		public float mieColorR_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin mieColorRPin_;
		public float mieColorG_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin mieColorGPin_;
		public float mieColorB_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin mieColorBPin_;
		public UnityEngine.Color sunDiskColor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunDiskColorPin_;
		public float sunDiskRadiation_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunDiskRadiationPin_;
		public float sunDiskRelativeSize_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunDiskRelativeSizePin_;
		public UnityEngine.Color moonDiskColor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin moonDiskColorPin_;
		public float moonDiskRadiation_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin moonDiskRadiationPin_;
		public float moonDiskRelativeSize_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin moonDiskRelativeSizePin_;
		public UnityEngine.Color sunColor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunColorPin_;
		public float sunBrightnessSky_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunBrightnessSkyPin_;
		public UnityEngine.Color moonColor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin moonColorPin_;
		public float moonBrightnessSky_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin moonBrightnessSkyPin_;
		public UnityEngine.Color mainLightSunColor_;
		public float sunLightScale_;
		public UnityEngine.Color mainLightMoonColor_;
		public float moonLightScale_;
		public UnityEngine.Color envSunColor_;
		public float envSunScale_;
		public UnityEngine.Color envMoonColor_;
		public float envMoonScale_;
		public float starSize_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin starSizePin_;
		public float starExtinctionHorizon_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin starExtinctionHorizoPin_;
		public float starBrightness_;
		public float starBrightnessEV_;
		public float tilingStarBrightness_;
		public float tilingStarBrightnessEV_;
		public float milkywayBrightness_;
		public float milkywayBrightnessEV_;
		public float starTwinkleSpeed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin starTwinkleSpeedPin_;
		public float tilingStarTwinkleSpeed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin tilingStarTwinkleSpeedPin_;
		public UnityEngine.Color backgroundColor_;
		public float backgroundColorIntensity_;
		public float backgroundColorIntensityEV_;
		public UnityEngine.Color groundColor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groundColorPin_;
		public float groundAlbedo_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groundAlbedoPin_;
		public float groundColorSpread_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groundColorSpreadPin_;
		public float groundSpreadUp_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groundSpreadUpPin_;
		public float horizonOffset_;
		public float extinctionStart_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin extinctionStartPin_;
		public float extinctionEnd_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin extinctionEndPin_;
		public float extinctionFalloff_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin extinctionFalloffPin_;
		public UnityEngine.Color midgroundColor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin midgroundColorPin_;
		public float midgroundIntensity_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin midgroundIntensityPin_;
		public float viewElevationAngle_;
		public float viewElevationAttenuation_;
		public float axisTilt_;
		public float axisAzimuth_;
		public float centerOfRotationHeightOffset_;
		public float meridianTime_;
		public float moonAxisTilt_;
		public float moonAxisAzimuth_;
		public float moonCenterOfRotationHeightOffset_;
		public float moonMeridianTime_;
		public float starAxisTilt_;
		public float starAxisAzimuth_;
		public float starMeridianTime_;
		public float sunDuration_;
		public float moonDuration_;
		public float START_DAY_;
		public float END_DAY_;
		public float moonriseOffset_;
		public float ambientIntensity_;
		public float directionalIntensity_;
		public float ambientSpecUseDirLightShadow_;
		public float shadowPower_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetProceduralSky();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Render.SequenceActionSetProceduralSky", 0, Black.Sequence.Action.Render.SequenceActionSetProceduralSky.ObjectType, null, properties, 0, 3632);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Render.SequenceActionSetProceduralSky", base.GetFieldProperties(), 374908728, 1957126268);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableWeather_", 1384777099, "bool", 368, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableEVControl_", 3055238003, "bool", 369, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunBrightness_", 3498263371, "float", 372, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunBrightnessEV_", 995550358, "float", 376, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonBrightness_", 590191000, "float", 380, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonBrightnessEV_", 4215596685, "float", 384, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("airThickness_", 1844004448, "float", 388, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("turbidityR_", 1777769222, "float", 392, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("turbidityRPin_", 105322105, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 400, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rayleighOvercastRate_", 618264404, "float", 488, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rayleighOvercastRatePin_", 3041011439, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 496, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turbidityM_", 704251869, "float", 584, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("turbidityMPin_", 1524267616, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 592, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunAsymmetry_", 1663448127, "float", 680, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunAsymetryPin_", 3393595003, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 688, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("mieColorR_", 4243518558, "float", 776, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("mieColorRPin_", 3040815777, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 784, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("mieColorG_", 4240120059, "float", 872, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("mieColorGPin_", 2600297750, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 880, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("mieColorB_", 3167191086, "float", 968, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("mieColorBPin_", 3915369777, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 976, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunDiskColor_", 879226896, "SQEX.Luminous.RenderInterface.Color", 1072, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunDiskColorPin_", 2262117083, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1088, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunDiskRadiation_", 2826617176, "float", 1176, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunDiskRadiationPin_", 138621907, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1184, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunDiskRelativeSize_", 3209578602, "float", 1272, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunDiskRelativeSizePin_", 2638858381, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1280, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonDiskColor_", 1392231517, "SQEX.Luminous.RenderInterface.Color", 1376, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonDiskColorPin_", 4029297632, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1392, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonDiskRadiation_", 2380953213, "float", 1480, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonDiskRadiationPin_", 689577920, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1488, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonDiskRelativeSize_", 1022252393, "float", 1576, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonDiskRelativeSizePin_", 482692284, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1584, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunColor_", 887658273, "SQEX.Luminous.RenderInterface.Color", 1680, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunColorPin_", 4188086500, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1696, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunBrightnessSky_", 3902717696, "float", 1784, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunBrightnessSkyPin_", 1256340363, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1792, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonColor_", 2068206072, "SQEX.Luminous.RenderInterface.Color", 1888, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonColorPin_", 2507867571, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1904, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonBrightnessSky_", 127127569, "float", 1992, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonBrightnessSkyPin_", 3506281748, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2000, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("mainLightSunColor_", 59584030, "SQEX.Luminous.RenderInterface.Color", 2096, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunLightScale_", 851310164, "float", 2112, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("mainLightMoonColor_", 1783833389, "SQEX.Luminous.RenderInterface.Color", 2128, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonLightScale_", 3703143299, "float", 2144, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("envSunColor_", 2078005942, "SQEX.Luminous.RenderInterface.Color", 2160, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("envSunScale_", 3089462429, "float", 2176, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("envMoonColor_", 926947621, "SQEX.Luminous.RenderInterface.Color", 2192, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("envMoonScale_", 1073083658, "float", 2208, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("starSize_", 2367835821, "float", 2212, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("starSizePin_", 562658288, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2216, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("starExtinctionHorizon_", 3744267610, "float", 2304, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("starExtinctionHorizoPin_", 2163246849, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2312, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("starBrightness_", 436879067, "float", 2400, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("starBrightnessEV_", 1368443334, "float", 2404, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("tilingStarBrightness_", 3457880770, "float", 2408, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("tilingStarBrightnessEV_", 3024994539, "float", 2412, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("milkywayBrightness_", 1046684088, "float", 2416, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("milkywayBrightnessEV_", 4149752365, "float", 2420, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("starTwinkleSpeed_", 3264214087, "float", 2424, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("starTwinkleSpeedPin_", 1880015666, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2432, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("tilingStarTwinkleSpeed_", 1929819934, "float", 2520, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("tilingStarTwinkleSpeedPin_", 1442652257, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2528, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("backgroundColor_", 3676648221, "SQEX.Luminous.RenderInterface.Color", 2624, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("backgroundColorIntensity_", 1851662122, "float", 2640, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("backgroundColorIntensityEV_", 2325900403, "float", 2644, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("groundColor_", 507939130, "SQEX.Luminous.RenderInterface.Color", 2656, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("groundColorPin_", 1002298141, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2672, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("groundAlbedo_", 3746466552, "float", 2760, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("groundAlbedoPin_", 3653154995, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2768, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("groundColorSpread_", 2163823711, "float", 2856, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("groundColorSpreadPin_", 2750049274, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2864, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("groundSpreadUp_", 981466349, "float", 2952, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("groundSpreadUpPin_", 2285178416, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2960, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("horizonOffset_", 3972531260, "float", 3048, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("extinctionStart_", 1089661071, "float", 3052, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("extinctionStartPin_", 2521273194, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3056, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("extinctionEnd_", 3145689024, "float", 3144, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("extinctionEndPin_", 1352391499, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3152, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("extinctionFalloff_", 3687057521, "float", 3240, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("extinctionFalloffPin_", 1818373300, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3248, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("midgroundColor_", 1453299034, "SQEX.Luminous.RenderInterface.Color", 3344, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("midgroundColorPin_", 1807965053, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3360, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("midgroundIntensity_", 2323613136, "float", 3448, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("midgroundIntensityPin_", 1398618523, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3456, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("viewElevationAngle_", 3205807067, "float", 3544, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("viewElevationAttenuation_", 3027767962, "float", 3548, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("axisTilt_", 1271777844, "float", 3552, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("axisAzimuth_", 3753876753, "float", 3556, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("centerOfRotationHeightOffset_", 924825956, "float", 3560, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("meridianTime_", 3122082956, "float", 3564, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonAxisTilt_", 79685647, "float", 3568, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonAxisAzimuth_", 3430599188, "float", 3572, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonCenterOfRotationHeightOffset_", 110503819, "float", 3576, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonMeridianTime_", 254365011, "float", 3580, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("starAxisTilt_", 1570427688, "float", 3584, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("starAxisAzimuth_", 754099421, "float", 3588, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("starMeridianTime_", 408508416, "float", 3592, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunDuration_", 1208776138, "float", 3596, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonDuration_", 989891917, "float", 3600, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("START_DAY_", 2688911951, "float", 3604, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("END_DAY_", 3971591676, "float", 3608, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonriseOffset_", 4232027239, "float", 3612, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientIntensity_", 2595803605, "float", 3616, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalIntensity_", 3480104993, "float", 3620, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientSpecUseDirLightShadow_", 3869096279, "float", 3624, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowPower_", 2925680519, "float", 3628, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}