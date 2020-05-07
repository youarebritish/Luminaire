using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class PeriodMobhuntInfoMenuEntity : Black.Entity.Menu.MapMenuEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PeriodMobhuntInfoMenuEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.PeriodMobhuntInfoMenuEntity", 0, Black.Entity.Menu.PeriodMobhuntInfoMenuEntity.ObjectType, null, properties, 0, 1120);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.PeriodMobhuntInfoMenuEntity", base.GetFieldProperties(), -1733175577, -832424264);
            
			
			
			return fieldProperties;
        }

		
    }
}