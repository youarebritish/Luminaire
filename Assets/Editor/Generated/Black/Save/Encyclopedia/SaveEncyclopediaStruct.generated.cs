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
            
			fieldProperties.AddProperty(new Property("enemy", 1776971179, "Black.Save.Encyclopedia.SaveEncyclopediaEnemyDataStruct", 0, 11988, 999, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("character", 2335876880, "Black.Save.Encyclopedia.SaveEncyclopediaCharacterDataStruct", 11988, 512, 64, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("archive", 2566783941, "Black.Save.Encyclopedia.SaveEncyclopediaArchiveDataStruct", 12500, 1024, 128, Property.PrimitiveType.ClassField, 0, (char)8));
			
			
			return fieldProperties;
        }

		
    }
}