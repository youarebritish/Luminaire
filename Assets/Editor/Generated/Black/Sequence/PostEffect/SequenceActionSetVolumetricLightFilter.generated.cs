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
            return fieldProperties;
        }

		
    }
}