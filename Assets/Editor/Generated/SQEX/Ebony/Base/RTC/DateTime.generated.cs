using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Base.RTC
{
    public partial class DateTime
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int year;
		public int month;
		public int day;
		public int weekDay;
		public int hour;
		public int minute;
		public int second;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new DateTime();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Base.RTC.DateTime", 0, SQEX.Ebony.Base.RTC.DateTime.ObjectType, null, properties, 0, 28);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Base.RTC.DateTime", null, -813880701, -1071513679);
            
			
			
			return fieldProperties;
        }

		
    }
}