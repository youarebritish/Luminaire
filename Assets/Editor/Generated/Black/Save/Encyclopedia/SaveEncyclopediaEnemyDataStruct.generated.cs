using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Encyclopedia
{
    public partial class SaveEncyclopediaEnemyDataStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id;
		public int kill;
		public bool isNew;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveEncyclopediaEnemyDataStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Encyclopedia.SaveEncyclopediaEnemyDataStruct", 0, Black.Save.Encyclopedia.SaveEncyclopediaEnemyDataStruct.ObjectType, null, properties, 0, 12);
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

            fieldProperties = new PropertyContainer("Black.Save.Encyclopedia.SaveEncyclopediaEnemyDataStruct", null, 1030800589, 1408753716);
            
			
			
			return fieldProperties;
        }

		
    }
}