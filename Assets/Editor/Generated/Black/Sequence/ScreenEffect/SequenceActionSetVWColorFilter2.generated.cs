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
            
			
			
			return fieldProperties;
        }

		
    }
}