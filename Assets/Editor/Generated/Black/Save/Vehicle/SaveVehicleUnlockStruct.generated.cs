using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Vehicle
{
    public partial class SaveVehicleUnlockStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id_;
		public bool isNew_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveVehicleUnlockStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Vehicle.SaveVehicleUnlockStruct", 0, Black.Save.Vehicle.SaveVehicleUnlockStruct.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.Save.Vehicle.SaveVehicleUnlockStruct", null, 588810530, -458630081);
            return fieldProperties;
        }

		
    }
}