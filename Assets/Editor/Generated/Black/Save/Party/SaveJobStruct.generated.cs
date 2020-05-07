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
            return fieldProperties;
        }

		
    }
}