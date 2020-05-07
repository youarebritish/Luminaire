using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.RoutePoint.RouteAction
{
    public partial class RouteWaitEntity : Black.Entity.RoutePoint.RouteAction.RouteActionEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float waitTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new RouteWaitEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.RoutePoint.RouteAction.RouteWaitEntity", 0, Black.Entity.RoutePoint.RouteAction.RouteWaitEntity.ObjectType, null, properties, 0, 320);
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

            fieldProperties = new PropertyContainer("Black.Entity.RoutePoint.RouteAction.RouteWaitEntity", base.GetFieldProperties(), 839146358, 53759109);
            
			
			
			return fieldProperties;
        }

		
    }
}