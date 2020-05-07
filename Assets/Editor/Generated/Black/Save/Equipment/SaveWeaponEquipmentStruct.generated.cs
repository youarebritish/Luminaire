using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Equipment
{
    public partial class SaveWeaponEquipmentStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id;
		public int type;
		public int category;
		public int bank_number;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveWeaponEquipmentStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Equipment.SaveWeaponEquipmentStruct", 0, Black.Save.Equipment.SaveWeaponEquipmentStruct.ObjectType, null, properties, 0, 16);
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

            fieldProperties = new PropertyContainer("Black.Save.Equipment.SaveWeaponEquipmentStruct", null, 443426668, 257993848);
            
			
			
			return fieldProperties;
        }

		
    }
}