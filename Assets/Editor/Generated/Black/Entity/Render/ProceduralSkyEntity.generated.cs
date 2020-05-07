using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Render
{
    public partial class ProceduralSkyEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enableSky_;
		public bool enableObjects_;
		public bool enableCloud_;
		public bool enableSkyCubemap_;
		public bool enableFilteredSpecularCubemap_;
		public bool enableBillboardStar_;
		public float starTilingFrequency0_;
		public float starTilingFrequency1_;
		public float starTilingFrequency2_;
		public float starTilingFrequency3_;
		public float starTwinkleFrequency0_;
		public float starTwinkleFrequency1_;
		public bool enableMilkyWay_;
		public float milkywayFrequency_;
		public float milkywayOffset_;
		public float milkyWayPhi0_;
		public float milkyWayPhi1_;
		public float milkywayRotX_;
		public int milkywayResolution_;
		public bool enableMoon_;
		public string moonPath_;
		public string tilingStarPath_;
		public string tilingStarPath2_;
		public string starMaskPath_;
		public string milkyWayPath_;
		public string starTwinklePath_;
		public string highCloudPath_;
		public string billboardStarPath_;
		public string hc0Path_;
		public string hc1Path_;
		public float shadowStretch_;
		public float starBrightnessThreshold_;
		public float hcHeight_;
		public float hcHeightOffset_;
		public float hcOpacity_;
		public float hcRotSpeed_;
		public float hcHorOffset_;
		public float hcTiling_;
		public float hcBlend_;
		public float hcBlendSpeed_;
		public float hcAniso_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ProceduralSkyEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Render.ProceduralSkyEntity", 0, Black.Entity.Render.ProceduralSkyEntity.ObjectType, null, properties, 0, 688);
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

            fieldProperties = new PropertyContainer("Black.Entity.Render.ProceduralSkyEntity", base.GetFieldProperties(), 503171251, -1505870931);
            return fieldProperties;
        }

		
    }
}