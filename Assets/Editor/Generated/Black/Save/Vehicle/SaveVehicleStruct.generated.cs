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
            
			fieldProperties.AddProperty(new Property("version_", 2901812440, "uint32_t", 0, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("status_", 4107102736, "Black.Save.Vehicle.SaveVehicleStatusStruct", 16, 976, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("customize_", 902257093, "Black.Save.Vehicle.SaveVehicleCustomizeStruct", 992, 200, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve_", 3115688060, "SQEX.Ebony.Std.DynamicArray< int >", 1192, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}