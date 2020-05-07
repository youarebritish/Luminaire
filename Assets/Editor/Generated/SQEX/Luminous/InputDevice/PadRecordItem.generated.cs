using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Luminous.InputDevice
{
    public partial class PadRecordItem : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int delta_;
		public SQEX.Luminous.InputDevice.PadDataSet dataSet_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PadRecordItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Luminous.InputDevice.PadRecordItem", 0, SQEX.Luminous.InputDevice.PadRecordItem.ObjectType, null, properties, 0, 480);
        }
		
        public override ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected override PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("SQEX.Luminous.InputDevice.PadRecordItem", base.GetFieldProperties(), -1870458987, 459145793);
            
			
			
			return fieldProperties;
        }

		
    }
}