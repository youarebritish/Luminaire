using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Quest
{
    public partial class SaveQuestDataStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int saveVersion;
		public int gameInformationCount;
		public IList<Black.Save.Quest.SaveQuestGameInformationStruct> gameInformationList;
		public IList<uint> acceptQuestIdList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveQuestDataStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Quest.SaveQuestDataStruct", 0, Black.Save.Quest.SaveQuestDataStruct.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.Save.Quest.SaveQuestDataStruct", null, -131684063, -1259688754);
            return fieldProperties;
        }

		
    }
}