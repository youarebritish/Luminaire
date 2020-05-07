using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Mobhunt
{
    public partial class SaveMobhuntStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int dinnerId_;
		public Black.Save.Mobhunt.SaveMobhuntDataStruct mobhuntData;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveMobhuntStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Mobhunt.SaveMobhuntStruct", 0, Black.Save.Mobhunt.SaveMobhuntStruct.ObjectType, null, properties, 0, 2568);
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

            fieldProperties = new PropertyContainer("Black.Save.Mobhunt.SaveMobhuntStruct", null, 886934223, -1667446612);
            return fieldProperties;
        }

		
    }
}