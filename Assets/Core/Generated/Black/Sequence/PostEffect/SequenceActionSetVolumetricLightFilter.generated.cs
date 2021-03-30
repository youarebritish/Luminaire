//----------------------
// <auto-generated>
// This file was automatically generated. Any changes to it will be lost if and when the file is regenerated.
// </auto-generated>
//----------------------
#pragma warning disable

using System;
using SQEX.Luminous.Core.Object;
using System.Collections.Generic;
using CodeDom = System.CodeDom;

namespace Black.Sequence.PostEffect
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class SequenceActionSetVolumetricLightFilter : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_= new SQEX.Ebony.Framework.Node.GraphTriggerInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_= new SQEX.Ebony.Framework.Node.GraphTriggerOutputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableInputPin pinEnable_= new SQEX.Ebony.Framework.Node.GraphVariableInputPin();
		public bool enabled_;
		public bool enableWeather_;
		public float thresholdDepth_;
		public int blurPassCount_;
		public float sinCycleSpeed_;
		public float decay_;
		public float decaySinRatio_;
		public float exposure_;
		public float exposureSinRatio_;
		public UnityEngine.Color sunCenterColor_;
		public UnityEngine.Color sunEdgeColor_;
		public float sunArea_;
		public float sunAreaSinRatio_;
		public float sunLimitLength_;
		public float sunPositionX_;
		public float sunPositionY_;
		public float sunPositionZ_;
		public float alpha_;
		public float cloudMaskFactor_;
		public bool useSunDirection_;
		public bool useSunColor_;
		public float rotationRadianMax_;
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableInputPin thresholdDepth_pin_= new SQEX.Ebony.Framework.Node.GraphVariableInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableInputPin blurPassCount_pin_= new SQEX.Ebony.Framework.Node.GraphVariableInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableInputPin sinCycleSpeed_pin_= new SQEX.Ebony.Framework.Node.GraphVariableInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableInputPin decay_pin_= new SQEX.Ebony.Framework.Node.GraphVariableInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableInputPin decaySinRatio_pin_= new SQEX.Ebony.Framework.Node.GraphVariableInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableInputPin exposure_pin_= new SQEX.Ebony.Framework.Node.GraphVariableInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableInputPin exposureSinRatio_pin_= new SQEX.Ebony.Framework.Node.GraphVariableInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunCenterColor_pin_= new SQEX.Ebony.Framework.Node.GraphVariableInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunEdgeColor_pin_= new SQEX.Ebony.Framework.Node.GraphVariableInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunArea_pin_= new SQEX.Ebony.Framework.Node.GraphVariableInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunAreaSinRatio_pin_= new SQEX.Ebony.Framework.Node.GraphVariableInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunLimitLength_pin_= new SQEX.Ebony.Framework.Node.GraphVariableInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunPositionX_pin_= new SQEX.Ebony.Framework.Node.GraphVariableInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunPositionY_pin_= new SQEX.Ebony.Framework.Node.GraphVariableInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunPositionZ_pin_= new SQEX.Ebony.Framework.Node.GraphVariableInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableInputPin alpha_pin_= new SQEX.Ebony.Framework.Node.GraphVariableInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableInputPin cloudMaskFactor_pin_= new SQEX.Ebony.Framework.Node.GraphVariableInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableInputPin useSunDirection_pin_= new SQEX.Ebony.Framework.Node.GraphVariableInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableInputPin useSunColor_pin_= new SQEX.Ebony.Framework.Node.GraphVariableInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableInputPin rotationRadianMax_pin_= new SQEX.Ebony.Framework.Node.GraphVariableInputPin();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetVolumetricLightFilter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.PostEffect.SequenceActionSetVolumetricLightFilter", 0, Black.Sequence.PostEffect.SequenceActionSetVolumetricLightFilter.ObjectType, Construct, properties, 0, 2336);
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

            fieldProperties = new PropertyContainer("Black.Sequence.PostEffect.SequenceActionSetVolumetricLightFilter", base.GetFieldProperties(), -1523929755, -1838073837);
            
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
			fieldProperties.AddIndirectlyProperty(new Property("pinEnable_.pinName_", 1068892139, "Base.String", 376, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinEnable_.name_", 2792882534, "Base.String", 392, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinEnable_.connections_", 3580311580, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 408, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pinEnable_.pinValueType_", 2034234303, "Base.String", 440, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("thresholdDepth_pin_.pinName_", 596357185, "Base.String", 576, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("thresholdDepth_pin_.name_", 689509564, "Base.String", 592, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("thresholdDepth_pin_.connections_", 3884234018, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 608, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("thresholdDepth_pin_.pinValueType_", 302659345, "Base.String", 640, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("blurPassCount_pin_.pinName_", 4148037816, "Base.String", 664, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("blurPassCount_pin_.name_", 4038923283, "Base.String", 680, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("blurPassCount_pin_.connections_", 1140402427, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 696, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("blurPassCount_pin_.pinValueType_", 1967382598, "Base.String", 728, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sinCycleSpeed_pin_.pinName_", 1771153100, "Base.String", 752, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sinCycleSpeed_pin_.name_", 2512352119, "Base.String", 768, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sinCycleSpeed_pin_.connections_", 3518156887, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 784, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("sinCycleSpeed_pin_.pinValueType_", 2251958778, "Base.String", 816, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("decay_pin_.pinName_", 37792481, "Base.String", 840, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("decay_pin_.name_", 1604610204, "Base.String", 856, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("decay_pin_.connections_", 2157835650, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 872, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("decay_pin_.pinValueType_", 767602417, "Base.String", 904, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("decaySinRatio_pin_.pinName_", 2573583788, "Base.String", 928, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("decaySinRatio_pin_.name_", 809550615, "Base.String", 944, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("decaySinRatio_pin_.connections_", 2296070903, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 960, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("decaySinRatio_pin_.pinValueType_", 2281520410, "Base.String", 992, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("exposure_pin_.pinName_", 326175696, "Base.String", 1016, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("exposure_pin_.name_", 3710809915, "Base.String", 1032, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("exposure_pin_.connections_", 3189788115, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1048, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("exposure_pin_.pinValueType_", 1639005678, "Base.String", 1080, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("exposureSinRatio_pin_.pinName_", 2965688229, "Base.String", 1104, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("exposureSinRatio_pin_.name_", 3922804384, "Base.String", 1120, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("exposureSinRatio_pin_.connections_", 1681497806, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1136, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("exposureSinRatio_pin_.pinValueType_", 868658533, "Base.String", 1168, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunCenterColor_pin_.pinName_", 3801378279, "Base.String", 1192, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunCenterColor_pin_.name_", 1350467794, "Base.String", 1208, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunCenterColor_pin_.connections_", 3099220032, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1224, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("sunCenterColor_pin_.pinValueType_", 3531703259, "Base.String", 1256, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunEdgeColor_pin_.pinName_", 1931946351, "Base.String", 1280, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunEdgeColor_pin_.name_", 1904800522, "Base.String", 1296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunEdgeColor_pin_.connections_", 2490423560, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1312, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("sunEdgeColor_pin_.pinValueType_", 1052485139, "Base.String", 1344, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunArea_pin_.pinName_", 181668456, "Base.String", 1368, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunArea_pin_.name_", 2800855043, "Base.String", 1384, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunArea_pin_.connections_", 304582923, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1400, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("sunArea_pin_.pinValueType_", 1350405046, "Base.String", 1432, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunAreaSinRatio_pin_.pinName_", 284589373, "Base.String", 1456, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunAreaSinRatio_pin_.name_", 945655880, "Base.String", 1472, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunAreaSinRatio_pin_.connections_", 268171142, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1488, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("sunAreaSinRatio_pin_.pinValueType_", 2137555085, "Base.String", 1520, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunLimitLength_pin_.pinName_", 584989300, "Base.String", 1544, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunLimitLength_pin_.name_", 1206109327, "Base.String", 1560, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunLimitLength_pin_.connections_", 3046319135, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1576, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("sunLimitLength_pin_.pinValueType_", 2642631058, "Base.String", 1608, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunPositionX_pin_.pinName_", 3197672798, "Base.String", 1632, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunPositionX_pin_.name_", 587418393, "Base.String", 1648, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunPositionX_pin_.connections_", 2604177257, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1664, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("sunPositionX_pin_.pinValueType_", 3701448400, "Base.String", 1696, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunPositionY_pin_.pinName_", 1528646321, "Base.String", 1720, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunPositionY_pin_.name_", 3526314668, "Base.String", 1736, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunPositionY_pin_.connections_", 1750737202, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1752, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("sunPositionY_pin_.pinValueType_", 2854255489, "Base.String", 1784, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunPositionZ_pin_.pinName_", 94440620, "Base.String", 1808, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunPositionZ_pin_.name_", 2900310039, "Base.String", 1824, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunPositionZ_pin_.connections_", 2202270199, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1840, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("sunPositionZ_pin_.pinValueType_", 3134542362, "Base.String", 1872, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("alpha_pin_.pinName_", 3407649411, "Base.String", 1896, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("alpha_pin_.name_", 2434844462, "Base.String", 1912, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("alpha_pin_.connections_", 513823348, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1928, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("alpha_pin_.pinValueType_", 1029055527, "Base.String", 1960, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cloudMaskFactor_pin_.pinName_", 3276618325, "Base.String", 1984, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cloudMaskFactor_pin_.name_", 2095084240, "Base.String", 2000, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cloudMaskFactor_pin_.connections_", 2934571934, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2016, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("cloudMaskFactor_pin_.pinValueType_", 3875286229, "Base.String", 2048, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useSunDirection_pin_.pinName_", 580946271, "Base.String", 2072, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useSunDirection_pin_.name_", 809763770, "Base.String", 2088, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useSunDirection_pin_.connections_", 3005762264, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2104, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("useSunDirection_pin_.pinValueType_", 178794115, "Base.String", 2136, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useSunColor_pin_.pinName_", 1332793809, "Base.String", 2160, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useSunColor_pin_.name_", 3233317772, "Base.String", 2176, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useSunColor_pin_.connections_", 973786642, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2192, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("useSunColor_pin_.pinValueType_", 2090613473, "Base.String", 2224, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotationRadianMax_pin_.pinName_", 157759604, "Base.String", 2248, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotationRadianMax_pin_.name_", 2439118479, "Base.String", 2264, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotationRadianMax_pin_.connections_", 1663959583, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2280, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rotationRadianMax_pin_.pinValueType_", 3897480082, "Base.String", 2312, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinEnable_", 448653220, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 368, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enabled_", 1722022099, "bool", 456, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableWeather_", 1384777099, "bool", 457, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("thresholdDepth_", 1857114566, "float", 460, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blurPassCount_", 691674581, "int", 464, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("sinCycleSpeed_", 3747085617, "float", 468, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("decay_", 1299677734, "float", 472, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("decaySinRatio_", 661989329, "float", 476, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("exposure_", 2450507277, "float", 480, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("exposureSinRatio_", 2729652178, "float", 484, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunCenterColor_", 986703592, "Luminous.RenderInterface.Color", 496, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunEdgeColor_", 833998064, "Luminous.RenderInterface.Color", 512, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunArea_", 1050932197, "float", 528, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunAreaSinRatio_", 3373354602, "float", 532, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunLimitLength_", 1245120857, "float", 536, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunPositionX_", 1736414911, "float", 540, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunPositionY_", 662897558, "float", 544, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunPositionZ_", 662353105, "float", 548, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("alpha_", 914233116, "float", 552, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("cloudMaskFactor_", 2821799778, "float", 556, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("useSunDirection_", 2059306496, "bool", 560, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("useSunColor_", 279642870, "bool", 561, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotationRadianMax_", 2007298905, "float", 564, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("thresholdDepth_pin_", 1291726422, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 568, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("blurPassCount_pin_", 1801998049, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 656, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sinCycleSpeed_pin_", 962403117, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 744, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("decay_pin_", 221754486, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 832, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("decaySinRatio_pin_", 3203393549, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 920, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("exposure_pin_", 1071402857, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1008, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("exposureSinRatio_pin_", 340627394, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1096, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunCenterColor_pin_", 716425192, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1184, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunEdgeColor_pin_", 2041030304, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1272, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunArea_pin_", 1138674801, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1360, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunAreaSinRatio_pin_", 3154169578, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1448, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunLimitLength_pin_", 1997588837, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1536, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunPositionX_pin_", 3301931211, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1624, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunPositionY_pin_", 2940327334, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1712, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunPositionZ_pin_", 1493255437, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1800, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("alpha_pin_", 1866792748, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1888, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cloudMaskFactor_pin_", 190743762, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1976, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("useSunDirection_pin_", 461532464, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2064, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("useSunColor_pin_", 2578188742, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2152, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotationRadianMax_pin_", 3220394853, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2240, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceActionSetVolumetricLightFilter();
        }
		
    }
}