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
            
			
			
			fieldProperties.AddProperty(new Property("version_", 2901812440, "uint32_t", 0, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("isNowCurrent_", 1349301765, "bool", 4, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isReturnCaem_", 4138090386, "bool", 5, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCanReturn_", 1721751472, "bool", 6, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("memoryQuestData", 919345968, "Black.Save.MemoryQuest.SaveMemoryQuestDataStruct", 16, 384, 4, Property.PrimitiveType.ClassField, 0, (char)8));
			
			
			return fieldProperties;
        }

		
    }
}