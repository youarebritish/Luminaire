using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.ScreenEffect
{
    public partial class VWColorFilterSequenceData : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool prop_enabled_;
		public bool enableWeather_;
		public bool prop_CAT_;
		public bool prop_sRGBGamma_;
		public bool prop_Dither_;
		public float prop_SceneEv_;
		public float prop_UserEv_;
		public bool prop_EnabledWhite_;
		public float prop_G_M_;
		public float prop_B_Y_;
		public bool prop_EnabledToneCurve_;
		public float prop_HighRange_;
		public float prop_Contrast_;
		public float prop_ZeroSlope_;
		public float prop_Dark_;
		public bool prop_EnabledHue_;
		public float prop_rotM_;
		public float prop_rotY_;
		public float prop_rotG_;
		public float prop_rotB_;
		public bool prop_EnabledSaturationALL_;
		public bool prop_EnabledSaturation_;
		public float prop_sAll_;
		public float prop_sM_;
		public float prop_sY_;
		public float prop_sG_;
		public float prop_sB_;
		public bool prop_EnabledSaturationClamp_;
		public float prop_scAll_;
		public float prop_scM_;
		public float prop_scY_;
		public float prop_scG_;
		public float prop_scB_;
		public bool prop_EnabledSaturationByKido_;
		public float prop_s0_;
		public float prop_s1_;
		public float prop_s2_;
		public float prop_s3_;
		public float prop_s4_;
		public float prop_sM0_;
		public float prop_sM1_;
		public float prop_sM2_;
		public float prop_sM3_;
		public float prop_sM4_;
		public float prop_sY0_;
		public float prop_sY1_;
		public float prop_sY2_;
		public float prop_sY3_;
		public float prop_sY4_;
		public float prop_sG0_;
		public float prop_sG1_;
		public float prop_sG2_;
		public float prop_sG3_;
		public float prop_sG4_;
		public float prop_sB0_;
		public float prop_sB1_;
		public float prop_sB2_;
		public float prop_sB3_;
		public float prop_sB4_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new VWColorFilterSequenceData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.ScreenEffect.VWColorFilterSequenceData", 0, Black.Sequence.ScreenEffect.VWColorFilterSequenceData.ObjectType, null, properties, 0, 232);
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

            fieldProperties = new PropertyContainer("Black.Sequence.ScreenEffect.VWColorFilterSequenceData", base.GetFieldProperties(), -1923130469, 1173334696);
            
			
			
			fieldProperties.AddProperty(new Property("prop_enabled_", 3261870259, "bool", 8, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("enableWeather_", 1384777099, "bool", 9, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_CAT_", 1913099272, "bool", 10, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sRGBGamma_", 2538650783, "bool", 11, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_Dither_", 680642670, "bool", 12, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_SceneEv_", 3539896345, "float", 16, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_UserEv_", 2913378802, "float", 20, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_EnabledWhite_", 3078973372, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_G_M_", 3857145607, "float", 28, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_B_Y_", 3994969694, "float", 32, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_EnabledToneCurve_", 1349975154, "bool", 36, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_HighRange_", 1904573039, "float", 40, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_Contrast_", 878492740, "float", 44, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_ZeroSlope_", 2243133463, "float", 48, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_Dark_", 3655006190, "float", 52, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_EnabledHue_", 3600874237, "bool", 56, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_rotM_", 3681628786, "float", 60, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_rotY_", 3684880190, "float", 64, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_rotG_", 3682614524, "float", 68, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_rotB_", 3683158977, "float", 72, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_EnabledSaturationALL_", 1204218982, "bool", 76, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_EnabledSaturation_", 4291873283, "bool", 77, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sAll_", 1241159314, "float", 80, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sM_", 381222086, "float", 84, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sY_", 383193562, "float", 88, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sG_", 379544800, "float", 92, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sB_", 378809325, "float", 96, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_EnabledSaturationClamp_", 1436459566, "bool", 100, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_scAll_", 1417434779, "float", 104, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_scM_", 199421695, "float", 108, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_scY_", 196170291, "float", 112, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_scG_", 197744409, "float", 116, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_scB_", 3418502804, "float", 120, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_EnabledSaturationByKido_", 2837853047, "bool", 124, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_s0_", 3587297579, "float", 128, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_s1_", 366244994, "float", 132, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_s2_", 365803709, "float", 136, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_s3_", 3587150484, "float", 140, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_s4_", 366789447, "float", 144, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sM0_", 2640497272, "float", 148, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sM1_", 2640350177, "float", 152, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sM2_", 1567127014, "float", 156, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sM3_", 1566979919, "float", 160, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sM4_", 2639908892, "float", 164, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sY0_", 2021834260, "float", 168, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sY1_", 3095454781, "float", 172, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sY2_", 3095896066, "float", 176, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sY3_", 2021981355, "float", 180, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sY4_", 2022525808, "float", 184, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sG0_", 476034726, "float", 188, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sG1_", 475887631, "float", 192, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sG2_", 1549508152, "float", 196, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sG3_", 1549361057, "float", 200, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sG4_", 475446346, "float", 204, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sB0_", 1009677757, "float", 208, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sB1_", 4231024532, "float", 212, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sB2_", 4231171627, "float", 216, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sB3_", 1010119042, "float", 220, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("prop_sB4_", 1010266137, "float", 224, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			
			
			return fieldProperties;
        }

		
    }
}