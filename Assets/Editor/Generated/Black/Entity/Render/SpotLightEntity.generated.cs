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
            return fieldProperties;
        }

		
    }
}