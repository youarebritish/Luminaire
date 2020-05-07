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
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.pinName_", 3330161590, "Base.String", 184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.name_", 192292993, "Base.String", 200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.connections_", 490033121, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 216, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayType_", 261766523, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 248, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayTime_", 1689218608, "float", 252, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayMaxTime_", 1529341114, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.pinName_", 1137295951, "Base.String", 280, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.name_", 2182257194, "Base.String", 296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.connections_", 2048532136, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 312, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("out_.delayType_", 124432558, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 344, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.delayTime_", 3264366185, "float", 348, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.delayMaxTime_", 456551125, "float", 352, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enabled_pin_.pinName_", 2357309002, "Base.String", 448, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enabled_pin_.name_", 1197700885, "Base.String", 464, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enabled_pin_.connections_", 2896948621, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 480, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("enabled_pin_.pinValueType_", 458415388, "Base.String", 512, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useGBufferNormal_pin_.pinName_", 1535423832, "Base.String", 536, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useGBufferNormal_pin_.name_", 1649757683, "Base.String", 552, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useGBufferNormal_pin_.connections_", 3305531355, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 568, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("useGBufferNormal_pin_.pinValueType_", 1290796966, "Base.String", 600, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("aoRadius_pin_.pinName_", 594252551, "Base.String", 624, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("aoRadius_pin_.name_", 2063558194, "Base.String", 640, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("aoRadius_pin_.connections_", 1558790048, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 656, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("aoRadius_pin_.pinValueType_", 52990011, "Base.String", 688, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("aoBias_pin_.pinName_", 2116853768, "Base.String", 712, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("aoBias_pin_.name_", 3070022627, "Base.String", 728, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("aoBias_pin_.connections_", 3601993707, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 744, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("aoBias_pin_.pinValueType_", 1547647894, "Base.String", 776, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("detailAO_pin_.pinName_", 490690384, "Base.String", 800, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("detailAO_pin_.name_", 1568582075, "Base.String", 816, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("detailAO_pin_.connections_", 594006355, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 832, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("detailAO_pin_.pinValueType_", 1363492974, "Base.String", 864, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("coarseAO_pin_.pinName_", 2947880704, "Base.String", 888, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("coarseAO_pin_.name_", 383716587, "Base.String", 904, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("coarseAO_pin_.connections_", 3436870179, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 920, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("coarseAO_pin_.pinValueType_", 3275064798, "Base.String", 952, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("powerExponent_pin_.pinName_", 1028754421, "Base.String", 976, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("powerExponent_pin_.name_", 3269232944, "Base.String", 992, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("powerExponent_pin_.connections_", 4131646334, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1008, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("powerExponent_pin_.pinValueType_", 296405557, "Base.String", 1040, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enableBlur_pin_.pinName_", 36796543, "Base.String", 1064, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enableBlur_pin_.name_", 3826881178, "Base.String", 1080, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enableBlur_pin_.connections_", 2872305208, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1096, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("enableBlur_pin_.pinValueType_", 157803747, "Base.String", 1128, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enableDepthThreshold_pin_.pinName_", 3635766518, "Base.String", 1152, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enableDepthThreshold_pin_.name_", 396313537, "Base.String", 1168, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enableDepthThreshold_pin_.connections_", 1668977441, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1184, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("enableDepthThreshold_pin_.pinValueType_", 1070494776, "Base.String", 1216, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("depthThresholdMaxViewDepth_pin_.pinName_", 642964261, "Base.String", 1240, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("depthThresholdMaxViewDepth_pin_.name_", 633909536, "Base.String", 1256, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("depthThresholdMaxViewDepth_pin_.connections_", 561832526, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1272, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("depthThresholdMaxViewDepth_pin_.pinValueType_", 2762600421, "Base.String", 1304, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("depthThresholdSharpness_pin_.pinName_", 715201768, "Base.String", 1328, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("depthThresholdSharpness_pin_.name_", 3816476547, "Base.String", 1344, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("depthThresholdSharpness_pin_.connections_", 3562228619, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1360, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("depthThresholdSharpness_pin_.pinValueType_", 2069111606, "Base.String", 1392, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("blurSharpness_pin_.pinName_", 1526288919, "Base.String", 1416, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("blurSharpness_pin_.name_", 1507549570, "Base.String", 1432, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("blurSharpness_pin_.connections_", 2168318032, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1448, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("blurSharpness_pin_.pinValueType_", 3715125643, "Base.String", 1480, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enableBlurSharpnessProfile_pin_.pinName_", 3379154759, "Base.String", 1504, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enableBlurSharpnessProfile_pin_.name_", 1372130930, "Base.String", 1520, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enableBlurSharpnessProfile_pin_.connections_", 2787294432, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1536, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("enableBlurSharpnessProfile_pin_.pinValueType_", 1209000827, "Base.String", 1568, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("blurSharpnessProfileForegroundSharpnessScale_pin_.pinName_", 4252726122, "Base.String", 1592, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("blurSharpnessProfileForegroundSharpnessScale_pin_.name_", 218765557, "Base.String", 1608, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("blurSharpnessProfileForegroundSharpnessScale_pin_.connections_", 3188360301, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1624, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("blurSharpnessProfileForegroundSharpnessScale_pin_.pinValueType_", 261635452, "Base.String", 1656, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("blurSharpnessProfileBackgroundViewDepth_pin_.pinName_", 839583534, "Base.String", 1680, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("blurSharpnessProfileBackgroundViewDepth_pin_.name_", 4046780841, "Base.String", 1696, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("blurSharpnessProfileBackgroundViewDepth_pin_.connections_", 2276938521, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1712, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("blurSharpnessProfileBackgroundViewDepth_pin_.pinValueType_", 101943200, "Base.String", 1744, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("blurSharpnessProfileForegroundViewDepth_pin_.pinName_", 2338894613, "Base.String", 1768, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("blurSharpnessProfileForegroundViewDepth_pin_.name_", 3281733776, "Base.String", 1784, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("blurSharpnessProfileForegroundViewDepth_pin_.connections_", 2754894174, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1800, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("blurSharpnessProfileForegroundViewDepth_pin_.pinValueType_", 1730584981, "Base.String", 1832, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
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