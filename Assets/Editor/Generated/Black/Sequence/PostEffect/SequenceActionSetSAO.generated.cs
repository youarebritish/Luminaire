using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.PostEffect
{
    public partial class SequenceActionSetSAO : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool enabled_;
		public float intensity_;
		public float contrast_;
		public float bias_;
		public float falloffRadius_;
		public float spiralTurns_;
		public float blurThreshold_;
		public float blurThresholdNormal_;
		public float blurFalloff_;
		public float blurDistFalloff_;
		public int numSamples_;
		public float temporalNearThreshold_;
		public float temporalFarExpFactor_;
		public float skinAOStrength_;
		public float eyeAOStrength_;
		public float backscatterAOStrength_;
		public bool directionalLightAO_;
		public float directionalLightAOStrength_;
		public float directionalLightAOMultiplier_;
		public float directionalLightAOContrast_;
		public float directionalLightAOFalloffStart_;
		public float directionalLightAOFalloffEnd_;
		public bool enableNewFoliageAO_;
		public float foliageAOStrength_;
		public float foliageAOMultiplier_;
		public float foliageAOContrast_;
		public float foliageAOFalloffStart_;
		public float foliageAOFalloffEnd_;
		public bool enableNewFoliageAODebug_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin numSamples_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin blurDistFalloff_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin blurFalloff_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin blurThresholdNormal_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin blurThreshold_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin spiralTurns_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin falloffRadius_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin bias_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin contrast_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin intensity_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin temporalNearThreshold_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin temporalFarExpFactor_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enabled_pin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetSAO();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.PostEffect.SequenceActionSetSAO", 0, Black.Sequence.PostEffect.SequenceActionSetSAO.ObjectType, null, properties, 0, 1632);
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

            fieldProperties = new PropertyContainer("Black.Sequence.PostEffect.SequenceActionSetSAO", base.GetFieldProperties(), -211387948, 1163944939);
            return fieldProperties;
        }

		
    }
}