using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Weather
{
    public partial class SequenceActionTimeOfDay : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public float timeOfDay_;
		public float axisTilt_;
		public float axisAzimuth_;
		public float moonAxisTilt_;
		public float moonAxisAzimuth_;
		public float moonCenterOfRotationHeightOffset_;
		public UnityEngine.Color mainLightMoonColor_;
		public UnityEngine.Color mainLightSunColor_;
		public float moonLightScale_;
		public float sunLightScale_;
		public float moonLightAnisotropyForCloud_;
		public float sunLightAnisotropyForCloud_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin timeOfDay_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin axisTilt_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin axisAzimuth_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin mainLightDirection_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin mainLightColor_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin mainLightColorWithScale_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin sunAzimuth_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin sunElevation_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin moonAzimuth_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin moonElevation_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin mainLightAzimuth_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin mainLightElevation_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin mainLightAnisotropyForCloud_pin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeOfDay();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Weather.SequenceActionTimeOfDay", 0, Black.Sequence.Action.Weather.SequenceActionTimeOfDay.ObjectType, null, properties, 0, 1680);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Weather.SequenceActionTimeOfDay", base.GetFieldProperties(), 1371863222, -1288463538);
            return fieldProperties;
        }

		
    }
}