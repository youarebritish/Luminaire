using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Vehicle
{
    public partial class SaveVehicleLooksStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.Save.Vehicle.SaveVehicleMaterialStruct> material_;
		public uint colorId_;
		public uint setStickerId_;
		public Black.Save.Vehicle.SaveVehicleStickerStruct sticker_;
		public bool isUseSticker_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveVehicleLooksStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Vehicle.SaveVehicleLooksStruct", 0, Black.Save.Vehicle.SaveVehicleLooksStruct.ObjectType, null, properties, 0, 280);
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

            fieldProperties = new PropertyContainer("Black.Save.Vehicle.SaveVehicleLooksStruct", null, 1576290877, -580518508);
            return fieldProperties;
        }

		
    }
}