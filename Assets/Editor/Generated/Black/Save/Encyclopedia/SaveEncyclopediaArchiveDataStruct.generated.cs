using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Encyclopedia
{
    public partial class SaveEncyclopediaArchiveDataStruct
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

            var dummy = new SaveEncyclopediaArchiveDataStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Encyclopedia.SaveEncyclopediaArchiveDataStruct", 0, Black.Save.Encyclopedia.SaveEncyclopediaArchiveDataStruct.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.Save.Encyclopedia.SaveEncyclopediaArchiveDataStruct", null, 1334094828, 1128659172);
            return fieldProperties;
        }

		
    }
}