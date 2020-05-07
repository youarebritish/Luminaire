using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.RoutePoint.RouteAction
{
    public partial class RouteRequestRemoteEventEntity : Black.Entity.RoutePoint.RouteAction.RouteActionEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint eventId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new RouteRequestRemoteEventEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.RoutePoint.RouteAction.RouteRequestRemoteEventEntity", 0, Black.Entity.RoutePoint.RouteAction.RouteRequestRemoteEventEntity.ObjectType, null, properties, 0, 320);
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

            fieldProperties = new PropertyContainer("Black.Entity.RoutePoint.RouteAction.RouteRequestRemoteEventEntity", base.GetFieldProperties(), -1368158737, 216356177);
            return fieldProperties;
        }

		
    }
}