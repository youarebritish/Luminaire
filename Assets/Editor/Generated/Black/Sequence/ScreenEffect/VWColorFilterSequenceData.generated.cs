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
            return fieldProperties;
        }

		
    }
}