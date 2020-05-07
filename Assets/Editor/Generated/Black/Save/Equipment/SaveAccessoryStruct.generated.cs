using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Equipment
{
    public partial class SaveAccessoryStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id;
		public uint type;
		public int equipment;
		public int equipment_accessory_bank_number;
		public uint name_id;
		public bool exist;
		public bool new_flag;
		public int strength;
		public int vitality;
		public int critical;
		public int recover_mp;
		public Black.Save.Ability.SaveAbilityEquipmentStruct ability;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveAccessoryStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Equipment.SaveAccessoryStruct", 0, Black.Save.Equipment.SaveAccessoryStruct.ObjectType, null, properties, 0, 56);
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

            fieldProperties = new PropertyContainer("Black.Save.Equipment.SaveAccessoryStruct", null, 875203302, 696823898);
            
			
			
			return fieldProperties;
        }

		
    }
}