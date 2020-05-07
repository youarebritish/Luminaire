using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Luminous.InputDevice
{
    public partial class PadRecord
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<SQEX.Luminous.InputDevice.PadRecordItem> items_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PadRecord();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Luminous.InputDevice.PadRecord", 0, SQEX.Luminous.InputDevice.PadRecord.ObjectType, null, properties, 0, 16);
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

            fieldProperties = new PropertyContainer("SQEX.Luminous.InputDevice.PadRecord", null, -828597274, -106467037);
            return fieldProperties;
        }

		
    }
}