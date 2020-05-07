using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Shape
{
    public partial class OceanPatchEntity : Black.Entity.StaticModelEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool useNonuniformScale_;
		public UnityEngine.Vector4 nonuniformScale_;
		public bool excludeWater_;
		public bool swimmable_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new OceanPatchEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Shape.OceanPatchEntity", 0, Black.Entity.Shape.OceanPatchEntity.ObjectType, null, properties, 0, 480);
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

            fieldProperties = new PropertyContainer("Black.Entity.Shape.OceanPatchEntity", base.GetFieldProperties(), -697080834, -2059229619);
            return fieldProperties;
        }

		
    }
}