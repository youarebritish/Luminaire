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
            
			
			
			return fieldProperties;
        }

		
    }
}