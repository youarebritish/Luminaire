using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.PostEffect
{
    public partial class SequenceActionSetVolumetricLightFilter : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pinEnable_;
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
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin thresholdDepth_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin blurPassCount_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sinCycleSpeed_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin decay_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin decaySinRatio_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin exposure_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin exposureSinRatio_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunCenterColor_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunEdgeColor_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunArea_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunAreaSinRatio_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunLimitLength_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunPositionX_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunPositionY_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunPositionZ_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin alpha_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cloudMaskFactor_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin useSunDirection_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin useSunColor_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rotationRadianMax_pin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetVolumetricLightFilter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.PostEffect.SequenceActionSetVolumetricLightFilter", 0, Black.Sequence.PostEffect.SequenceActionSetVolumetricLightFilter.ObjectType, null, properties, 0, 2336);
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

		
    }
}