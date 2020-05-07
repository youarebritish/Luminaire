using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity
{
    public partial class StaticModelEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string sourcePath_;
		public string sourceHighSpecPath_;
		public float scaling_;
		public bool visible_;
		public bool scriptVisibleOff_;
		public bool lodLevelHold_;
		public float lodScaling_;
		public uint linkAnimId_;
		public bool casterShadow_;
		public bool receiveShadow_;
		public bool ignoreIndoorLightProbes_;
		public bool depthOnly_;
		public bool useMeshCollision_;
		public bool setMeshCollisionOff_;
		public string MeshCollision_;
		public bool useMeshCollisionMovingTile_;
		public bool useMeshCollisionAirMovingTile_;
		public int naviMeshBuildType_;
		public IList<Black.Entity.Material.MaterialParameterColor> materialParamColor_;
		public IList<Black.Entity.Material.MaterialParameterValue1> materialParamValue1_;
		public IList<Black.Entity.Material.MaterialParameterValue4> materialParamValue4_;
		public bool isTerrainBakeEnabled_;
		public bool isFoliageCheckThrough_;
		public bool turfBaseObject_;
		public bool umbraIsBakeTarget_;
		public bool umbraIsBakeTargetEvenIncludesTranslucent_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new StaticModelEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.StaticModelEntity", 0, Black.Entity.StaticModelEntity.ObjectType, null, properties, 0, 416);
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

            fieldProperties = new PropertyContainer("Black.Entity.StaticModelEntity", base.GetFieldProperties(), -1890832539, 1835478383);
            
			
			
			return fieldProperties;
        }

		
    }
}