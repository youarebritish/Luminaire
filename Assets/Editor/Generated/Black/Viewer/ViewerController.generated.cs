using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Viewer
{
    public partial class ViewerController
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ViewerController();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Viewer.ViewerController", 0, Black.Viewer.ViewerController.ObjectType, null, properties, 21, 1);
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

            fieldProperties = new PropertyContainer("Black.Viewer.ViewerController", null, -1105698993, 1061482596);
            return fieldProperties;
        }

		
    }
}