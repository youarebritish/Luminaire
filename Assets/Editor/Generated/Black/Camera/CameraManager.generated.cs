using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Camera
{
    public partial class CameraManager
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CameraManager();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Camera.CameraManager", 0, Black.Camera.CameraManager.ObjectType, null, properties, 0, 4176);
        }
		
        public  ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected  PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Camera.CameraManager", null, -772205967, 1037830273);
            return fieldProperties;
        }

		
    }
}