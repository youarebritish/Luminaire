using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Summon
{
    public partial class SaveSummonDataStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int id;
		public sbyte name;
		public uint name_id;
		public bool name_overwrite_flag;
		public bool exist;
		public int reserve1;
		public int reserve2;
		public int reserve3;
		public int reserve4;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveSummonDataStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Summon.SaveSummonDataStruct", 0, Black.Save.Summon.SaveSummonDataStruct.ObjectType, null, properties, 0, 156);
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

            fieldProperties = new PropertyContainer("Black.Save.Summon.SaveSummonDataStruct", null, 1657258019, -42884446);
            
			
			
			return fieldProperties;
        }

		
    }
}