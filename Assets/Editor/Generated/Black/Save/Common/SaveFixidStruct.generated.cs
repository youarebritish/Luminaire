using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Common
{
    public partial class SaveFixidStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveFixidStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Common.SaveFixidStruct", 0, Black.Save.Common.SaveFixidStruct.ObjectType, null, properties, 0, 4);
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

            fieldProperties = new PropertyContainer("Black.Save.Common.SaveFixidStruct", null, -2139253979, 1170161483);
            return fieldProperties;
        }

		
    }
}