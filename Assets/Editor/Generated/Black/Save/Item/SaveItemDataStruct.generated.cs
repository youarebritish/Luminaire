using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Item
{
    public partial class SaveItemDataStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id;
		public int amount;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveItemDataStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Item.SaveItemDataStruct", 0, Black.Save.Item.SaveItemDataStruct.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.Save.Item.SaveItemDataStruct", null, 761373400, 1053302904);
            
			
			
			return fieldProperties;
        }

		
    }
}