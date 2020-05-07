using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Shape
{
    public partial class OceanFlowMapEntity : Black.Entity.StaticModelEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new OceanFlowMapEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Shape.OceanFlowMapEntity", 0, Black.Entity.Shape.OceanFlowMapEntity.ObjectType, null, properties, 0, 448);
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

            fieldProperties = new PropertyContainer("Black.Entity.Shape.OceanFlowMapEntity", base.GetFieldProperties(), 1871898013, 1586447435);
            return fieldProperties;
        }

		
    }
}