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
            
			fieldProperties.AddProperty(new Property("useNonuniformScale_", 4431550, "bool", 440, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("nonuniformScale_", 3202151619, "Luminous.Math.VectorA", 448, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("excludeWater_", 1818039297, "bool", 464, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("swimmable_", 2158095701, "bool", 465, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}