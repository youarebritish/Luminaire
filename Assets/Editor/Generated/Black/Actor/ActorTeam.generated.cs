using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor
{
    public partial class ActorTeam : Black.Actor.ActorControl
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorTeam();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.ActorTeam", 0, Black.Actor.ActorTeam.ObjectType, null, properties, 60, 7440);
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

            fieldProperties = new PropertyContainer("Black.Actor.ActorTeam", base.GetFieldProperties(), -1741040378, 693168780);
            return fieldProperties;
        }

		
    }
}