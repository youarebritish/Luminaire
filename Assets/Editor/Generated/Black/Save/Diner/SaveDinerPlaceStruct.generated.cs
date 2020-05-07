using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Diner
{
    public partial class SaveDinerPlaceStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint diner_id_;
		public uint map_icon_id_;
		public int object_condition_;
		public int icon_condition_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveDinerPlaceStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Diner.SaveDinerPlaceStruct", 0, Black.Save.Diner.SaveDinerPlaceStruct.ObjectType, null, properties, 0, 16);
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

            fieldProperties = new PropertyContainer("Black.Save.Diner.SaveDinerPlaceStruct", null, 1016045616, 533842338);
            
			
			
			return fieldProperties;
        }

		
    }
}