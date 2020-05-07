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
            
			
			
			return fieldProperties;
        }

		
    }
}