using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Encyclopedia
{
    public partial class SaveEncyclopediaStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.Save.Encyclopedia.SaveEncyclopediaEnemyDataStruct enemy;
		public Black.Save.Encyclopedia.SaveEncyclopediaCharacterDataStruct character;
		public Black.Save.Encyclopedia.SaveEncyclopediaArchiveDataStruct archive;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveEncyclopediaStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Encyclopedia.SaveEncyclopediaStruct", 0, Black.Save.Encyclopedia.SaveEncyclopediaStruct.ObjectType, null, properties, 0, 13524);
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

            fieldProperties = new PropertyContainer("Black.Save.Encyclopedia.SaveEncyclopediaStruct", null, -1405097798, 304503494);
            
			
			
			return fieldProperties;
        }

		
    }
}