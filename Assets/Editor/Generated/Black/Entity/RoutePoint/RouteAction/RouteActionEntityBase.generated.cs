using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.RoutePoint.RouteAction
{
    public partial class RouteActionEntityBase : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new RouteActionEntityBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.RoutePoint.RouteAction.RouteActionEntityBase", 0, Black.Entity.RoutePoint.RouteAction.RouteActionEntityBase.ObjectType, null, properties, 0, 304);
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

            fieldProperties = new PropertyContainer("Black.Entity.RoutePoint.RouteAction.RouteActionEntityBase", base.GetFieldProperties(), -1329121131, 507253744);
            return fieldProperties;
        }

		
    }
}