using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.TPS
{
    public partial class FilterDescriptorNodeEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new FilterDescriptorNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.TPS.FilterDescriptorNodeEntity", 0, Black.Entity.TPS.FilterDescriptorNodeEntity.ObjectType, null, properties, 0, 304);
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

            fieldProperties = new PropertyContainer("Black.Entity.TPS.FilterDescriptorNodeEntity", base.GetFieldProperties(), -1658954863, 1319693311);
            return fieldProperties;
        }

		
    }
}