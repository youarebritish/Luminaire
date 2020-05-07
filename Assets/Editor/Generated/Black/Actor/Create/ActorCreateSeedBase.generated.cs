using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Create
{
    public partial class ActorCreateSeedBase : SQEX.Luminous.Core.Object.Object
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorCreateSeedBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Create.ActorCreateSeedBase", 0, Black.Actor.Create.ActorCreateSeedBase.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.Actor.Create.ActorCreateSeedBase", base.GetFieldProperties(), -1148237819, 415723544);
            
			
			
			
			
			return fieldProperties;
        }

		
    }
}