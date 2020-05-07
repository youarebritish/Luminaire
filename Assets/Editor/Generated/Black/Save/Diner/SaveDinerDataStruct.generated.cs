using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Diner
{
    public partial class SaveDinerDataStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint dinerId_;
		public bool updateInformation_;
		public bool updateMobHunt_;
		public bool updateRecipe_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveDinerDataStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Diner.SaveDinerDataStruct", 0, Black.Save.Diner.SaveDinerDataStruct.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.Save.Diner.SaveDinerDataStruct", null, 1534455472, 2101519689);
            
			
			
			return fieldProperties;
        }

		
    }
}