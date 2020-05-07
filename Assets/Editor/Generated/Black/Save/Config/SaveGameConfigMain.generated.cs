using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Config
{
    public partial class SaveGameConfigMain
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
		public int padButtonIconKind_;
		public int autoSaveSlotNo_;
		public int autoSaveSlotOldNo_;
		public bool rotateNaviMap_;
		public bool displayNaviMap_;
		public bool displayNaviMapRoute_;
		public bool displayKeyHelp_;
		public bool displayHUD_;
		public int cameraLength_;
		public bool isHUDFullscreen_;
		public bool displayHelpMessage_;
		public bool displaySTGauge_;
		public bool is4KMode_;
		public int gameMode_;
		public int gameStyle_;
		public int controllerType_;
		public int reserved0_;
		public int reserved1_;
		public int reserved2_;
		public int reserved3_;
		public bool reserved4_;
		public bool reserved5_;
		public bool reserved6_;
		public bool isHDRMode_;
		public long reservedStats_;
		public bool appContent_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveGameConfigMain();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Config.SaveGameConfigMain", 0, Black.Save.Config.SaveGameConfigMain.ObjectType, null, properties, 0, 368);
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

            fieldProperties = new PropertyContainer("Black.Save.Config.SaveGameConfigMain", null, -1990184729, 1757269977);
            
			
			
			return fieldProperties;
        }

		
    }
}