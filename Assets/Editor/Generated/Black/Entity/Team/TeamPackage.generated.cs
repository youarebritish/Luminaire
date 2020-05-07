using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Team
{
    public partial class TeamPackage : Black.Entity.Actor.ActorPackageBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TeamPackage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Team.TeamPackage", 0, Black.Entity.Team.TeamPackage.ObjectType, null, properties, 0, 624);
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

            fieldProperties = new PropertyContainer("Black.Entity.Team.TeamPackage", base.GetFieldProperties(), 2048862112, 886629852);
            return fieldProperties;
        }

		
    }
}