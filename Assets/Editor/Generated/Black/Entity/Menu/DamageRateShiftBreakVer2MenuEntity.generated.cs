using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class DamageRateShiftBreakVer2MenuEntity : Black.Entity.Menu.DamageRateMenuEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new DamageRateShiftBreakVer2MenuEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.DamageRateShiftBreakVer2MenuEntity", 0, Black.Entity.Menu.DamageRateShiftBreakVer2MenuEntity.ObjectType, null, properties, 0, 560);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.DamageRateShiftBreakVer2MenuEntity", base.GetFieldProperties(), -655015706, 2143764765);
            
			
			
			return fieldProperties;
        }

		
    }
}