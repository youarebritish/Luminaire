using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Summon
{
    public partial class SaveSummonStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int summon_amount;
		public short year;
		public sbyte month;
		public sbyte day;
		public sbyte hour;
		public sbyte minute;
		public Black.Save.Summon.SaveSummonDataStruct summon;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveSummonStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Summon.SaveSummonStruct", 0, Black.Save.Summon.SaveSummonStruct.ObjectType, null, properties, 0, 5004);
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

            fieldProperties = new PropertyContainer("Black.Save.Summon.SaveSummonStruct", null, -1607095546, 1589964428);
            
			
			
			fieldProperties.AddProperty(new Property("summon_amount", 4211785611, "int32_t", 0, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("year", 2927578396, "uint16_t", 4, 2, 1, Property.PrimitiveType.Int16, 0, (char)0));
			fieldProperties.AddProperty(new Property("month", 3598321157, "uint8_t", 6, 1, 1, Property.PrimitiveType.Int8, 0, (char)0));
			fieldProperties.AddProperty(new Property("day", 3830391293, "uint8_t", 7, 1, 1, Property.PrimitiveType.Int8, 0, (char)0));
			fieldProperties.AddProperty(new Property("hour", 3053661199, "uint8_t", 8, 1, 1, Property.PrimitiveType.Int8, 0, (char)0));
			fieldProperties.AddProperty(new Property("minute", 954666857, "uint8_t", 9, 1, 1, Property.PrimitiveType.Int8, 0, (char)0));
			fieldProperties.AddProperty(new Property("summon", 13211034, "Black.Save.Summon.SaveSummonDataStruct", 12, 4992, 32, Property.PrimitiveType.ClassField, 0, (char)8));
			
			
			return fieldProperties;
        }

		
    }
}