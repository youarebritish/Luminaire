using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Party
{
    public partial class SavePartyMemberStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int save_bank_number;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SavePartyMemberStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Party.SavePartyMemberStruct", 0, Black.Save.Party.SavePartyMemberStruct.ObjectType, null, properties, 0, 4);
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

            fieldProperties = new PropertyContainer("Black.Save.Party.SavePartyMemberStruct", null, 1072846272, 1655033737);
            return fieldProperties;
        }

		
    }
}