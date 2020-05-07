using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.TimedQuest
{
    public partial class SaveTimedQuestPointStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint scheduleId;
		public long acquisition;
		public long consumption;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveTimedQuestPointStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.TimedQuest.SaveTimedQuestPointStruct", 0, Black.Save.TimedQuest.SaveTimedQuestPointStruct.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.Save.TimedQuest.SaveTimedQuestPointStruct", null, 2068533484, -1811781727);
            return fieldProperties;
        }

		
    }
}