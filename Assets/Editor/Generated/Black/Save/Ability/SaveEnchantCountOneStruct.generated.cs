using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Ability
{
    public partial class SaveEnchantCountOneStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int ability_id;
		public int ability_effect;
		public Black.Save.Ability.SaveAbilityCountOneStruct ability;
		public uint attack_id;
		public int effect;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveEnchantCountOneStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Ability.SaveEnchantCountOneStruct", 0, Black.Save.Ability.SaveEnchantCountOneStruct.ObjectType, null, properties, 0, 20);
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

            fieldProperties = new PropertyContainer("Black.Save.Ability.SaveEnchantCountOneStruct", null, 206926160, -406515321);
            return fieldProperties;
        }

		
    }
}