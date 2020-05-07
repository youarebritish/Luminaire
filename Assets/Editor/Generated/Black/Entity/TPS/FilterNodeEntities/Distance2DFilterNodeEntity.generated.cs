using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.TPS.FilterNodeEntities
{
    public partial class Distance2DFilterNodeEntity : Black.Entity.TPS.FilterNodeEntities.QueryDistanceFilterNodeEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new Distance2DFilterNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.TPS.FilterNodeEntities.Distance2DFilterNodeEntity", 0, Black.Entity.TPS.FilterNodeEntities.Distance2DFilterNodeEntity.ObjectType, null, properties, 0, 344);
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

            fieldProperties = new PropertyContainer("Black.Entity.TPS.FilterNodeEntities.Distance2DFilterNodeEntity", base.GetFieldProperties(), -627852896, 394865982);
            return fieldProperties;
        }

		
    }
}