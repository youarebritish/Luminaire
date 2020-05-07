using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor
{
    public partial class ActorCamera : Black.Actor.ActorCharacter
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorCamera();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.ActorCamera", 0, Black.Actor.ActorCamera.ObjectType, null, properties, 60, 9200);
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

            fieldProperties = new PropertyContainer("Black.Actor.ActorCamera", base.GetFieldProperties(), 796586449, 1045221963);
            return fieldProperties;
        }

		
    }
}