using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Universal
{
    public partial class SaveUniversalStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int version;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveUniversalStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Universal.SaveUniversalStruct", 0, Black.Save.Universal.SaveUniversalStruct.ObjectType, null, properties, 0, 4);
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

            fieldProperties = new PropertyContainer("Black.Save.Universal.SaveUniversalStruct", null, 980172648, -596095321);
            
			
			
			return fieldProperties;
        }

		
    }
}