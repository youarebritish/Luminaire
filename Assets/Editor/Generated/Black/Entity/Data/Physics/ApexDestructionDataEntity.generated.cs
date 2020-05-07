using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.Physics
{
    public partial class ApexDestructionDataEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint destructionId_;
		public string sourcePath_;
		public float density_;
		public float damageInverseScaling_;
		public bool buildNavMesh_;
		public uint vfx1LeafId_;
		public bool sound1Enabled_;
		public int sound1Id_;
		public float sound1Volume_;
		public uint vfxOrigin1LeafId_;
		public int vfxOrigin1Count_;
		public uint vfx2LeafId_;
		public bool sound2Enabled_;
		public int sound2Id_;
		public float sound2Volume_;
		public uint vfxOrigin2LeafId_;
		public int vfxOrigin2Count_;
		public uint vfx3LeafId_;
		public bool sound3Enabled_;
		public int sound3Id_;
		public float sound3Volume_;
		public uint vfxOrigin3LeafId_;
		public int vfxOrigin3Count_;
		public uint vfxCLeafId_;
		public bool soundCEnabled_;
		public int soundCId_;
		public float soundCVolume_;
		public float contactEventThreshold_;
		public float contactEventPlayCountMax_;
		public float contactEventCountMax_;
		public string materialApexName0_;
		public string materialMigName0_;
		public string materialApexName1_;
		public string materialMigName1_;
		public string materialApexName2_;
		public string materialMigName2_;
		public string materialApexName3_;
		public string materialMigName3_;
		public string materialApexName4_;
		public string materialMigName4_;
		public string materialApexName5_;
		public string materialMigName5_;
		public string materialApexName6_;
		public string materialMigName6_;
		public string materialApexName7_;
		public string materialMigName7_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ApexDestructionDataEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Physics.ApexDestructionDataEntity", 0, Black.Entity.Data.Physics.ApexDestructionDataEntity.ObjectType, null, properties, 0, 472);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.Physics.ApexDestructionDataEntity", base.GetFieldProperties(), 1908653875, 1645597304);
            
			
			
			return fieldProperties;
        }

		
    }
}