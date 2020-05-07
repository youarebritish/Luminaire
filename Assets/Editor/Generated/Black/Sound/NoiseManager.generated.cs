using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sound
{
    public partial class NoiseManager
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new NoiseManager();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sound.NoiseManager", 0, Black.Sound.NoiseManager.ObjectType, null, properties, 0, 296);
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

            fieldProperties = new PropertyContainer("Black.Sound.NoiseManager", null, 308007531, -317991199);
            
			
			
			
			
			return fieldProperties;
        }

		
    }
}