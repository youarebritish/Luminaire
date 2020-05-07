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
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enabled_", 1722022099, "bool", 368, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("updateParaemters_", 1552330677, "bool", 369, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("blendMode_", 3554201852, "Black.Sequence.PostEffect.SequenceActionSetNVVXAO.BLEND_MODE_TYPE", 372, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("clipmapRange_", 1927317965, "float", 376, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("voxelResolution_", 257455166, "Black.Sequence.PostEffect.SequenceActionSetNVVXAO.VOXEL_RESOLUTION_TYPE", 380, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("voxelDimension_", 1926675194, "Black.Sequence.PostEffect.SequenceActionSetNVVXAO.VOXEL_DIMENSION_TYPE", 384, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("voxelizationThickness_", 4273687862, "float", 388, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("thicknessFactorForAlphablended_", 641791092, "float", 392, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("opacityNoiseScale_", 2418979271, "float", 396, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("opacityNoiseBias_", 834579310, "float", 400, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("twoSided_", 3800902583, "bool", 404, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("frontCounterClockwise_", 526328639, "bool", 405, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxSamples_", 4291866493, "float", 408, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("tracingStep_", 568052308, "float", 412, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("opacityCorrectionFactor_", 2194521166, "float", 416, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("flipOpacityDirection_", 930681333, "bool", 420, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("numCones_", 3611339150, "float", 424, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientRange_", 3437320845, "float", 428, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientScale_", 150805524, "float", 432, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientBias_", 402104647, "float", 436, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientPower_", 3641532409, "float", 440, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientDistanceDarkening_", 84625542, "float", 444, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableConeRotation_", 869871248, "bool", 448, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableRandomConeOffsets_", 1503623371, "bool", 449, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("tracingSparsity_", 164958195, "float", 452, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("coneNormalGroupingFactor_", 2212663932, "float", 456, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("initialOffsetBias_", 2645186110, "float", 460, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("initialOffsetDistanceFactor_", 977749377, "float", 464, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableScreenSpaceCorrection_", 3066099345, "bool", 468, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("screenSpaceCorrectionStartOffset_", 2423205953, "float", 472, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableSparseTracingRefinement_", 2767807226, "float", 476, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("enabled_pin_", 3058841247, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 480, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("clipmapRange_pin_", 291351081, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 568, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("voxelizationThickness_pin_", 910288902, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 656, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("thicknessFactorForAlphablended_pin_", 655689556, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 744, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("opacityNoiseScale_pin_", 41586275, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 832, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("opacityNoiseBias_pin_", 1891587566, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 920, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("tracingStep_pin_", 2128200436, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1008, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("opacityCorrectionFactor_pin_", 868388750, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1096, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientRange_pin_", 1095937001, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1184, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientScale_pin_", 968353972, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1272, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientBias_pin_", 2747463139, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1360, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientPower_pin_", 3502473797, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1448, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientDistanceDarkening_pin_", 4189368854, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1536, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("initialOffsetBias_pin_", 2914523454, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1624, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("initialOffsetDistanceFactor_pin_", 1263916029, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1712, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("screenSpaceCorrectionStartOffset_pin_", 197090493, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1800, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}