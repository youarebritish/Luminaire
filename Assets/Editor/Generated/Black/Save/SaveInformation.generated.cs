using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save
{
    public partial class SaveInformation
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int SaveType;
		public string AreaFilePath;
		public uint PlayerRestartPointID;
		public SQEX.Luminous.Math.DoubleVector4 PlayerWorldPos;
		public UnityEngine.Vector4 PlayerRotation;
		public uint ActiveQuestFixID;
		public int SlotNo;
		public int tm_sec;
		public int tm_min;
		public int tm_hour;
		public int tm_mday;
		public int tm_mon;
		public int tm_year;
		public int tm_wday;
		public int tm_yday;
		public int tm_isdst;
		public int PlayerLevel;
		public int ChapterNo;
		public int AutoSaveType;
		public uint CampPlaceFixID;
		public long PlayTime;
		public bool IsClear;
		public bool IsNewPlus;
		public bool IsClearGOTY;
		public int Reserved0;
		public int Reserved1;
		public int Reserved2;
		public int Reserved3;
		public int ScreenShotWidth;
		public int ScreenShotHeight;
		public object ScreenShotBinary;
		public int NoxScore;
		public int NoxGameMode;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveInformation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.SaveInformation", 0, Black.Save.SaveInformation.ObjectType, null, properties, 0, 304);
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

            fieldProperties = new PropertyContainer("Black.Save.SaveInformation", null, 1449703829, 577117785);
            
			
			
			return fieldProperties;
        }

		
    }
}