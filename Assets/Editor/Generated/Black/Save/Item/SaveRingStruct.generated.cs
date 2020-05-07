using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Item
{
    public partial class SaveRingStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id;
		public bool exist;
		public bool new_flag;
		public bool get_flag;
		public int equipment;
		public int equipment_weapon_bank_number;
		public uint name;
		public uint help;
		public int element;
		public int element_power_max;
		public uint magic;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveRingStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Item.SaveRingStruct", 0, Black.Save.Item.SaveRingStruct.ObjectType, null, properties, 0, 36);
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

            fieldProperties = new PropertyContainer("Black.Save.Item.SaveRingStruct", null, -936898956, 675455084);
            return fieldProperties;
        }

		
    }
}