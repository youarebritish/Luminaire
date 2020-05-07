using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.PostEffect
{
    public partial class SequenceActionSetVolLightFilter2 : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
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
		public Black.Sequence.ScreenEffect.VolLightFilterSequenceData masterData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetVolLightFilter2();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.PostEffect.SequenceActionSetVolLightFilter2", 0, Black.Sequence.PostEffect.SequenceActionSetVolLightFilter2.ObjectType, null, properties, 0, 3232);
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

            fieldProperties = new PropertyContainer("Black.Sequence.PostEffect.SequenceActionSetVolLightFilter2", base.GetFieldProperties(), 1656465513, -1985204164);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinEnable_", 448653220, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 368, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("zNear_pin_", 3582493832, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 456, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("zFar_pin_", 2629069015, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 544, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fogThickness_pin_", 3818667256, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 632, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("mainlightPower_pin_", 657939534, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 720, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("locallightPower_pin_", 3855721294, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 808, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientPower_pin_", 3502473797, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 896, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("emissivePower_pin_", 3592713072, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 984, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("tint_pin_", 2118369717, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1072, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("emissiveColor_pin_", 2548762698, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1160, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientCubemapPower_pin_", 3982059498, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1248, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientCubemapTenPercentHeight_pin_", 2346602768, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1336, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientCubemapStartY_pin_", 1281187944, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1424, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientDiffuseLightProbe_pin_", 3138686266, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1512, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noiseEnabled_pin_", 555223051, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1600, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noiseAmount_pin_", 2058335286, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1688, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noisePeriod_pin_", 3618484993, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1776, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noiseScrollSpeed_pin_", 2631714700, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1864, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noiseScrollRot_pin_", 3820781782, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1952, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noiseScrollTilt_pin_", 1816240440, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2040, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("heightFogEnabled_pin_", 214899992, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2128, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("tenPercentHeight_pin_", 785806235, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2216, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("startY_pin_", 624778931, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2304, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("playerRelative_pin_", 3377688385, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2392, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeInDistance_pin_", 921003580, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2480, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeInToe_pin_", 3356801181, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2568, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeInShoulder_pin_", 1653867681, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2656, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("blurPassCountVSM_pin_", 242082259, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2744, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("nearFarContrast_pin_", 778923255, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2832, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("extinction_pin_", 1447324851, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2920, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("masterData_", 2084001356, "Black.Sequence.ScreenEffect.VolLightFilterSequenceData", 3008, 224, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}