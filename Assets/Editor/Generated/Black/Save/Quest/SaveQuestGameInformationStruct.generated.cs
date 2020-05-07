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
            
			
			
			fieldProperties.AddProperty(new Property("questId", 3161124712, "Black.Save.Quest.SaveQuestGameInformationStruct.Fixid", 0, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("progressHistoryList", 821551226, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Std.Fixid >", 8, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("conditionWork", 4251185987, "QuestSaveInformation.ConditionWork", 24, 32, 4, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("isEnableUpdateUIMark", 565059592, "bool", 56, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}