using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.PostEffect
{
    public partial class SequenceActionSetNVVXAO : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool enabled_;
		public bool updateParaemters_;
		public int blendMode_;
		public float clipmapRange_;
		public int voxelResolution_;
		public int voxelDimension_;
		public float voxelizationThickness_;
		public float thicknessFactorForAlphablended_;
		public float opacityNoiseScale_;
		public float opacityNoiseBias_;
		public bool twoSided_;
		public bool frontCounterClockwise_;
		public float maxSamples_;
		public float tracingStep_;
		public float opacityCorrectionFactor_;
		public bool flipOpacityDirection_;
		public float numCones_;
		public float ambientRange_;
		public float ambientScale_;
		public float ambientBias_;
		public float ambientPower_;
		public float ambientDistanceDarkening_;
		public bool enableConeRotation_;
		public bool enableRandomConeOffsets_;
		public float tracingSparsity_;
		public float coneNormalGroupingFactor_;
		public float initialOffsetBias_;
		public float initialOffsetDistanceFactor_;
		public bool enableScreenSpaceCorrection_;
		public float screenSpaceCorrectionStartOffset_;
		public float enableSparseTracingRefinement_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enabled_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin clipmapRange_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin voxelizationThickness_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin thicknessFactorForAlphablended_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin opacityNoiseScale_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin opacityNoiseBias_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin tracingStep_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin opacityCorrectionFactor_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ambientRange_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ambientScale_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ambientBias_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ambientPower_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ambientDistanceDarkening_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin initialOffsetBias_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin initialOffsetDistanceFactor_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin screenSpaceCorrectionStartOffset_pin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetNVVXAO();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.PostEffect.SequenceActionSetNVVXAO", 0, Black.Sequence.PostEffect.SequenceActionSetNVVXAO.ObjectType, null, properties, 0, 1888);
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

            fieldProperties = new PropertyContainer("Black.Sequence.PostEffect.SequenceActionSetNVVXAO", base.GetFieldProperties(), 145362314, -1945833849);
            
			
			
			return fieldProperties;
        }

		
    }
}