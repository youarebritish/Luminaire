using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Render
{
    public partial class LightEntityBase : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enabled_;
		public bool mayaLightDirection_;
		public bool diffuseOnly_;
		public bool smoothFalloff_;
		public int weatherType_;
		public UnityEngine.Color color_;
		public float intensity_;
		public float intensityEV_;
		public float radius_;
		public float specRadius_;
		public float range_;
		public float roughnessModifier_;
		public bool counterExposure_;
		public bool shadowEnabled_;
		public int shadowResolution_;
		public float shadowZNear_;
		public float shadowZBias_;
		public float shadowSlopeBias_;
		public float shadowPower_;
		public float shadowPowerHair_;
		public float saoTerm_;
		public bool chrOnlyShadow_;
		public bool chrAndDBGShadow_;
		public int shadowMode_;
		public bool shadowWarpEnabled_;
		public bool shadowAutoResize_;
		public bool shadowEnableMaxAngle_;
		public float shadowMaxAngle_;
		public int shadowLODOffset_;
		public float shadowCullingMaxObjectSize_;
		public bool useCharacterExclusionMask_;
		public bool excludeNoctis_;
		public bool excludeGladiolus_;
		public bool excludeIgnis_;
		public bool excludePrompto_;
		public bool excludeNoctisChildhood_;
		public bool bakeStaticShadowMap_;
		public string sourceDirectory_;
		public string sourceFileName_;
		public string projectionSourcePath_;
		public float projectionTextureScale_;
		public UnityEngine.Vector4 projectionTextureScroll_;
		public bool caustics_;
		public string iesSourcePath_;
		public string iesData_;
		public bool volLightEnabled_;
		public float volLightIntensity_;
		public float volLightDistantIntensity_;
		public float volLightZOffset_;
		public bool lpvEnabled_;
		public bool vsglEnabled_;
		public bool isEnabledOnOffByTime_;
		public float timeOfDayLightStart_;
		public float timeOfDayLightEnd_;
		public float transitionWorldSecLight_;
		public bool isEnabledLOD_;
		public float onOffDistance_;
		public float transitionDistanceLight_;
		public float transitionLightEV_;
		public bool isShadowEnabledOnOffByDistance_;
		public float shadowOnOffDistance_;
		public float transitionRadiusShadow_;
		public bool renderDebug_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LightEntityBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Render.LightEntityBase", 0, Black.Entity.Render.LightEntityBase.ObjectType, null, properties, 0, 832);
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

            fieldProperties = new PropertyContainer("Black.Entity.Render.LightEntityBase", base.GetFieldProperties(), -1006256753, -1036138698);
            
			
			
			return fieldProperties;
        }

		
    }
}