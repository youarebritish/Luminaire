using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Actor
{
    public partial class HeightFieldEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string sourcePath_;
		public string sourcePathHighSpec_;
		public string materialPalettePath_;
		public string heightMapPath_;
		public string heightMapHighSpecPath_;
		public string additionalDisplacementTextureFilePath_;
		public float scaling_;
		public bool visible_;
		public bool forMulti_;
		public int cellX_;
		public int cellZ_;
		public int maxLODBinLevel_;
		public float minAltitude_;
		public float maxAltitude_;
		public bool useMeshCollision_;
		public int lodMeshCollision_;
		public float normalPowerPerMeter_;
		public bool isSea_;
		public string seaHeightMapPath_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new HeightFieldEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Actor.HeightFieldEntity", 0, Black.Entity.Actor.HeightFieldEntity.ObjectType, null, properties, 0, 800);
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

            fieldProperties = new PropertyContainer("Black.Entity.Actor.HeightFieldEntity", base.GetFieldProperties(), -1070235521, -52094853);
            
			
			
			return fieldProperties;
        }

		
    }
}