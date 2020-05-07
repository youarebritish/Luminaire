using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Node
{
    public partial class ActorNodeInspirationTrigger : Black.Actor.Node.ActorNodeTrigger
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorNodeInspirationTrigger();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Node.ActorNodeInspirationTrigger", 0, Black.Actor.Node.ActorNodeInspirationTrigger.ObjectType, null, properties, 59, 1328);
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

            fieldProperties = new PropertyContainer("Black.Actor.Node.ActorNodeInspirationTrigger", base.GetFieldProperties(), 2070693106, -695372641);
            
			
			
			return fieldProperties;
        }

		
    }
}