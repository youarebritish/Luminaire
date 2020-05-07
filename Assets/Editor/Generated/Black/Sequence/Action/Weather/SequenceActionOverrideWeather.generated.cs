using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Weather
{
    public partial class SequenceActionOverrideWeather : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inRestore_;
		public bool enabled_;
		public float weatherTransitionTime_;
		public int overrideType_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin overrideWeatherID_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin overrideExposureID_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin overridePostEffectID_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin overrideCameraLightID_pin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionOverrideWeather();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Weather.SequenceActionOverrideWeather", 0, Black.Sequence.Action.Weather.SequenceActionOverrideWeather.ObjectType, null, properties, 0, 736);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Weather.SequenceActionOverrideWeather", base.GetFieldProperties(), -782169455, -425643765);
            
			
			
			return fieldProperties;
        }

		
    }
}