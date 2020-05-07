using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Config
{
    public partial class SaveGameConfigStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Luminous.GameFramework.Locale.LocaleCategory text_;
		public Luminous.GameFramework.Locale.LocaleCategory voice_;
		public int brightness_;
		public int soundMode_;
		public bool virticalCameraNormal_;
		public bool horizontalCameraNormal_;
		public bool displayText_;
		public bool speakerText_;
		public bool vibrationEnable_;
		public bool firstBoot_;
		public bool newgamePlus_;
		public int masterVolume_;
		public int bgmVolume_;
		public int voiceVolume_;
		public int seVolume_;
		public int cameraSpeed_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveGameConfigStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Config.SaveGameConfigStruct", 0, Black.Save.Config.SaveGameConfigStruct.ObjectType, null, properties, 0, 44);
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

            fieldProperties = new PropertyContainer("Black.Save.Config.SaveGameConfigStruct", null, -967475886, 865735656);
            
			
			
			return fieldProperties;
        }

		
    }
}