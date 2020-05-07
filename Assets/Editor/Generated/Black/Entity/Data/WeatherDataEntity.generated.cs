using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data
{
    public partial class WeatherDataEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float weatherTransitionTime_;
		public string skyFilePath_;
		public bool reloadSky_;
		public uint defaultClimateId_;
		public string exposureFilePath_;
		public bool reloadExposure_;
		public short defaultExposureId_;
		public string postEffectFilePath_;
		public bool reloadPostEffect_;
		public short defaultPostEffectId_;
		public string cameraLightFilePath_;
		public bool reloadCameraLight_;
		public short defaultCameraLightId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new WeatherDataEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.WeatherDataEntity", 0, Black.Entity.Data.WeatherDataEntity.ObjectType, null, properties, 0, 176);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.WeatherDataEntity", base.GetFieldProperties(), -1036387836, -442917900);
            
			
			
			return fieldProperties;
        }

		
    }
}