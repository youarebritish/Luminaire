using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.Corps.Reinforce
{
    public partial class ActorNodeReinforceAppearPoint : Black.Actor.Node.ActorNodePoint
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorNodeReinforceAppearPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.Corps.Reinforce.ActorNodeReinforceAppearPoint", 0, Black.AI.Corps.Reinforce.ActorNodeReinforceAppearPoint.ObjectType, null, properties, 0, 960);
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

            fieldProperties = new PropertyContainer("Black.AI.Corps.Reinforce.ActorNodeReinforceAppearPoint", base.GetFieldProperties(), 100300084, -50421444);
            
			
			
			return fieldProperties;
        }

		
    }
}