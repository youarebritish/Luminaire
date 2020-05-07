using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Party
{
    public partial class SaveJobStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id;
		public int save_bank_number;
		public uint name_id;
		public bool exist;
		public Black.Save.Party.SaveJobPlayerStruct player;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveJobStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Party.SaveJobStruct", 0, Black.Save.Party.SaveJobStruct.ObjectType, null, properties, 0, 92);
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

            fieldProperties = new PropertyContainer("Black.Save.Party.SaveJobStruct", null, -1410522127, 1609453875);
            
			
			
			fieldProperties.AddProperty(new Property("id", 926444256, "SQEX.Ebony.Std.Fixid", 0, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("save_bank_number", 1105146745, "Black.Save.SAVE_PLAYER", 4, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("name_id", 3355607158, "SQEX.Ebony.Std.Fixid", 8, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("exist", 456138012, "bool", 12, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("player", 748274432, "Black.Save.Party.SaveJobPlayerStruct", 16, 76, 19, Property.PrimitiveType.ClassField, 0, (char)8));
			
			
			return fieldProperties;
        }

		
    }
}