using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Luminous.InputDevice
{
    public partial class PadData
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int PushMap;
		public float ButtonValue;
		public float Stick;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PadData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Luminous.InputDevice.PadData", 0, SQEX.Luminous.InputDevice.PadData.ObjectType, null, properties, 0, 116);
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

            fieldProperties = new PropertyContainer("SQEX.Luminous.InputDevice.PadData", null, -551833698, -692203151);
            
			
			
			return fieldProperties;
        }

		
    }
}