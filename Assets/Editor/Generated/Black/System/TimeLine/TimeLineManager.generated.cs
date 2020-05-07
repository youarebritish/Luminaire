using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine
{
    public partial class TimeLineManager
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TimeLineManager();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TimeLineManager", 0, Black.System.TimeLine.TimeLineManager.ObjectType, null, properties, 0, 64);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TimeLineManager", null, 1563634383, 368507401);
            return fieldProperties;
        }

		
    }
}