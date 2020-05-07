using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.RoutePoint
{
    public partial class RouteEntity : SQEX.Ebony.Framework.Entity.EntityGroup
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint routeId_;
		public bool bLoop_;
		public int routeMoveType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new RouteEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.RoutePoint.RouteEntity", 0, Black.Entity.RoutePoint.RouteEntity.ObjectType, null, properties, 0, 272);
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

            fieldProperties = new PropertyContainer("Black.Entity.RoutePoint.RouteEntity", base.GetFieldProperties(), -335218778, 804024380);
            return fieldProperties;
        }

		
    }
}