using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Shape
{
    public partial class OceanDistanceFieldEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 scaling_;
		public bool bakeDistanceField_;
		public string sourceDirectory_;
		public string sourceFileName_;
		public float lengthPerTexel_;
		public float maxShoreDistance_;
		public bool distanceFieldEnabled_;
		public UnityEngine.Vector4 falloffStart_;
		public float intensityScale_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new OceanDistanceFieldEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Shape.OceanDistanceFieldEntity", 0, Black.Entity.Shape.OceanDistanceFieldEntity.ObjectType, null, properties, 0, 416);
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

            fieldProperties = new PropertyContainer("Black.Entity.Shape.OceanDistanceFieldEntity", base.GetFieldProperties(), -1985771429, 557519241);
            
			
			
			return fieldProperties;
        }

		
    }
}