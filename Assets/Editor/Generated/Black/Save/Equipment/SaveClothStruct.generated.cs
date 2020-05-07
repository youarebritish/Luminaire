using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Equipment
{
    public partial class SaveClothStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id;
		public uint type;
		public int equipment;
		public int equipment_cloth_bank_number;
		public uint name_id;
		public bool exist;
		public bool new_flag;
		public bool jacket_off;
		public bool cap_on;
		public int occlusion_set;
		public int strength;
		public int vitality;
		public int critical;
		public int recover_mp;
		public Black.Save.Ability.SaveAbilityEquipmentStruct ability;
		public int status_adjust;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveClothStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Equipment.SaveClothStruct", 0, Black.Save.Equipment.SaveClothStruct.ObjectType, null, properties, 0, 136);
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

            fieldProperties = new PropertyContainer("Black.Save.Equipment.SaveClothStruct", null, 147862299, -367713645);
            
			
			
			return fieldProperties;
        }

		
    }
}