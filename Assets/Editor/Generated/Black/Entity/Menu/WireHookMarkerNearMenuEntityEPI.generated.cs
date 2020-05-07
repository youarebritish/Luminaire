using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class WireHookMarkerNearMenuEntityEPI : Black.Entity.Menu.MarkerEntityBaseEPI
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new WireHookMarkerNearMenuEntityEPI();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.WireHookMarkerNearMenuEntityEPI", 0, Black.Entity.Menu.WireHookMarkerNearMenuEntityEPI.ObjectType, null, properties, 0, 528);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.WireHookMarkerNearMenuEntityEPI", base.GetFieldProperties(), -975121513, 1673648918);
            
			
			
			return fieldProperties;
        }

		
    }
}