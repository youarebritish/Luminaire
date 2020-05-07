using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Diner
{
    public partial class SaveDinerInformationStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint informationId_;
		public bool unlock_;
		public bool check_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveDinerInformationStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Diner.SaveDinerInformationStruct", 0, Black.Save.Diner.SaveDinerInformationStruct.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.Save.Diner.SaveDinerInformationStruct", null, 111743731, -1325551365);
            return fieldProperties;
        }

		
    }
}