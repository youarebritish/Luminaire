using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Event
{
    public partial class EventPackage : Black.Entity.EntityPackage
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new EventPackage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Event.EventPackage", 0, Black.Entity.Event.EventPackage.ObjectType, null, properties, 0, 608);
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

            fieldProperties = new PropertyContainer("Black.Entity.Event.EventPackage", base.GetFieldProperties(), -1258667656, 1888334421);
            return fieldProperties;
        }

		
    }
}