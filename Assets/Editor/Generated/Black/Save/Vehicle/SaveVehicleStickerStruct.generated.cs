using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Vehicle
{
    public partial class SaveVehicleStickerStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint stickerId_;
		public string texturePath_;
		public float rotate_;
		public float scale_;
		public float trans_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveVehicleStickerStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Vehicle.SaveVehicleStickerStruct", 0, Black.Save.Vehicle.SaveVehicleStickerStruct.ObjectType, null, properties, 0, 48);
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

            fieldProperties = new PropertyContainer("Black.Save.Vehicle.SaveVehicleStickerStruct", null, -915118157, -1588153568);
            return fieldProperties;
        }

		
    }
}