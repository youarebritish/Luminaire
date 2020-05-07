using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Vehicle
{
    public partial class SaveVehicleStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int version_;
		public Black.Save.Vehicle.SaveVehicleStatusStruct status_;
		public Black.Save.Vehicle.SaveVehicleCustomizeStruct customize_;
		public IList<int> reserve_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveVehicleStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Vehicle.SaveVehicleStruct", 0, Black.Save.Vehicle.SaveVehicleStruct.ObjectType, null, properties, 0, 1216);
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

            fieldProperties = new PropertyContainer("Black.Save.Vehicle.SaveVehicleStruct", null, 129730024, 1459156238);
            return fieldProperties;
        }

		
    }
}