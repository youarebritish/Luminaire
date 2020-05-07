using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Item
{
    public partial class SaveItemStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.Save.Item.SaveItemDataStruct battle_item;
		public Black.Save.Item.SaveItemDataStruct event_item;
		public Black.Save.Item.SaveItemDataStruct food_item;
		public Black.Save.Item.SaveItemDataStruct treasure_item;
		public Black.Save.Item.SaveItemDataStruct car_item;
		public Black.Save.Item.SaveItemDataStruct leisure_item;
		public Black.Save.Item.SaveItemDataStruct reinforcement_item;
		public Black.Save.Item.SaveItemDataStruct trunk_item;
		public int magic_bottle_amount;
		public Black.Save.Item.SaveMagicBottleStruct magic_bottle;
		public Black.Save.Item.SaveMagicBottleStruct magic_bottle_available;
		public Black.Save.Item.SaveRingStruct ring;
		public Black.Save.Item.SaveMagicRecipeListStruct magic_recipe_list;
		public Black.Save.Item.SaveItemInformationStruct information_battle_item;
		public int information_battle_item_amount;
		public Black.Save.Item.SaveItemInformationStruct information_event_item;
		public int information_event_item_amount;
		public Black.Save.Item.SaveItemInformationStruct information_food_item;
		public int information_food_item_amount;
		public Black.Save.Item.SaveItemInformationStruct information_treasure_item;
		public int information_treasure_item_amount;
		public Black.Save.Item.SaveItemInformationStruct information_car_item;
		public int information_car_item_amount;
		public Black.Save.Item.SaveItemInformationStruct information_leisure_item;
		public int information_leisure_item_amount;
		public Black.Save.Item.SaveItemInformationStruct information_reinforcement_item;
		public int information_reinforcement_item_amount;
		public Black.Save.Item.SaveItemInformationStruct information_magic_bottle;
		public int information_magic_bottle_amount;
		public Black.Save.Item.SaveItemInformationStruct information_magic_bottle_available;
		public int information_magic_bottle_available_amount;
		public Black.Save.Item.SaveItemInformationStruct information_ring;
		public int information_ring_amount;
		public Black.Save.Item.SaveItemInformationStruct information_weapon;
		public int information_weapon_amount;
		public Black.Save.Item.SaveItemInformationStruct information_phantom_sword;
		public int information_phantom_sword_amount;
		public Black.Save.Item.SaveItemInformationStruct information_accessory;
		public int information_accessory_amount;
		public Black.Save.Item.SaveItemInformationStruct information_cloth;
		public int information_cloth_amount;
		public Black.Save.Item.SaveItemInformationStruct information_job_command;
		public int information_job_command_amount;
		public Black.Save.Item.SaveItemInformationStruct information_recipe;
		public int information_recipe_amount;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveItemStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Item.SaveItemStruct", 0, Black.Save.Item.SaveItemStruct.ObjectType, null, properties, 0, 84100);
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

            fieldProperties = new PropertyContainer("Black.Save.Item.SaveItemStruct", null, -1859753550, 830935564);
            
			
			
			return fieldProperties;
        }

		
    }
}