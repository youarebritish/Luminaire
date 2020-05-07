using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sound
{
    public partial class Bgm
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new Bgm();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sound.Bgm", 0, Black.Sound.Bgm.ObjectType, null, properties, 0, 1);
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

            fieldProperties = new PropertyContainer("Black.Sound.Bgm", null, 1007061168, -528153608);
            
			
			
			return fieldProperties;
        }

		
    }
}