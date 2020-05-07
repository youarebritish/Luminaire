using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Item
{
    public partial class SaveMagicBottleStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id;
		public int amount;
		public bool new_flag;
		public bool get_flag;
		public bool original;
		public int equipment;
		public int equipment_weapon_bank_number;
		public uint name;
		public uint help;
		public int element;
		public uint magic;
		public int power;
		public uint effect;
		public int effect_level;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveMagicBottleStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Item.SaveMagicBottleStruct", 0, Black.Save.Item.SaveMagicBottleStruct.ObjectType, null, properties, 0, 48);
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

            fieldProperties = new PropertyContainer("Black.Save.Item.SaveMagicBottleStruct", null, 30528138, -1863939665);
            
			
			
			return fieldProperties;
        }

		
    }
}