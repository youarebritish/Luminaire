using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Encyclopedia
{
    public partial class SaveEncyclopediaCharacterDataStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id;
		public bool isAddition;
		public bool isNew;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveEncyclopediaCharacterDataStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Encyclopedia.SaveEncyclopediaCharacterDataStruct", 0, Black.Save.Encyclopedia.SaveEncyclopediaCharacterDataStruct.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.Save.Encyclopedia.SaveEncyclopediaCharacterDataStruct", null, 286701721, 538982530);
            
			
			
			return fieldProperties;
        }

		
    }
}