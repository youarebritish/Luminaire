using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Create
{
    public partial class ActorTeamCreateSeed : Black.Actor.Create.ActorCreateSeedBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorTeamCreateSeed();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Create.ActorTeamCreateSeed", 0, Black.Actor.Create.ActorTeamCreateSeed.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.Actor.Create.ActorTeamCreateSeed", base.GetFieldProperties(), -548011037, 1064305941);
            
			
			
			
			
			return fieldProperties;
        }

		
    }
}