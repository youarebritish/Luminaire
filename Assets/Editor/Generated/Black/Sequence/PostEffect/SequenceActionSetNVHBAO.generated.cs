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
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enabled_", 1722022099, "bool", 368, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("useGBufferNormal_", 113858101, "bool", 369, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("aoRadius_", 1866428744, "float", 372, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("aoBias_", 675984709, "float", 376, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("detailAO_", 3540894861, "float", 380, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("coarseAO_", 3962074077, "float", 384, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("powerExponent_", 3791493442, "float", 388, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableBlur_", 1801714400, "bool", 392, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("blurRadius_", 2561982531, "Black.Sequence.PostEffect.SequenceActionSetNVHBAO.BLUR_RADIUS_TYPE", 396, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("depthClamp_", 265517650, "Black.Sequence.PostEffect.SequenceActionSetNVHBAO.DEPTH_CLAMP_TYPE", 400, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableDepthThreshold_", 4071115511, "bool", 404, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("depthThresholdMaxViewDepth_", 3327028818, "float", 408, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("depthThresholdSharpness_", 3620601701, "float", 412, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blurSharpness_", 1301358136, "float", 416, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableBlurSharpnessProfile_", 1411483144, "bool", 420, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("blurSharpnessProfileForegroundSharpnessScale_", 1228210355, "float", 424, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blurSharpnessProfileBackgroundViewDepth_", 2114666607, "float", 428, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blurSharpnessProfileForegroundViewDepth_", 1975022242, "float", 432, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("enabled_pin_", 3058841247, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 440, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("useGBufferNormal_pin_", 1453710977, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 528, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("aoRadius_pin_", 654625160, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 616, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("aoBias_pin_", 1781907729, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 704, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("detailAO_pin_", 3495671273, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 792, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("coarseAO_pin_", 4097508729, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 880, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("powerExponent_pin_", 3823750642, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 968, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableBlur_pin_", 2111781328, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1056, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableDepthThreshold_pin_", 2642838163, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1144, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("depthThresholdMaxViewDepth_pin_", 1677604418, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1232, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("depthThresholdSharpness_pin_", 3263041521, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1320, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("blurSharpness_pin_", 3417461944, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1408, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableBlurSharpnessProfile_pin_", 2988816456, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1496, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("blurSharpnessProfileForegroundSharpnessScale_pin_", 2886400319, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1584, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("blurSharpnessProfileBackgroundViewDepth_pin_", 3709758011, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1672, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("blurSharpnessProfileForegroundViewDepth_pin_", 3459411730, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1760, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}