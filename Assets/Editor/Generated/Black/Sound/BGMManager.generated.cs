using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sound
{
    public partial class BGMManager
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BGMManager();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sound.BGMManager", 0, Black.Sound.BGMManager.ObjectType, null, properties, 0, 104);
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

            fieldProperties = new PropertyContainer("Black.Sound.BGMManager", null, -1476134005, -275029465);
            return fieldProperties;
        }

		
    }
}