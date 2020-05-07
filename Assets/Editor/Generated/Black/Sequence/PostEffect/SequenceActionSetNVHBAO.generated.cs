using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.PostEffect
{
    public partial class SequenceActionSetNVHBAO : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool enabled_;
		public bool useGBufferNormal_;
		public float aoRadius_;
		public float aoBias_;
		public float detailAO_;
		public float coarseAO_;
		public float powerExponent_;
		public bool enableBlur_;
		public int blurRadius_;
		public int depthClamp_;
		public bool enableDepthThreshold_;
		public float depthThresholdMaxViewDepth_;
		public float depthThresholdSharpness_;
		public float blurSharpness_;
		public bool enableBlurSharpnessProfile_;
		public float blurSharpnessProfileForegroundSharpnessScale_;
		public float blurSharpnessProfileBackgroundViewDepth_;
		public float blurSharpnessProfileForegroundViewDepth_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enabled_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin useGBufferNormal_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin aoRadius_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin aoBias_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin detailAO_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin coarseAO_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin powerExponent_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enableBlur_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enableDepthThreshold_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin depthThresholdMaxViewDepth_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin depthThresholdSharpness_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin blurSharpness_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enableBlurSharpnessProfile_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin blurSharpnessProfileForegroundSharpnessScale_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin blurSharpnessProfileBackgroundViewDepth_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin blurSharpnessProfileForegroundViewDepth_pin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetNVHBAO();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.PostEffect.SequenceActionSetNVHBAO", 0, Black.Sequence.PostEffect.SequenceActionSetNVHBAO.ObjectType, null, properties, 0, 1848);
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

            fieldProperties = new PropertyContainer("Black.Sequence.PostEffect.SequenceActionSetNVHBAO", base.GetFieldProperties(), -1343389828, 1228046308);
            
			
			
			return fieldProperties;
        }

		
    }
}