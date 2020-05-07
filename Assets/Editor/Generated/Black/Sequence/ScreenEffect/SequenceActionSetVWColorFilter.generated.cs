using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.ScreenEffect
{
    public partial class SequenceActionSetVWColorFilter : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
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
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sB4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sB3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sB2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sB1_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sB0_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sG4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sG3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sG2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sG1_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sG0_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sY4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sY3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sY2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sY1_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sY0_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sM4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sM3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sM2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sM1_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sM0_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_s4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_s3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_s2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_s1_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_s0_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_EnabledSaturationByKido_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_scB_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_scG_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_scY_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_scM_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_scAll_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_EnabledSaturationClamp_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sB_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sG_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sY_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sM_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sAll_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_EnabledSaturation_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_EnabledSaturationALL_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_rotB_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_rotG_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_rotY_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_rotM_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_EnabledHue_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_Dark_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_ZeroSlope_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_Contrast_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_HighRange_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_EnabledToneCurve_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_B_Y_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_G_M_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_EnabledWhite_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_UserEv_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_SceneEv_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_Exposure_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_sRGBGamma_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_Dither_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_CAT_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_enabled_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetVWColorFilter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.ScreenEffect.SequenceActionSetVWColorFilter", 0, Black.Sequence.ScreenEffect.SequenceActionSetVWColorFilter.ObjectType, null, properties, 0, 5784);
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

            fieldProperties = new PropertyContainer("Black.Sequence.ScreenEffect.SequenceActionSetVWColorFilter", base.GetFieldProperties(), -1142988734, -2014663219);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_enabled_", 3261870259, "bool", 368, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableWeather_", 1384777099, "bool", 369, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_CAT_", 1913099272, "bool", 370, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sRGBGamma_", 2538650783, "bool", 371, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_Dither_", 680642670, "bool", 372, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_SceneEv_", 3539896345, "float", 376, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_UserEv_", 2913378802, "float", 380, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_EnabledWhite_", 3078973372, "bool", 384, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_G_M_", 3857145607, "float", 388, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_B_Y_", 3994969694, "float", 392, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_EnabledToneCurve_", 1349975154, "bool", 396, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_HighRange_", 1904573039, "float", 400, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_Contrast_", 878492740, "float", 404, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_ZeroSlope_", 2243133463, "float", 408, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_Dark_", 3655006190, "float", 412, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_EnabledHue_", 3600874237, "bool", 416, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_rotM_", 3681628786, "float", 420, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_rotY_", 3684880190, "float", 424, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_rotG_", 3682614524, "float", 428, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_rotB_", 3683158977, "float", 432, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_EnabledSaturationALL_", 1204218982, "bool", 436, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_EnabledSaturation_", 4291873283, "bool", 437, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sAll_", 1241159314, "float", 440, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sM_", 381222086, "float", 444, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sY_", 383193562, "float", 448, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sG_", 379544800, "float", 452, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sB_", 378809325, "float", 456, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_EnabledSaturationClamp_", 1436459566, "bool", 460, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_scAll_", 1417434779, "float", 464, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_scM_", 199421695, "float", 468, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_scY_", 196170291, "float", 472, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_scG_", 197744409, "float", 476, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_scB_", 3418502804, "float", 480, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_EnabledSaturationByKido_", 2837853047, "bool", 484, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_s0_", 3587297579, "float", 488, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_s1_", 366244994, "float", 492, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_s2_", 365803709, "float", 496, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_s3_", 3587150484, "float", 500, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_s4_", 366789447, "float", 504, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sM0_", 2640497272, "float", 508, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sM1_", 2640350177, "float", 512, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sM2_", 1567127014, "float", 516, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sM3_", 1566979919, "float", 520, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sM4_", 2639908892, "float", 524, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sY0_", 2021834260, "float", 528, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sY1_", 3095454781, "float", 532, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sY2_", 3095896066, "float", 536, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sY3_", 2021981355, "float", 540, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sY4_", 2022525808, "float", 544, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sG0_", 476034726, "float", 548, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sG1_", 475887631, "float", 552, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sG2_", 1549508152, "float", 556, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sG3_", 1549361057, "float", 560, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sG4_", 475446346, "float", 564, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sB0_", 1009677757, "float", 568, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sB1_", 4231024532, "float", 572, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sB2_", 4231171627, "float", 576, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sB3_", 1010119042, "float", 580, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("prop_sB4_", 1010266137, "float", 584, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sB4_", 902427029, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 592, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sB3_", 903559862, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 680, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sB2_", 4124612447, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 768, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sB1_", 4124465352, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 856, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sB0_", 903118577, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 944, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sG4_", 4007290702, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1032, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sG3_", 4006157869, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1120, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sG2_", 4006304964, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1208, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sG1_", 2932787611, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1296, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sG0_", 2932934706, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1384, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sY4_", 2988351148, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1472, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sY3_", 1915422175, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1560, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sY2_", 2989336886, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1648, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sY1_", 2988895601, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1736, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sY0_", 1915275080, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1824, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sM4_", 803018336, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1912, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sM3_", 4023776731, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2000, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sM2_", 4023923826, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2088, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sM1_", 802282861, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2176, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sM0_", 802429956, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2264, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_s4_", 558674955, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2352, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_s3_", 559219408, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2440, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_s2_", 3780271993, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2528, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_s1_", 3780713278, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2616, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_s0_", 3780566183, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2704, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_EnabledSaturationByKido_", 1707168283, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2792, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_scB_", 4289965256, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2880, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_scG_", 1067926933, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2968, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_scY_", 4286272567, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3056, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_scM_", 1066941195, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3144, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_scAll_", 3803921327, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3232, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_EnabledSaturationClamp_", 3222503994, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3320, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sB_", 3762043497, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3408, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sG_", 3761602212, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3496, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sY_", 3766427734, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3584, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sM_", 3763176330, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3672, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sAll_", 3087218382, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3760, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_EnabledSaturation_", 1146313511, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3848, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_EnabledSaturationALL_", 2739270130, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3936, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_rotB_", 3349355021, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4024, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_rotG_", 3350090496, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4112, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_rotY_", 3353739258, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4200, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_rotM_", 3351767782, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4288, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_EnabledHue_", 814957329, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4376, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_Dark_", 11439794, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4464, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_ZeroSlope_", 1384488355, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4552, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_Contrast_", 3773992000, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4640, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_HighRange_", 3698928083, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4728, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_EnabledToneCurve_", 380258398, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4816, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_B_Y_", 3779302906, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4904, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_G_M_", 3524396659, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4992, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_EnabledWhite_", 2324764536, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 5080, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_UserEv_", 610405694, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 5168, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_SceneEv_", 3942303285, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 5256, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_Exposure_", 1634977081, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 5344, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sRGBGamma_", 285626195, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 5432, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_Dither_", 1584760658, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 5520, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_CAT_", 1272342724, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 5608, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_enabled_", 2004716767, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 5696, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}