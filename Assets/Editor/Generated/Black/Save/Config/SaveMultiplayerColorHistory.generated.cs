using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Config
{
    public partial class SaveMultiplayerColorHistory
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint ItemID;
		public sbyte Index;
		public sbyte R;
		public sbyte G;
		public sbyte B;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveMultiplayerColorHistory();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Config.SaveMultiplayerColorHistory", 0, Black.Save.Config.SaveMultiplayerColorHistory.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.Save.Config.SaveMultiplayerColorHistory", null, -1885755440, -345733712);
            
			fieldProperties.AddProperty(new Property("ItemID", 1006361435, "SQEX.Ebony.Std.Fixid", 0, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("Index", 2932321867, "uint8_t", 4, 1, 1, Property.PrimitiveType.Int8, 0, (char)0));
			fieldProperties.AddProperty(new Property("R", 3607893173, "uint8_t", 5, 1, 1, Property.PrimitiveType.Int8, 0, (char)0));
			fieldProperties.AddProperty(new Property("G", 3255563174, "uint8_t", 6, 1, 1, Property.PrimitiveType.Int8, 0, (char)0));
			fieldProperties.AddProperty(new Property("B", 3339451269, "uint8_t", 7, 1, 1, Property.PrimitiveType.Int8, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}