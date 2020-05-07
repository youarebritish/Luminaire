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
            
			
			
			return fieldProperties;
        }

		
    }
}