using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Render
{
    public partial class SequenceActionSetProceduralCloud : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool enableWeather_;
		public float cloudWindDirection_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cloudWindDirectionPin_;
		public float cloudWindSpeed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cloudWindSpeedPin_;
		public float altitudeElevation_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin altitudeElevationPin_;
		public float altitudeThickness_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin altitudeThicknessPin_;
		public UnityEngine.Color sunlightForCloud_;
		public float sunlightIntensityForCloud_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunlightIntensityForCloudPin_;
		public UnityEngine.Color ambientTopColor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ambientTopColorPin_;
		public float ambientTopIntensity_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ambientTopIntensityForCloudPin_;
		public UnityEngine.Color ambientBottomColor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ambientBottomColorPin_;
		public float ambientBottomIntensity_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ambientBottomIntensityForCloudPin_;
		public float extinctionScatteringFactorX100_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin extinctionScatteringFactorX100Pin_;
		public float drawDistance_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin drawDistancePin_;
		public float atmScatterScale_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin atmScatterScalePin_;
		public float atmScatterPower_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin atmScatterPowerPin_;
		public float atmScatterScale_sunDiskCover_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin atmScatterScaleSunDiskCoverPin_;
		public float atmScatterPower_sunDiskCover_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin atmScatterPowerSunDiskCoverPin_;
		public bool useNewSystem_;
		public float amplitude1_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin amplitude1Pin_;
		public float amplitude2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin amplitude2Pin_;
		public float amplitude3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin amplitude3Pin_;
		public float amplitude4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin amplitude4Pin_;
		public float amplitude5_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin amplitude5Pin_;
		public float amplitude6_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin amplitude6Pin_;
		public float amplitude7_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin amplitude7Pin_;
		public float frequency1_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin frequency1Pin_;
		public float frequency2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin frequency2Pin_;
		public float frequency3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin frequency3Pin_;
		public float frequency4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin frequency4Pin_;
		public float frequency5_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin frequency5Pin_;
		public float frequency6_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin frequency6Pin_;
		public float frequency7_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin frequency7Pin_;
		public float frequencyMultAll_;
		public float frequencyY1_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin frequencyY1Pin_;
		public float frequencyY2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin frequencyY2Pin_;
		public float frequencyY3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin frequencyY3Pin_;
		public float frequencyY4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin frequencyY4Pin_;
		public float animSpeed1_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin animSpeed1Pin_;
		public float animSpeed2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin animSpeed2Pin_;
		public float animSpeed3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin animSpeed3Pin_;
		public float animSpeed4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin animSpeed4Pin_;
		public float animSpeed5_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin animSpeed5Pin_;
		public float animSpeed6_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin animSpeed6Pin_;
		public float animSpeed7_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin animSpeed7Pin_;
		public float heightDensityFalloff_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin heightDensityFalloffPin_;
		public float densityAmbientFactor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin densityAmbientFactorPin_;
		public float lightingAnisotropy_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin lightingAnisotropyPin_;
		public float lightingContrast_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin lightingContrastPin_;
		public float coverage_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin coveragePin_;
		public float highCloudOpacity_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin highCloudOpacityPin_;
		public UnityEngine.Color sunlightHighCloud_;
		public float sunlightIntensityForHighCloud_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunlightIntensityForHighCloudPin_;
		public float lightingAnisotropyHighCloud_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin lightingAnisotropyHighCloudPin_;
		public float groundShadowScale_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groundShadowScalePin_;
		public float shadowOpacity_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin shadowOpacityPin_;
		public float shadowContrast_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin shadowContrastPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetProceduralCloud();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Render.SequenceActionSetProceduralCloud", 0, Black.Sequence.Action.Render.SequenceActionSetProceduralCloud.ObjectType, null, properties, 0, 5328);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Render.SequenceActionSetProceduralCloud", base.GetFieldProperties(), -1683402606, 416072340);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableWeather_", 1384777099, "bool", 368, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("cloudWindDirection_", 2808783710, "float", 372, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("cloudWindDirectionPin_", 1557688225, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 376, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cloudWindSpeed_", 4096991264, "float", 464, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("cloudWindSpeedPin_", 3082382443, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 472, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("altitudeElevation_", 1688610531, "float", 560, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("altitudeElevationPin_", 3650452302, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 568, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("altitudeThickness_", 374993472, "float", 656, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("altitudeThicknessPin_", 746188491, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 664, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunlightForCloud_", 1078190972, "Luminous.RenderInterface.Color", 752, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunlightIntensityForCloud_", 2497218817, "float", 768, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunlightIntensityForCloudPin_", 1038452996, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 776, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientTopColor_", 1512008446, "Luminous.RenderInterface.Color", 864, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientTopColorPin_", 1703600129, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 880, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientTopIntensity_", 905946724, "float", 968, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientTopIntensityForCloudPin_", 1764272719, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 976, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientBottomColor_", 3304193340, "Luminous.RenderInterface.Color", 1072, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientBottomColorPin_", 3449425607, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1088, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientBottomIntensity_", 3679213470, "float", 1176, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientBottomIntensityForCloudPin_", 2624184557, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1184, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("extinctionScatteringFactorX100_", 2870001589, "float", 1272, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("extinctionScatteringFactorX100Pin_", 767821800, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1280, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("drawDistance_", 909506633, "float", 1368, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("drawDistancePin_", 2759589084, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1376, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("atmScatterScale_", 1530461868, "float", 1464, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("atmScatterScalePin_", 9517495, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1472, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("atmScatterPower_", 625212017, "float", 1560, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("atmScatterPowerPin_", 3608416948, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1568, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("atmScatterScale_sunDiskCover_", 3570128147, "float", 1656, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("atmScatterScaleSunDiskCoverPin_", 4170760925, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1664, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("atmScatterPower_sunDiskCover_", 3745428784, "float", 1752, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("atmScatterPowerSunDiskCoverPin_", 240233462, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1760, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("useNewSystem_", 1525592940, "bool", 1848, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("amplitude1_", 615478274, "float", 1852, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("amplitude1Pin_", 377604757, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1856, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("amplitude2_", 615036989, "float", 1944, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("amplitude2Pin_", 3748416128, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1952, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("amplitude3_", 3836383764, "float", 2040, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("amplitude3Pin_", 1509430703, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2048, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("amplitude4_", 616022727, "float", 2136, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("amplitude4Pin_", 2384183986, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2144, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("amplitude5_", 616169822, "float", 2232, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("amplitude5Pin_", 97712545, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2240, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("amplitude6_", 615625369, "float", 2328, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("amplitude6Pin_", 1659916780, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2336, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("amplitude7_", 3837075312, "float", 2424, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("amplitude7Pin_", 2913204603, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2432, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("frequency1_", 2202391261, "float", 2520, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("frequency1Pin_", 3841979232, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2528, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("frequency2_", 2202832546, "float", 2616, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("frequency2Pin_", 2577126389, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2624, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("frequency3_", 3276453067, "float", 2712, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("frequency3Pin_", 1631265958, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2720, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("frequency4_", 3276894352, "float", 2808, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("frequency4Pin_", 488067163, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2816, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("frequency5_", 2202979641, "float", 2904, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("frequency5Pin_", 3859335244, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2912, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("frequency6_", 2203524094, "float", 3000, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("frequency6Pin_", 1872673537, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3008, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("frequency7_", 2203376999, "float", 3096, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("frequency7Pin_", 2011712914, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3104, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("frequencyMultAll_", 1276288931, "float", 3192, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("frequencyY1_", 1825866860, "float", 3196, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("frequencyY1Pin_", 2643395959, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3200, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("frequencyY2_", 752246339, "float", 3288, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("frequencyY2Pin_", 1895383406, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3296, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("frequencyY3_", 1826161050, "float", 3384, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("frequencyY3Pin_", 3370388669, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3392, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("frequencyY4_", 1826308145, "float", 3480, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("frequencyY4Pin_", 3040924276, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3488, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("animSpeed1_", 3062541523, "float", 3576, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("animSpeed1Pin_", 4161571518, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3584, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("animSpeed2_", 3062394428, "float", 3672, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("animSpeed2Pin_", 1269836231, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3680, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("animSpeed3_", 4135911781, "float", 3768, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("animSpeed3Pin_", 1574052376, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3776, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("animSpeed4_", 4137044614, "float", 3864, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("animSpeed4Pin_", 2378563833, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3872, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("animSpeed5_", 4136897519, "float", 3960, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("animSpeed5Pin_", 3091862666, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3968, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("animSpeed6_", 3062982808, "float", 4056, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("animSpeed6Pin_", 3085829139, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4064, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("animSpeed7_", 3062835713, "float", 4152, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("animSpeed7Pin_", 1996076036, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4160, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("heightDensityFalloff_", 2500338141, "float", 4248, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("heightDensityFalloffPin_", 4029290592, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4256, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("densityAmbientFactor_", 2588474355, "float", 4344, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("densityAmbientFactorPin_", 1586867230, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4352, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lightingAnisotropy_", 890043642, "float", 4440, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("lightingAnisotropyPin_", 460209885, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4448, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lightingContrast_", 2207676344, "float", 4536, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("lightingContrastPin_", 1852925299, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4544, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("coverage_", 2508320012, "float", 4632, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("coveragePin_", 883714647, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4640, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("highCloudOpacity_", 3765546512, "float", 4728, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("highCloudOpacityPin_", 1904858331, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4736, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunlightHighCloud_", 2900556017, "Luminous.RenderInterface.Color", 4832, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunlightIntensityForHighCloud_", 4211193485, "float", 4848, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunlightIntensityForHighCloudPin_", 4000703248, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4856, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lightingAnisotropyHighCloud_", 2200200919, "float", 4944, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("lightingAnisotropyHighCloudPin_", 1118586946, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4952, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("groundShadowScale_", 2736921177, "float", 5040, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("groundShadowScalePin_", 2977957804, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 5048, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowOpacity_", 146601951, "float", 5136, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowOpacityPin_", 445502074, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 5144, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowContrast_", 4000951952, "float", 5232, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowContrastPin_", 2570811995, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 5240, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}