using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor
{
    public partial class ActorTeamNifl : Black.Actor.ActorTeam
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorTeamNifl();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.ActorTeamNifl", 0, Black.Actor.ActorTeamNifl.ObjectType, null, properties, 60, 7552);
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

            fieldProperties = new PropertyContainer("Black.Actor.ActorTeamNifl", base.GetFieldProperties(), 1482678320, -1996900316);
            return fieldProperties;
        }

		
    }
}