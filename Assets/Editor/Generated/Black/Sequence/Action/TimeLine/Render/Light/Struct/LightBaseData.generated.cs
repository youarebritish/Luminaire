using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Render.Light.Struct
{
    public partial class LightBaseData : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enabled_;
		public bool diffuseOnly_;
		public bool smoothFalloff_;
		public UnityEngine.Color color_;
		public float intensity_;
		public float intensityEV_;
		public float radius_;
		public float range_;
		public bool shadowEnabled_;
		public int shadowResolution_;
		public float shadowZNear_;
		public float shadowZBias_;
		public float shadowSlopeBias_;
		public float shadowPower_;
		public float shadowPowerHair_;
		public float saoTerm_;
		public bool chrOnlyShadow_;
		public bool shadowWarpEnabled_;
		public bool volLightEnabled_;
		public float volLightIntensity_;
		public float volLightDistantIntensity_;
		public float volLightZOffset_;
		public bool lpvEnabled_;
		public bool vsglEnabled_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LightBaseData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Render.Light.Struct.LightBaseData", 0, Black.Sequence.Action.TimeLine.Render.Light.Struct.LightBaseData.ObjectType, null, properties, 0, 112);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Render.Light.Struct.LightBaseData", base.GetFieldProperties(), -1869542781, -1078376669);
            return fieldProperties;
        }

		
    }
}