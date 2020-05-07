using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Render
{
    public partial class SpotLightEntity : Black.Entity.Render.LightEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float coneAngle_;
		public float penumbraAngle_;
		public float torchIntensity_;
		public float torchFalloff_;
		public float torchNoiseFrequency_;
		public float torchNoiseVariance_;
		public float volLightSpotFadeStart_;
		public float volLightSpotFadeFinish_;
		public float volLightSpotAA_;
		public bool shadowSharingEnabled_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SpotLightEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Render.SpotLightEntity", 0, Black.Entity.Render.SpotLightEntity.ObjectType, null, properties, 0, 880);
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

            fieldProperties = new PropertyContainer("Black.Entity.Render.SpotLightEntity", base.GetFieldProperties(), -1821147364, -99869089);
            
			fieldProperties.AddProperty(new Property("coneAngle_", 588901954, "float", 832, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("penumbraAngle_", 2459240153, "float", 836, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("torchIntensity_", 2204807115, "float", 840, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("torchFalloff_", 1306520098, "float", 844, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("torchNoiseFrequency_", 453149298, "float", 848, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("torchNoiseVariance_", 4038779579, "float", 852, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("volLightSpotFadeStart_", 3202454673, "float", 856, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("volLightSpotFadeFinish_", 2481710936, "float", 860, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("volLightSpotAA_", 3745866721, "float", 864, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowSharingEnabled_", 1187381353, "bool", 868, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}