using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.ScreenEffect
{
    public partial class VolLightFilterSequenceData : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
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
		public bool farFogEnabled_;
		public float farFogThickness_;
		public float farFogZNear_;
		public float farFogZFar_;
		public float farFogHeightDecay_;
		public float farFogDistanceDecay_;
		public float farFogDepthDecay_;
		public float farFogExtinction_;
		public UnityEngine.Color farFogTint_;
		public float farFogStandardHeight_;
		public float farFogBottom_;
		public float farFogPlayerRelative_;
		public float farFogRadius_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new VolLightFilterSequenceData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.ScreenEffect.VolLightFilterSequenceData", 0, Black.Sequence.ScreenEffect.VolLightFilterSequenceData.ObjectType, null, properties, 0, 224);
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

            fieldProperties = new PropertyContainer("Black.Sequence.ScreenEffect.VolLightFilterSequenceData", base.GetFieldProperties(), 149068108, -1426137195);
            return fieldProperties;
        }

		
    }
}