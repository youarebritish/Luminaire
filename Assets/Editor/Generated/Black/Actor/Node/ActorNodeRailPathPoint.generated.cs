using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Node
{
    public partial class ActorNodeRailPathPoint : Black.Actor.Node.ActorNodePoint
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorNodeRailPathPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Node.ActorNodeRailPathPoint", 0, Black.Actor.Node.ActorNodeRailPathPoint.ObjectType, null, properties, 59, 976);
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

            fieldProperties = new PropertyContainer("Black.Actor.Node.ActorNodeRailPathPoint", base.GetFieldProperties(), 848164921, 1124108722);
            return fieldProperties;
        }

		
    }
}