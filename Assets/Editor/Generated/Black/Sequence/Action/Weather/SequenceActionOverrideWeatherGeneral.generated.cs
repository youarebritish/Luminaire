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
            
			fieldProperties.AddProperty(new Property("inStart_", 3384800707, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inEnd_", 745478220, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("transitionTime_", 897948532, "float", 368, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("transitionTimeEnd_", 4134954301, "float", 372, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("weatherParameterComponents_", 2249715571, "SQEX.Ebony.Std.DynamicArray< Black.Sequence.Action.Weather.WeatherParameterComponent* >", 376, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("exposureParameterComponents_", 1099372364, "SQEX.Ebony.Std.DynamicArray< Black.Sequence.Action.Weather.ExposureParameterComponent* >", 392, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("postEffectParameterComponents_", 168693074, "SQEX.Ebony.Std.DynamicArray< Black.Sequence.Action.Weather.PostEffectParameterComponent* >", 408, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("cameraLightParameterComponents_", 3675590370, "SQEX.Ebony.Std.DynamicArray< Black.Sequence.Action.Weather.CameraLightParameterComponent* >", 424, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 440, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}