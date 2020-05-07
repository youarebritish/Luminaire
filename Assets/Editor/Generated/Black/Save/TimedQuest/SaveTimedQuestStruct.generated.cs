using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.TimedQuest
{
    public partial class SaveTimedQuestStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int version;
		public Black.Save.TimedQuest.SaveTimedQuestTitleStruct title;
		public Black.Save.TimedQuest.SaveTimedQuestPointStruct point;
		public Black.Save.TimedQuest.SaveTimedQuestLabelStruct label;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveTimedQuestStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.TimedQuest.SaveTimedQuestStruct", 0, Black.Save.TimedQuest.SaveTimedQuestStruct.ObjectType, null, properties, 0, 10440);
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

            fieldProperties = new PropertyContainer("Black.Save.TimedQuest.SaveTimedQuestStruct", null, -527920294, 1761120603);
            
			
			
			return fieldProperties;
        }

		
    }
}