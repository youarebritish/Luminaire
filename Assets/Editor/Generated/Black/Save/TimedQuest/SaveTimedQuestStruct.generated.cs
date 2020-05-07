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
            
			fieldProperties.AddProperty(new Property("version", 1181855383, "uint32_t", 0, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("title", 2556802313, "Black.Save.TimedQuest.SaveTimedQuestTitleStruct", 4, 6144, 256, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("point", 414084241, "Black.Save.TimedQuest.SaveTimedQuestPointStruct", 6152, 192, 8, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("label", 4137097213, "Black.Save.TimedQuest.SaveTimedQuestLabelStruct", 6344, 4096, 512, Property.PrimitiveType.ClassField, 0, (char)8));
			
			
			return fieldProperties;
        }

		
    }
}