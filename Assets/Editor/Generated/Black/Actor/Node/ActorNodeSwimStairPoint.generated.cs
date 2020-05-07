using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Node
{
    public partial class ActorNodeSwimStairPoint : Black.Actor.Node.ActorNodePoint
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorNodeSwimStairPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Node.ActorNodeSwimStairPoint", 0, Black.Actor.Node.ActorNodeSwimStairPoint.ObjectType, null, properties, 59, 976);
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

            fieldProperties = new PropertyContainer("Black.Actor.Node.ActorNodeSwimStairPoint", base.GetFieldProperties(), 420016241, 175902194);
            return fieldProperties;
        }

		
    }
}