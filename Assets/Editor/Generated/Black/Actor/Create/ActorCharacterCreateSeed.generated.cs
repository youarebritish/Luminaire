using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Create
{
    public partial class ActorCharacterCreateSeed : Black.Actor.Create.ActorCreateSeedBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorCharacterCreateSeed();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Create.ActorCharacterCreateSeed", 0, Black.Actor.Create.ActorCharacterCreateSeed.ObjectType, null, properties, 0, 336);
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

            fieldProperties = new PropertyContainer("Black.Actor.Create.ActorCharacterCreateSeed", base.GetFieldProperties(), 761794273, -493929363);
            
			
			
			return fieldProperties;
        }

		
    }
}