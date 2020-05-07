using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class NaviMapMenuEntityEPG : Black.Entity.Menu.NaviMapMenuEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new NaviMapMenuEntityEPG();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.NaviMapMenuEntityEPG", 0, Black.Entity.Menu.NaviMapMenuEntityEPG.ObjectType, null, properties, 0, 2304);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.NaviMapMenuEntityEPG", base.GetFieldProperties(), -152763894, 503123005);
            return fieldProperties;
        }

		
    }
}