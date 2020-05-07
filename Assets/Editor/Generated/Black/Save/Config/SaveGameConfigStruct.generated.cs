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
            
			
			
			fieldProperties.AddProperty(new Property("text_", 1384997555, "Luminous.GameFramework.Locale.LocaleCategory", 0, 4, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("voice_", 2285793362, "Luminous.GameFramework.Locale.LocaleCategory", 4, 4, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("brightness_", 2567634479, "int", 8, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("soundMode_", 937406328, "int", 12, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("virticalCameraNormal_", 3391388204, "bool", 16, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("horizontalCameraNormal_", 3848184586, "bool", 17, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("displayText_", 132010371, "bool", 18, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("speakerText_", 784285026, "bool", 19, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("vibrationEnable_", 1901477143, "bool", 20, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("firstBoot_", 537906066, "bool", 21, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("newgamePlus_", 3822884768, "bool", 22, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("masterVolume_", 1035454998, "int", 24, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("bgmVolume_", 837035660, "int", 28, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("voiceVolume_", 457371940, "int", 32, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("seVolume_", 412011312, "int", 36, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("cameraSpeed_", 4088304938, "int", 40, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}