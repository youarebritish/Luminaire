using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class SnowmobileCustomMenuEntityEPP : Black.Entity.Menu.SwfEntryEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SnowmobileCustomMenuEntityEPP();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.SnowmobileCustomMenuEntityEPP", 0, Black.Entity.Menu.SnowmobileCustomMenuEntityEPP.ObjectType, null, properties, 0, 512);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.SnowmobileCustomMenuEntityEPP", base.GetFieldProperties(), 2004620779, -887367220);
            return fieldProperties;
        }

		
    }
}