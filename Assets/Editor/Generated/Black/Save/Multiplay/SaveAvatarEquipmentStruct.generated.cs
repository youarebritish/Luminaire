using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Multiplay
{
    public partial class SaveAvatarEquipmentStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.Save.Equipment.SaveWeaponEquipmentStruct weapon;
		public Black.Save.Equipment.SaveWeaponEquipmentStruct accessory;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveAvatarEquipmentStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Multiplay.SaveAvatarEquipmentStruct", 0, Black.Save.Multiplay.SaveAvatarEquipmentStruct.ObjectType, null, properties, 0, 112);
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

            fieldProperties = new PropertyContainer("Black.Save.Multiplay.SaveAvatarEquipmentStruct", null, 608778241, 395342048);
            
			fieldProperties.AddProperty(new Property("weapon", 1865621569, "Black.Save.Equipment.SaveWeaponEquipmentStruct", 0, 64, 4, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("accessory", 1164796377, "Black.Save.Equipment.SaveWeaponEquipmentStruct", 64, 48, 3, Property.PrimitiveType.ClassField, 0, (char)8));
			
			
			return fieldProperties;
        }

		
    }
}