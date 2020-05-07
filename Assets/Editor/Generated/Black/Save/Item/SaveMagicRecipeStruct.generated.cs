using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Item
{
    public partial class SaveMagicRecipeStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool favorite;
		public bool disable;
		public sbyte disable_level;
		public bool disable_delete;
		public uint magic_bottle_id;
		public int magic_bottle_amount;
		public int element;
		public int power;
		public uint effect;
		public int effect_level;
		public Black.Save.Item.SaveMagicRecipeItemStruct item;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveMagicRecipeStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Item.SaveMagicRecipeStruct", 0, Black.Save.Item.SaveMagicRecipeStruct.ObjectType, null, properties, 0, 76);
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

            fieldProperties = new PropertyContainer("Black.Save.Item.SaveMagicRecipeStruct", null, 1819852741, -155607518);
            return fieldProperties;
        }

		
    }
}