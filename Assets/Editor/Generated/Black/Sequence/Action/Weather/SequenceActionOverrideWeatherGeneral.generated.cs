using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Weather
{
    public partial class SequenceActionOverrideWeatherGeneral : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inStart_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inEnd_;
		public float transitionTime_;
		public float transitionTimeEnd_;
		public IList<Black.Sequence.Action.Weather.WeatherParameterComponent> weatherParameterComponents_;
		public IList<Black.Sequence.Action.Weather.ExposureParameterComponent> exposureParameterComponents_;
		public IList<Black.Sequence.Action.Weather.PostEffectParameterComponent> postEffectParameterComponents_;
		public IList<Black.Sequence.Action.Weather.CameraLightParameterComponent> cameraLightParameterComponents_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionOverrideWeatherGeneral();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Weather.SequenceActionOverrideWeatherGeneral", 0, Black.Sequence.Action.Weather.SequenceActionOverrideWeatherGeneral.ObjectType, null, properties, 0, 544);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Weather.SequenceActionOverrideWeatherGeneral", base.GetFieldProperties(), -837106037, -1122405066);
            
			
			
			return fieldProperties;
        }

		
    }
}