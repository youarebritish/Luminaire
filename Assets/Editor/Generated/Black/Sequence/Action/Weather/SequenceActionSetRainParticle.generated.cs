using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Weather
{
    public partial class SequenceActionSetRainParticle : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool enabled_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enabled_pin_;
		public bool enableWeather_;
		public bool dofEnabled_;
		public UnityEngine.Vector4 ambientColor_;
		public float depthMapRadius_;
		public bool rainEnabled_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainEnabled_pin_;
		public bool splashEnabled_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin splashEnabled_pin_;
		public float rainEmitRate_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainEmitRate_pin_;
		public float rainEmitRadius_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainEmitRadius_pin_;
		public float rainEmitHeight_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainEmitHeight_pin_;
		public float rainEmitSpeed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainEmitSpeed_pin_;
		public float rainEmitSpeedRandom_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainEmitSpeedRandom_pin_;
		public float rainEmitSpread_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainEmitSpread_pin_;
		public float rainLifespan_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainLifespan_pin_;
		public float rainGravity_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainGravity_pin_;
		public UnityEngine.Vector4 rainWindDirection_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainWindDirection_pin_;
		public float rainWindSpeed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainWindSpeed_pin_;
		public float globalWindScale_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin globalWindScale_pin_;
		public float rainSizeNear_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainSizeNear_pin_;
		public float rainSizeFar_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainSizeFar_pin_;
		public float rainSizeRandom_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainSizeRandom_pin_;
		public float rainStretchScale_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainStretchScale_pin_;
		public UnityEngine.Vector4 rainColorGain_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainColorGain_pin_;
		public UnityEngine.Vector4 rainEmissive_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainEmissive_pin_;
		public float splashEmitRate_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin splashEmitRate_pin_;
		public float splashEmitRadius_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin splashEmitRadius_pin_;
		public UnityEngine.Vector4 splashBirthScale_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin splashBirthScale_pin_;
		public UnityEngine.Vector4 splashDeathScale_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin splashDeathScale_pin_;
		public UnityEngine.Vector4 splashColorGain_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin splashColorGain_pin_;
		public UnityEngine.Vector4 splashEmissive_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin splashEmissive_pin_;
		public float blendInTime_;
		public float blendOutTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetRainParticle();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Weather.SequenceActionSetRainParticle", 0, Black.Sequence.Action.Weather.SequenceActionSetRainParticle.ObjectType, null, properties, 0, 3008);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Weather.SequenceActionSetRainParticle", base.GetFieldProperties(), -1550555019, 1455511672);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enabled_", 1722022099, "bool", 368, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("enabled_pin_", 3058841247, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 376, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableWeather_", 1384777099, "bool", 464, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("dofEnabled_", 3787647060, "bool", 465, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientColor_", 1965402543, "SQEX.Luminous.Math.VectorA", 480, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("depthMapRadius_", 1020642063, "float", 496, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEnabled_", 617554293, "bool", 500, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEnabled_pin_", 2832330177, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 504, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashEnabled_", 2766504612, "bool", 592, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashEnabled_pin_", 871690180, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 600, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmitRate_", 2962418847, "float", 688, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmitRate_pin_", 1763016171, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 696, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmitRadius_", 3581722915, "float", 784, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmitRadius_pin_", 3501027439, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 792, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmitHeight_", 2650479252, "float", 880, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmitHeight_pin_", 1580683060, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 888, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmitSpeed_", 3778395748, "float", 976, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmitSpeed_pin_", 818018180, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 984, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmitSpeedRandom_", 839388369, "float", 1072, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmitSpeedRandom_pin_", 4111211789, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1080, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmitSpread_", 3416784616, "float", 1168, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmitSpread_pin_", 385179624, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1176, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainLifespan_", 661299246, "float", 1264, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainLifespan_pin_", 1156533934, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1272, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainGravity_", 938635068, "float", 1360, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainGravity_pin_", 2312393100, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1368, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainWindDirection_", 3954469551, "SQEX.Luminous.Math.VectorA", 1456, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainWindDirection_pin_", 301775739, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1472, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainWindSpeed_", 1419610701, "float", 1560, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainWindSpeed_pin_", 2819240617, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1568, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("globalWindScale_", 1269670579, "float", 1656, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("globalWindScale_pin_", 1575729983, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1664, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainSizeNear_", 1247283001, "float", 1752, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainSizeNear_pin_", 2565057413, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1760, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainSizeFar_", 3636517904, "float", 1848, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainSizeFar_pin_", 1249877504, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1856, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainSizeRandom_", 4014427334, "float", 1944, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainSizeRandom_pin_", 3820542294, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1952, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainStretchScale_", 2608817207, "float", 2040, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainStretchScale_pin_", 999253971, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2048, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainColorGain_", 3925428830, "SQEX.Luminous.Math.VectorA", 2144, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainColorGain_pin_", 3710844446, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2160, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmissive_", 1059121077, "SQEX.Luminous.Math.VectorA", 2256, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmissive_pin_", 2739210241, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2272, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashEmitRate_", 3348433156, "float", 2360, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashEmitRate_pin_", 294235492, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2368, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashEmitRadius_", 2759563680, "float", 2456, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashEmitRadius_pin_", 2198464912, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2464, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashBirthScale_", 1469133772, "SQEX.Luminous.Math.VectorA", 2560, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashBirthScale_pin_", 2778509404, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2576, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashDeathScale_", 82969667, "SQEX.Luminous.Math.VectorA", 2672, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashDeathScale_pin_", 2535546319, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2688, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashColorGain_", 3739973847, "SQEX.Luminous.Math.VectorA", 2784, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashColorGain_pin_", 2499081523, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2800, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashEmissive_", 1428037666, "SQEX.Luminous.Math.VectorA", 2896, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashEmissive_pin_", 2074440850, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2912, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("blendInTime_", 3541416507, "float", 3000, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blendOutTime_", 284564038, "float", 3004, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}