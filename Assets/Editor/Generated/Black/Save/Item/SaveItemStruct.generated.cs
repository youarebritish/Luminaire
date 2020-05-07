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
            
			
			
			fieldProperties.AddProperty(new Property("battle_item", 4137442375, "Black.Save.Item.SaveItemDataStruct", 0, 512, 64, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("event_item", 2162826415, "Black.Save.Item.SaveItemDataStruct", 512, 2048, 256, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("food_item", 2147393465, "Black.Save.Item.SaveItemDataStruct", 2560, 2048, 256, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("treasure_item", 1613009978, "Black.Save.Item.SaveItemDataStruct", 4608, 2048, 256, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("car_item", 3351143281, "Black.Save.Item.SaveItemDataStruct", 6656, 2048, 256, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("leisure_item", 1651241898, "Black.Save.Item.SaveItemDataStruct", 8704, 2048, 256, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("reinforcement_item", 3449395912, "Black.Save.Item.SaveItemDataStruct", 10752, 128, 16, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("trunk_item", 1454879141, "Black.Save.Item.SaveItemDataStruct", 10880, 2048, 256, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("magic_bottle_amount", 3289678162, "int32_t", 12928, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("magic_bottle", 1359358469, "Black.Save.Item.SaveMagicBottleStruct", 12932, 768, 16, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("magic_bottle_available", 3381270693, "Black.Save.Item.SaveMagicBottleStruct", 13700, 25200, 525, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("ring", 4149934955, "Black.Save.Item.SaveRingStruct", 38900, 792, 22, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("magic_recipe_list", 1870428268, "Black.Save.Item.SaveMagicRecipeListStruct", 39692, 6096, 4, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("information_battle_item", 2758263914, "Black.Save.Item.SaveItemInformationStruct", 45788, 1024, 128, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("information_battle_item_amount", 1218561307, "int32_t", 46812, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("information_event_item", 3862776232, "Black.Save.Item.SaveItemInformationStruct", 46816, 2560, 320, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("information_event_item_amount", 153880921, "int32_t", 49376, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("information_food_item", 2198740132, "Black.Save.Item.SaveItemInformationStruct", 49380, 2048, 256, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("information_food_item_amount", 202714253, "int32_t", 51428, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("information_treasure_item", 3505543995, "Black.Save.Item.SaveItemInformationStruct", 51432, 4096, 512, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("information_treasure_item_amount", 1526431040, "int32_t", 55528, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("information_car_item", 2732014766, "Black.Save.Item.SaveItemInformationStruct", 55532, 2048, 256, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("information_car_item_amount", 1436441511, "int32_t", 57580, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("information_leisure_item", 1081592477, "Black.Save.Item.SaveItemInformationStruct", 57584, 2048, 256, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("information_leisure_item_amount", 713153530, "int32_t", 59632, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("information_reinforcement_item", 2121405319, "Black.Save.Item.SaveItemInformationStruct", 59636, 128, 16, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("information_reinforcement_item_amount", 2348509556, "int32_t", 59764, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("information_magic_bottle", 3248079870, "Black.Save.Item.SaveItemInformationStruct", 59768, 128, 16, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("information_magic_bottle_amount", 3294565047, "int32_t", 59896, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("information_magic_bottle_available", 620362986, "Black.Save.Item.SaveItemInformationStruct", 59900, 4200, 525, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("information_magic_bottle_available_amount", 2798463643, "int32_t", 64100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("information_ring", 2026627028, "Black.Save.Item.SaveItemInformationStruct", 64104, 176, 22, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("information_ring_amount", 2530471165, "int32_t", 64280, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("information_weapon", 3863741134, "Black.Save.Item.SaveItemInformationStruct", 64284, 8096, 1012, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("information_weapon_amount", 2796426119, "int32_t", 72380, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("information_phantom_sword", 855016417, "Black.Save.Item.SaveItemInformationStruct", 72384, 208, 26, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("information_phantom_sword_amount", 1783679254, "int32_t", 72592, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("information_accessory", 3060613172, "Black.Save.Item.SaveItemInformationStruct", 72596, 8096, 1012, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("information_accessory_amount", 1371576221, "int32_t", 80692, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("information_cloth", 392943366, "Black.Save.Item.SaveItemInformationStruct", 80696, 832, 104, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("information_cloth_amount", 121726223, "int32_t", 81528, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("information_job_command", 2799736539, "Black.Save.Item.SaveItemInformationStruct", 81532, 512, 64, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("information_job_command_amount", 904709792, "int32_t", 82044, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("information_recipe", 2066268668, "Black.Save.Item.SaveItemInformationStruct", 82048, 2048, 256, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("information_recipe_amount", 3897228181, "int32_t", 84096, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}