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
            return fieldProperties;
        }

		
    }
}