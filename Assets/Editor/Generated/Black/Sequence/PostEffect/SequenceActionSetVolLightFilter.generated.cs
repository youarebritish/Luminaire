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
            
			
			
			return fieldProperties;
        }

		
    }
}