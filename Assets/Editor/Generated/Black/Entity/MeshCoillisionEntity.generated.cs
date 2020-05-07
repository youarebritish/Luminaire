using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity
{
    public partial class MeshCoillisionEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enabled_;
		public string sourcePath_;
		public float scaling_;
		public UnityEngine.Vector4 nonUniformScale_;
		public bool useMeshCollisionMovingTile_;
		public int naviMeshBuildType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new MeshCoillisionEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.MeshCoillisionEntity", 0, Black.Entity.MeshCoillisionEntity.ObjectType, null, properties, 0, 336);
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

            fieldProperties = new PropertyContainer("Black.Entity.MeshCoillisionEntity", base.GetFieldProperties(), -1132459727, -260558039);
            return fieldProperties;
        }

		
    }
}