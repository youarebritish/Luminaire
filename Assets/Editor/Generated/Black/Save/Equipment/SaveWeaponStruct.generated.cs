using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Equipment
{
    public partial class SaveWeaponStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id;
		public bool reserve_flag;
		public bool exist;
		public bool new_flag;
		public int equipment;
		public int equipment_weapon_bank_number;
		public uint name_id;
		public int type;
		public int rank;
		public int strength;
		public int vitality;
		public int critical;
		public int recover_mp;
		public int slot;
		public Black.Save.Ability.SaveAbilityEquipmentStruct ability;
		public Black.Save.Ability.SaveAbilityEquipmentStruct resident_ability;
		public int status_adjust;
		public int remodel_fail_count;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveWeaponStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Equipment.SaveWeaponStruct", 0, Black.Save.Equipment.SaveWeaponStruct.ObjectType, null, properties, 0, 152);
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

            fieldProperties = new PropertyContainer("Black.Save.Equipment.SaveWeaponStruct", null, -743336271, -1839223059);
            return fieldProperties;
        }

		
    }
}