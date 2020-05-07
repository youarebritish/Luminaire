using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.RoutePoint.RouteAction
{
    public partial class RouteSendMessageToBodyEntity : Black.Entity.RoutePoint.RouteAction.RouteActionEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint message_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new RouteSendMessageToBodyEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.RoutePoint.RouteAction.RouteSendMessageToBodyEntity", 0, Black.Entity.RoutePoint.RouteAction.RouteSendMessageToBodyEntity.ObjectType, null, properties, 0, 320);
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

            fieldProperties = new PropertyContainer("Black.Entity.RoutePoint.RouteAction.RouteSendMessageToBodyEntity", base.GetFieldProperties(), 991000237, 927701066);
            return fieldProperties;
        }

		
    }
}