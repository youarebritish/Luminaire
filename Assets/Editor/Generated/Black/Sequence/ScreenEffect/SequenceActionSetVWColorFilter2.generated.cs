using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.ScreenEffect
{
    public partial class SequenceActionSetVWColorFilter2 : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
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
		public Black.Sequence.ScreenEffect.VWColorFilterSequenceData masterData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetVWColorFilter2();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.ScreenEffect.SequenceActionSetVWColorFilter2", 0, Black.Sequence.ScreenEffect.SequenceActionSetVWColorFilter2.ObjectType, null, properties, 0, 5792);
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

            fieldProperties = new PropertyContainer("Black.Sequence.ScreenEffect.SequenceActionSetVWColorFilter2", base.GetFieldProperties(), 29141481, -1809260725);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sB4_", 902427029, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 368, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sB3_", 903559862, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 456, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sB2_", 4124612447, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 544, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sB1_", 4124465352, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 632, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sB0_", 903118577, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 720, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sG4_", 4007290702, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 808, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sG3_", 4006157869, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 896, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sG2_", 4006304964, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 984, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sG1_", 2932787611, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1072, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sG0_", 2932934706, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1160, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sY4_", 2988351148, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1248, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sY3_", 1915422175, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1336, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sY2_", 2989336886, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1424, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sY1_", 2988895601, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1512, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sY0_", 1915275080, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1600, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sM4_", 803018336, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1688, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sM3_", 4023776731, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1776, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sM2_", 4023923826, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1864, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sM1_", 802282861, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1952, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sM0_", 802429956, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2040, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_s4_", 558674955, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2128, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_s3_", 559219408, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2216, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_s2_", 3780271993, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2304, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_s1_", 3780713278, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2392, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_s0_", 3780566183, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2480, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_EnabledSaturationByKido_", 1707168283, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2568, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_scB_", 4289965256, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2656, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_scG_", 1067926933, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2744, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_scY_", 4286272567, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2832, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_scM_", 1066941195, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2920, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_scAll_", 3803921327, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3008, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_EnabledSaturationClamp_", 3222503994, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3096, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sB_", 3762043497, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3184, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sG_", 3761602212, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3272, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sY_", 3766427734, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3360, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sM_", 3763176330, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3448, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sAll_", 3087218382, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3536, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_EnabledSaturation_", 1146313511, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3624, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_EnabledSaturationALL_", 2739270130, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3712, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_rotB_", 3349355021, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3800, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_rotG_", 3350090496, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3888, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_rotY_", 3353739258, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3976, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_rotM_", 3351767782, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4064, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_EnabledHue_", 814957329, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4152, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_Dark_", 11439794, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4240, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_ZeroSlope_", 1384488355, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4328, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_Contrast_", 3773992000, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4416, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_HighRange_", 3698928083, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4504, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_EnabledToneCurve_", 380258398, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4592, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_B_Y_", 3779302906, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4680, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_G_M_", 3524396659, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4768, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_EnabledWhite_", 2324764536, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4856, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_UserEv_", 610405694, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 4944, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_SceneEv_", 3942303285, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 5032, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_Exposure_", 1634977081, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 5120, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_sRGBGamma_", 285626195, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 5208, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_Dither_", 1584760658, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 5296, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_CAT_", 1272342724, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 5384, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin_enabled_", 2004716767, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 5472, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("masterData_", 2084001356, "Black.Sequence.ScreenEffect.VWColorFilterSequenceData", 5560, 232, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}