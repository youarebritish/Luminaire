using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Item
{
    public partial class SaveMagicRecipeListStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int magic_recipe_amount;
		public Black.Save.Item.SaveMagicRecipeStruct magic_recipe;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveMagicRecipeListStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Item.SaveMagicRecipeListStruct", 0, Black.Save.Item.SaveMagicRecipeListStruct.ObjectType, null, properties, 0, 1524);
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

            fieldProperties = new PropertyContainer("Black.Save.Item.SaveMagicRecipeListStruct", null, 944515684, 768846293);
            
			
			
			return fieldProperties;
        }

		
    }
}