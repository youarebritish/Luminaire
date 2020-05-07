using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Mobhunt
{
    public partial class SaveMobhuntVDataStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int id_;
		public uint elementId_;
		public Black.Save.Mobhunt.SaveMobhuntPartsDataStruct partsData;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveMobhuntVDataStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Mobhunt.SaveMobhuntVDataStruct", 0, Black.Save.Mobhunt.SaveMobhuntVDataStruct.ObjectType, null, properties, 0, 136);
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

            fieldProperties = new PropertyContainer("Black.Save.Mobhunt.SaveMobhuntVDataStruct", null, 1964642690, 348277540);
            
			
			
			return fieldProperties;
        }

		
    }
}