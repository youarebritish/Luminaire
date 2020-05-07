using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class WireHookMarkerFarMenuEntityEPI : Black.Entity.Menu.MarkerEntityBaseEPI
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new WireHookMarkerFarMenuEntityEPI();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.WireHookMarkerFarMenuEntityEPI", 0, Black.Entity.Menu.WireHookMarkerFarMenuEntityEPI.ObjectType, null, properties, 0, 528);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.WireHookMarkerFarMenuEntityEPI", base.GetFieldProperties(), 1440801529, -1266058638);
            return fieldProperties;
        }

		
    }
}