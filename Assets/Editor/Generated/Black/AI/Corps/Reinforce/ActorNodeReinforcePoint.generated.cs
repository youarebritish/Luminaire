using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.Corps.Reinforce
{
    public partial class ActorNodeReinforcePoint : Black.Actor.Node.ActorNodePoint
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorNodeReinforcePoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.Corps.Reinforce.ActorNodeReinforcePoint", 0, Black.AI.Corps.Reinforce.ActorNodeReinforcePoint.ObjectType, null, properties, 0, 992);
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

            fieldProperties = new PropertyContainer("Black.AI.Corps.Reinforce.ActorNodeReinforcePoint", base.GetFieldProperties(), 1713443237, 115409640);
            
			
			
			return fieldProperties;
        }

		
    }
}