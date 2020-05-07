using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.TPS.FilterNodeEntities
{
    public partial class Distance3DTrapezoidFilterNodeEntity : Black.Entity.TPS.FilterNodeEntities.Distance2DTrapezoidFilterNodeEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new Distance3DTrapezoidFilterNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.TPS.FilterNodeEntities.Distance3DTrapezoidFilterNodeEntity", 0, Black.Entity.TPS.FilterNodeEntities.Distance3DTrapezoidFilterNodeEntity.ObjectType, null, properties, 0, 336);
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

            fieldProperties = new PropertyContainer("Black.Entity.TPS.FilterNodeEntities.Distance3DTrapezoidFilterNodeEntity", base.GetFieldProperties(), -40457486, 1645671081);
            
			
			
			return fieldProperties;
        }

		
    }
}