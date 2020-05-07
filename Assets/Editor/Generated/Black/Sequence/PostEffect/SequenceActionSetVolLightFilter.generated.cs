using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.PostEffect
{
    public partial class SequenceActionSetVolLightFilter : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool enabled_;
		public bool enableWeather_;
		public float zNear_;
		public float zFar_;
		public float fogThickness_;
		public float mainlightPower_;
		public float locallightPower_;
		public float ambientPower_;
		public float emissivePower_;
		public UnityEngine.Color tint_;
		public UnityEngine.Color emissiveColor_;
		public float ambientCubemapPower_;
		public float ambientCubemapTenPercentHeight_;
		public float ambientCubemapStartY_;
		public float ambientDiffuseLightProbe_;
		public bool noiseEnabled_;
		public float noiseAmount_;
		public float noisePeriod_;
		public float noiseScrollSpeed_;
		public float noiseScrollRot_;
		public float noiseScrollTilt_;
		public bool heightFogEnabled_;
		public float tenPercentHeight_;
		public float startY_;
		public float playerRelative_;
		public float fadeInDistance_;
		public float fadeInToe_;
		public float fadeInShoulder_;
		public int blurPassCountVSM_;
		public float nearFarContrast_;
		public float extinction_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pinEnable_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin zNear_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin zFar_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fogThickness_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin mainlightPower_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin locallightPower_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ambientPower_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin emissivePower_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin tint_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin emissiveColor_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ambientCubemapPower_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ambientCubemapTenPercentHeight_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ambientCubemapStartY_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ambientDiffuseLightProbe_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin noiseEnabled_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin noiseAmount_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin noisePeriod_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin noiseScrollSpeed_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin noiseScrollRot_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin noiseScrollTilt_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin heightFogEnabled_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin tenPercentHeight_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin startY_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin playerRelative_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fadeInDistance_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fadeInToe_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fadeInShoulder_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin blurPassCountVSM_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin nearFarContrast_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin extinction_pin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetVolLightFilter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.PostEffect.SequenceActionSetVolLightFilter", 0, Black.Sequence.PostEffect.SequenceActionSetVolLightFilter.ObjectType, null, properties, 0, 3152);
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

            fieldProperties = new PropertyContainer("Black.Sequence.PostEffect.SequenceActionSetVolLightFilter", base.GetFieldProperties(), 1653450857, 855231901);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enabled_", 1722022099, "bool", 368, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableWeather_", 1384777099, "bool", 369, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("zNear_", 908950600, "float", 372, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("zFar_", 2124336315, "float", 376, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fogThickness_", 795401080, "float", 380, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("mainlightPower_", 706193422, "float", 384, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("locallightPower_", 1535868686, "float", 388, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientPower_", 3641532409, "float", 392, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("emissivePower_", 3475641920, "float", 396, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("tint_", 4224566825, "Luminous.RenderInterface.Color", 400, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("emissiveColor_", 296452490, "Luminous.RenderInterface.Color", 416, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientCubemapPower_", 203577194, "float", 432, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientCubemapTenPercentHeight_", 4077947168, "float", 436, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientCubemapStartY_", 1255733096, "float", 440, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientDiffuseLightProbe_", 3848827194, "float", 444, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("noiseEnabled_", 1481878015, "bool", 448, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("noiseAmount_", 2595028454, "float", 452, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("noisePeriod_", 3196379829, "float", 456, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("noiseScrollSpeed_", 2915009852, "float", 460, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("noiseScrollRot_", 3029826630, "float", 464, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("noiseScrollTilt_", 1858906808, "float", 468, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("heightFogEnabled_", 1069938520, "bool", 472, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("tenPercentHeight_", 3699039887, "float", 476, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("startY_", 2799192663, "float", 480, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("playerRelative_", 152275701, "float", 484, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeInDistance_", 2997034092, "float", 488, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeInToe_", 1941734369, "float", 492, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeInShoulder_", 2033854101, "float", 496, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blurPassCountVSM_", 1644838455, "int", 500, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("nearFarContrast_", 1873267867, "float", 504, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("extinction_", 2372565079, "float", 508, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinEnable_", 448653220, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 512, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("zNear_pin_", 3582493832, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 600, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("zFar_pin_", 2629069015, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 688, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fogThickness_pin_", 3818667256, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 776, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("mainlightPower_pin_", 657939534, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 864, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("locallightPower_pin_", 3855721294, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 952, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientPower_pin_", 3502473797, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1040, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("emissivePower_pin_", 3592713072, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1128, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("tint_pin_", 2118369717, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1216, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("emissiveColor_pin_", 2548762698, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1304, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientCubemapPower_pin_", 3982059498, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1392, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientCubemapTenPercentHeight_pin_", 2346602768, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1480, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientCubemapStartY_pin_", 1281187944, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1568, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientDiffuseLightProbe_pin_", 3138686266, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1656, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noiseEnabled_pin_", 555223051, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1744, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noiseAmount_pin_", 2058335286, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1832, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noisePeriod_pin_", 3618484993, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1920, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noiseScrollSpeed_pin_", 2631714700, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2008, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noiseScrollRot_pin_", 3820781782, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2096, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noiseScrollTilt_pin_", 1816240440, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2184, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("heightFogEnabled_pin_", 214899992, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2272, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("tenPercentHeight_pin_", 785806235, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2360, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("startY_pin_", 624778931, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2448, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("playerRelative_pin_", 3377688385, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2536, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeInDistance_pin_", 921003580, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2624, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeInToe_pin_", 3356801181, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2712, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeInShoulder_pin_", 1653867681, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2800, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("blurPassCountVSM_pin_", 242082259, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2888, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("nearFarContrast_pin_", 778923255, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2976, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("extinction_pin_", 1447324851, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3064, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}