using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Player
{
    public partial class SaveDataStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int gameVersion;
		public SQEX.Ebony.Base.Timer.TimeStamp startTime;
		public SQEX.Ebony.Base.Timer.TimeStamp endTime;
		public Black.Save.Player.SavePlayerStruct player;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveDataStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Player.SaveDataStruct", 0, Black.Save.Player.SaveDataStruct.ObjectType, null, properties, 0, 1049440);
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

            fieldProperties = new PropertyContainer("Black.Save.Player.SaveDataStruct", null, 1286902868, 1307448055);
            return fieldProperties;
        }

		
    }
}