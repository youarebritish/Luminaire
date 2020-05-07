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
            
			
			
			fieldProperties.AddProperty(new Property("id", 926444256, "Black.Save.SAVE_SUMMON", 0, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("name", 2369371622, "char", 4, 128, 128, Property.PrimitiveType.Int8, 0, (char)8));
			fieldProperties.AddProperty(new Property("name_id", 3355607158, "SQEX.Ebony.Std.Fixid", 132, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("name_overwrite_flag", 3862968031, "bool", 136, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("exist", 456138012, "bool", 137, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve1", 532037902, "uint32_t", 140, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve2", 515260283, "uint32_t", 144, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve3", 498482664, "uint32_t", 148, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve4", 615925997, "uint32_t", 152, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}