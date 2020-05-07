using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Camera
{
    public partial class Camera : Black.Actor.ActorCamera
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new Camera();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Camera.Camera", 0, Black.Camera.Camera.ObjectType, null, properties, 0, 14432);
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

            fieldProperties = new PropertyContainer("Black.Camera.Camera", base.GetFieldProperties(), -473790496, -1059185246);
            return fieldProperties;
        }

		
    }
}