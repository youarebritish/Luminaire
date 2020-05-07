using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity
{
    public partial class OceanFloatingModelEntity : Black.Entity.StaticModelEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool followOceanSurface_;
		public bool followOceanNormal_;
		public float damping_;
		public IList<Black.Entity.WaterExclusionBoxParameter> waterExclusionBoxParams_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new OceanFloatingModelEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.OceanFloatingModelEntity", 0, Black.Entity.OceanFloatingModelEntity.ObjectType, null, properties, 0, 496);
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

            fieldProperties = new PropertyContainer("Black.Entity.OceanFloatingModelEntity", base.GetFieldProperties(), -2129348248, -834126960);
            
			fieldProperties.AddProperty(new Property("followOceanSurface_", 26947686, "bool", 440, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("followOceanNormal_", 3447629734, "bool", 441, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("damping_", 3302352382, "float", 444, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("waterExclusionBoxParams_", 616124268, "SQEX.Ebony.Std.DynamicArray< Black.Entity.WaterExclusionBoxParameter*, MEMORY_CATEGORY_OCEAN >", 448, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}