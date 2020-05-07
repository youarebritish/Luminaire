using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Ability
{
    public partial class SaveEnchantCountStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.Save.Ability.SaveEnchantCountOneStruct enchant;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveEnchantCountStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Ability.SaveEnchantCountStruct", 0, Black.Save.Ability.SaveEnchantCountStruct.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.Save.Ability.SaveEnchantCountStruct", null, -1600062418, 75496065);
            return fieldProperties;
        }

		
    }
}