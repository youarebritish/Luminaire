using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Quest
{
    public partial class SaveQuestGameInformationStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint questId;
		public IList<uint> progressHistoryList;
		public Black.Quest.Information.QuestSaveInformation.ConditionWork conditionWork;
		public bool isEnableUpdateUIMark;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveQuestGameInformationStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Quest.SaveQuestGameInformationStruct", 0, Black.Save.Quest.SaveQuestGameInformationStruct.ObjectType, null, properties, 0, 64);
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

            fieldProperties = new PropertyContainer("Black.Save.Quest.SaveQuestGameInformationStruct", null, 1530412544, 512366402);
            
			
			
			return fieldProperties;
        }

		
    }
}