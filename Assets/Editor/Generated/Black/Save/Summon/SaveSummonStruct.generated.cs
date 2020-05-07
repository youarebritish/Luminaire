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
            return fieldProperties;
        }

		
    }
}