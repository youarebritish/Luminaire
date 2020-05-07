using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class WeaponMenuEntityForIgnis : Black.Entity.Menu.WeaponMenuEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new WeaponMenuEntityForIgnis();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.WeaponMenuEntityForIgnis", 0, Black.Entity.Menu.WeaponMenuEntityForIgnis.ObjectType, null, properties, 0, 784);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.WeaponMenuEntityForIgnis", base.GetFieldProperties(), 1829127094, -1836372883);
            return fieldProperties;
        }

		
    }
}