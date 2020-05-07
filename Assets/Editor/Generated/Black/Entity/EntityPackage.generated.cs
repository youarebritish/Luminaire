using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity
{
    public partial class EntityPackage : SQEX.Ebony.Framework.Entity.EntityPackage
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new EntityPackage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.EntityPackage", 0, Black.Entity.EntityPackage.ObjectType, null, properties, 0, 608);
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

            fieldProperties = new PropertyContainer("Black.Entity.EntityPackage", base.GetFieldProperties(), -1194656680, 1792541562);
            return fieldProperties;
        }

		
    }
}