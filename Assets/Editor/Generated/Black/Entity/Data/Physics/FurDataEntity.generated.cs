using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.Physics
{
    public partial class FurDataEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int furType_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> furCurvePaths_;
		public string maskTexturePath_;
		public string furMaterialPath_;
		public string baseMeshName_;
		public int furResolution_;
		public int masterStrandPerTriangle_;
		public int slaveStrandPerMaster_;
		public bool enableDraw_;
		public float furStiffness_;
		public float furDamping_;
		public bool enableCollision_;
		public float furSegmentLength_;
		public float furMeshWidth_;
		public float tipShrinkage_;
		public UnityEngine.Vector4 tipOffset_;
		public float furSlaveDistScale_;
		public float furFollicleLengthScale_;
		public bool flattenNormal_;
		public float textureSizeX_;
		public float textureSizeY_;
		public float alphaMapRepeat_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new FurDataEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Physics.FurDataEntity", 0, Black.Entity.Data.Physics.FurDataEntity.ObjectType, null, properties, 0, 272);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.Physics.FurDataEntity", base.GetFieldProperties(), -421536977, -70824769);
            
			
			
			return fieldProperties;
        }

		
    }
}