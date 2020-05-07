using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Node
{
    public partial class ActorNodeClimateChangeArea : Black.Actor.Node.ActorNodeTriggerBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorNodeClimateChangeArea();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Node.ActorNodeClimateChangeArea", 0, Black.Actor.Node.ActorNodeClimateChangeArea.ObjectType, null, properties, 59, 1376);
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

            fieldProperties = new PropertyContainer("Black.Actor.Node.ActorNodeClimateChangeArea", base.GetFieldProperties(), 1623906063, -289481725);
            
			
			
			return fieldProperties;
        }

		
    }
}