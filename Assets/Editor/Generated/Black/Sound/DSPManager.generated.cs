using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sound
{
    public partial class DSPManager
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new DSPManager();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sound.DSPManager", 0, Black.Sound.DSPManager.ObjectType, null, properties, 0, 80);
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

            fieldProperties = new PropertyContainer("Black.Sound.DSPManager", null, -2089887614, -1852228760);
            
			
			
			
			
			return fieldProperties;
        }

		
    }
}