using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.PostEffect
{
    public partial class SequenceActionSetFogFilter : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pinEnable_;
		public bool enabled_;
		public UnityEngine.Color primaryColor_;
		public UnityEngine.Color secondaryColor_;
		public float heightFalloffStart_;
		public float heightFalloffDistance_;
		public float heightFalloffPower_;
		public float noizeVariance_;
		public float noizeAmplitude_;
		public float noizeFrequency_;
		public int noizeSampleCount_;
		public float noizeSampleStepFactor_;
		public float minDistance_;
		public bool infiniteNoise_;
		public float animSpeedX_;
		public float animSpeedY_;
		public float animSpeedZ_;
		public float lightInfluence_;
		public float skyboxAbsorption_;
		public bool zNewExpFog_;
		public float zDensity_;
		public float zSkyAngleStart_;
		public float zSkyAngleEnd_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin zSkyAngleEnd_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin zSkyAngleStart_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin zDensity_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin zNewExpFog_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin skyboxAbsorption_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin lightInfluence_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin animSpeedZ_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin animSpeedY_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin animSpeedX_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin infiniteNoise_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin minDistance_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin noizeSampleStepFactor_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin noizeSampleCount_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin noizeFrequency_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin noizeAmplitude_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin noizeVariance_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin heightFalloffPower_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin heightFalloffDistance_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin heightFalloffStart_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin secondaryColor_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin primaryColor_pin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetFogFilter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.PostEffect.SequenceActionSetFogFilter", 0, Black.Sequence.PostEffect.SequenceActionSetFogFilter.ObjectType, null, properties, 0, 2432);
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

            fieldProperties = new PropertyContainer("Black.Sequence.PostEffect.SequenceActionSetFogFilter", base.GetFieldProperties(), 1771367630, -1383292135);
            return fieldProperties;
        }

		
    }
}