using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Mobhunt
{
    public partial class SaveMobhuntPartsDataStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint partsId_;
		public bool isDestructed_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveMobhuntPartsDataStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Mobhunt.SaveMobhuntPartsDataStruct", 0, Black.Save.Mobhunt.SaveMobhuntPartsDataStruct.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.Save.Mobhunt.SaveMobhuntPartsDataStruct", null, -1866012259, -601970424);
            return fieldProperties;
        }

		
    }
}