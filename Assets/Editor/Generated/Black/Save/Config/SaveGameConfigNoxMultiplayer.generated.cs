using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Config
{
    public partial class SaveGameConfigNoxMultiplayer
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int useCharacter;
		public int avatar_useNo;
		public Black.Save.Config.SaveMultiplayerName avatar_name;
		public bool avatar_used;
		public Black.Save.Multiplay.SaveAvatarEquipmentStruct avatar_equipment;
		public int story_index;
		public Black.Save.Config.SaveMultiplayerColorHistory color_history;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveGameConfigNoxMultiplayer();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Config.SaveGameConfigNoxMultiplayer", 0, Black.Save.Config.SaveGameConfigNoxMultiplayer.ObjectType, null, properties, 0, 3672);
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

            fieldProperties = new PropertyContainer("Black.Save.Config.SaveGameConfigNoxMultiplayer", null, -1227007735, 922351310);
            
			
			
			fieldProperties.AddProperty(new Property("useCharacter", 1505888219, "int32_t", 0, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("avatar_useNo", 2042865127, "int32_t", 4, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("avatar_name", 638266234, "Black.Save.Config.SaveMultiplayerName", 8, 704, 8, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("avatar_used", 3276475012, "bool", 712, 8, 8, Property.PrimitiveType.Bool, 0, (char)8));
			fieldProperties.AddProperty(new Property("avatar_equipment", 2091420779, "Black.Save.Multiplay.SaveAvatarEquipmentStruct", 720, 896, 8, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("story_index", 537424093, "int32_t", 1616, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("color_history", 2913188639, "Black.Save.Config.SaveMultiplayerColorHistory", 1620, 2048, 256, Property.PrimitiveType.ClassField, 0, (char)8));
			
			
			return fieldProperties;
        }

		
    }
}