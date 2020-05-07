using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.TimedQuest
{
    public partial class SaveTimedQuestTitleStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint titleId;
		public int additionalParam1;
		public int additionalParam2;
		public int flag;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveTimedQuestTitleStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.TimedQuest.SaveTimedQuestTitleStruct", 0, Black.Save.TimedQuest.SaveTimedQuestTitleStruct.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.Save.TimedQuest.SaveTimedQuestTitleStruct", null, 397842070, 121823900);
            return fieldProperties;
        }

		
    }
}