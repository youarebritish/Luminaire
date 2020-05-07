using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class WeaponMenuEntityForMulti : Black.Entity.Menu.WeaponMenuEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new WeaponMenuEntityForMulti();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.WeaponMenuEntityForMulti", 0, Black.Entity.Menu.WeaponMenuEntityForMulti.ObjectType, null, properties, 0, 720);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.WeaponMenuEntityForMulti", base.GetFieldProperties(), 326897877, -1203859313);
            return fieldProperties;
        }

		
    }
}