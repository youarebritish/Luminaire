using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.MemoryQuest
{
    public partial class SaveMemoryQuestStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int version_;
		public bool isNowCurrent_;
		public bool isReturnCaem_;
		public bool isCanReturn_;
		public Black.Save.MemoryQuest.SaveMemoryQuestDataStruct memoryQuestData;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveMemoryQuestStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.MemoryQuest.SaveMemoryQuestStruct", 0, Black.Save.MemoryQuest.SaveMemoryQuestStruct.ObjectType, null, properties, 0, 400);
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

            fieldProperties = new PropertyContainer("Black.Save.MemoryQuest.SaveMemoryQuestStruct", null, -592928316, -461476628);
            return fieldProperties;
        }

		
    }
}