using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Physics
{
    public partial class SequenceActionSetWorldWind : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public float rotation;
		public float tilt;
		public float flap;
		public float totalTime;
		public float randomTime;
		public UnityEngine.Vector4 power;
		public UnityEngine.Vector4 randomPower;
		public UnityEngine.Vector4 offset;
		public UnityEngine.Vector4 randomOffset;
		public UnityEngine.Vector4 phaseDifference;
		public UnityEngine.Vector4 waveLength;
		public float xAxisWaveDifference;
		public float yAxisWaveDifference;
		public float gravityCoefficient;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin gravityCoefficient_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin yAxisWaveDifference_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin xAxisWaveDifference_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin waveLength_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin phaseDifference_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin randomOffset_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin offset_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin randomPower_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin power_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin randomTime_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin totalTime_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin flap_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin tilt_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rotation_pin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetWorldWind();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Physics.SequenceActionSetWorldWind", 0, Black.Sequence.Action.Physics.SequenceActionSetWorldWind.ObjectType, null, properties, 0, 1840);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Physics.SequenceActionSetWorldWind", base.GetFieldProperties(), -641858047, -203421025);
            
			fieldProperties.AddProperty(new Property("enable_", 3925052483, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("disable_", 1760805492, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotation", 564937055, "float", 464, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("tilt", 1614438918, "float", 468, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("flap", 3404381518, "float", 472, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("totalTime", 740397244, "float", 476, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("randomTime", 1364627683, "float", 480, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("power", 4115604294, "Luminous.Math.VectorA", 496, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("randomPower", 3207073875, "Luminous.Math.VectorA", 512, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("offset", 348705738, "Luminous.Math.VectorA", 528, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("randomOffset", 1407811909, "Luminous.Math.VectorA", 544, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("phaseDifference", 3609331499, "Luminous.Math.VectorA", 560, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("waveLength", 2569689624, "Luminous.Math.VectorA", 576, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("xAxisWaveDifference", 3210343980, "float", 592, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("yAxisWaveDifference", 1967616527, "float", 596, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("gravityCoefficient", 4018861554, "float", 600, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("gravityCoefficient_pin_", 1920476083, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 608, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("yAxisWaveDifference_pin_", 3459661216, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 696, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("xAxisWaveDifference_pin_", 223858773, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 784, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("waveLength_pin_", 1533358481, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 872, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("phaseDifference_pin_", 4094585772, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 960, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("randomOffset_pin_", 1637838446, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1048, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("offset_pin_", 2838427803, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1136, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("randomPower_pin_", 2163295236, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1224, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("power_pin_", 1175812023, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1312, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("randomTime_pin_", 644129492, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1400, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("totalTime_pin_", 363173221, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1488, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("flap_pin_", 2949862223, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1576, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("tilt_pin_", 3659090551, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1664, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotation_pin_", 3709733424, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1752, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}