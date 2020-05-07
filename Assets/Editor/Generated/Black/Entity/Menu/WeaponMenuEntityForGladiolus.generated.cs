using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class WeaponMenuEntityForGladiolus : Black.Entity.Menu.WeaponMenuEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new WeaponMenuEntityForGladiolus();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.WeaponMenuEntityForGladiolus", 0, Black.Entity.Menu.WeaponMenuEntityForGladiolus.ObjectType, null, properties, 0, 736);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.WeaponMenuEntityForGladiolus", base.GetFieldProperties(), -331298562, -890220276);
            
			
			
			return fieldProperties;
        }

		
    }
}