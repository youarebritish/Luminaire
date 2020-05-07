using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Main.GameMode
{
    public partial class FieldMode
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new FieldMode();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Main.GameMode.FieldMode", 0, Black.Main.GameMode.FieldMode.ObjectType, null, properties, 2, 1360);
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

            fieldProperties = new PropertyContainer("Black.Main.GameMode.FieldMode", null, -1920176986, 809589677);
            
			
			
			
			
			return fieldProperties;
        }

		
    }
}