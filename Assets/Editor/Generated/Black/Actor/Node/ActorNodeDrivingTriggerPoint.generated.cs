using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Node
{
    public partial class ActorNodeDrivingTriggerPoint : Black.Actor.Node.ActorNodeTrigger
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorNodeDrivingTriggerPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Node.ActorNodeDrivingTriggerPoint", 0, Black.Actor.Node.ActorNodeDrivingTriggerPoint.ObjectType, null, properties, 59, 1328);
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

            fieldProperties = new PropertyContainer("Black.Actor.Node.ActorNodeDrivingTriggerPoint", base.GetFieldProperties(), -1349485686, 535687512);
            
			
			
			return fieldProperties;
        }

		
    }
}