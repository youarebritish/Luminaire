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
            
			
			
			return fieldProperties;
        }

		
    }
}