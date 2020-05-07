using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Party
{
    public partial class SaveTrophyStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id;
		public bool exist;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveTrophyStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Party.SaveTrophyStruct", 0, Black.Save.Party.SaveTrophyStruct.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.Save.Party.SaveTrophyStruct", null, 116537585, 896139733);
            return fieldProperties;
        }

		
    }
}