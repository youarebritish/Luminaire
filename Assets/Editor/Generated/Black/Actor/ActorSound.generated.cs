using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor
{
    public partial class ActorSound : Black.Actor.ActorPosition
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorSound();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.ActorSound", 0, Black.Actor.ActorSound.ObjectType, null, properties, 59, 832);
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

            fieldProperties = new PropertyContainer("Black.Actor.ActorSound", base.GetFieldProperties(), -462546591, -2145521776);
            return fieldProperties;
        }

		
    }
}