using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.RoutePoint
{
    public partial class RoutePoint : Black.Actor.Node.ActorNodePoint
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new RoutePoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.RoutePoint.RoutePoint", 0, Black.AI.RoutePoint.RoutePoint.ObjectType, null, properties, 0, 1072);
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

            fieldProperties = new PropertyContainer("Black.AI.RoutePoint.RoutePoint", base.GetFieldProperties(), 1622111573, -774833011);
            
			
			
			return fieldProperties;
        }

		
    }
}