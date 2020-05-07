using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class MakeRoutePointEntity : Black.Entity.Node.PointNodeEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool createRoutePoint_;
		public int routeType_;
		public float radiusX_;
		public float radiusY_;
		public float radiusZ_;
		public int routeDivid_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new MakeRoutePointEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.MakeRoutePointEntity", 0, Black.Entity.Node.MakeRoutePointEntity.ObjectType, null, properties, 0, 320);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.MakeRoutePointEntity", base.GetFieldProperties(), 1253353605, -675174185);
            
			
			
			return fieldProperties;
        }

		
    }
}