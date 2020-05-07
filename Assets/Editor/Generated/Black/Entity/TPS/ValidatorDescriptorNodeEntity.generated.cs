using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.TPS
{
    public partial class ValidatorDescriptorNodeEntity : SQEX.Ebony.Framework.Entity.EntityGroup
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ValidatorDescriptorNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.TPS.ValidatorDescriptorNodeEntity", 0, Black.Entity.TPS.ValidatorDescriptorNodeEntity.ObjectType, null, properties, 0, 208);
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

            fieldProperties = new PropertyContainer("Black.Entity.TPS.ValidatorDescriptorNodeEntity", base.GetFieldProperties(), -981519553, 492803345);
            return fieldProperties;
        }

		
    }
}