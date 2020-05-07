using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Diner
{
    public partial class SaveDinerStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint currentDinerId_;
		public IList<Black.Save.Diner.SaveDinerDataStruct> dataLists_;
		public IList<Black.Save.Diner.SaveDinerInformationStruct> informationLists_;
		public IList<Black.Save.Diner.SaveDinerPlaceStruct> placeLists_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveDinerStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Diner.SaveDinerStruct", 0, Black.Save.Diner.SaveDinerStruct.ObjectType, null, properties, 0, 56);
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

            fieldProperties = new PropertyContainer("Black.Save.Diner.SaveDinerStruct", null, -1730978843, -1347547320);
            return fieldProperties;
        }

		
    }
}