using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Vehicle
{
    public partial class SaveVehicleCustomizeStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.Save.Vehicle.SaveVehicleColorStruct> unlockedBodyColor_;
		public IList<Black.Save.Vehicle.SaveVehicleColorStruct> unlockedInteriorColor_;
		public IList<Black.Save.Vehicle.SaveVehicleColorStruct> unlockedTireColor_;
		public IList<Black.Save.Vehicle.SaveVehicleUnlockStruct> unlockedSetSticker_;
		public IList<Black.Save.Vehicle.SaveVehicleUnlockStruct> unlockedLeftSticker_;
		public IList<Black.Save.Vehicle.SaveVehicleUnlockStruct> unlockedRightSticker_;
		public IList<Black.Save.Vehicle.SaveVehicleUnlockStruct> unlockedTopSticker_;
		public IList<Black.Save.Vehicle.SaveVehicleUnlockStruct> unlockedFrontSticker_;
		public IList<Black.Save.Vehicle.SaveVehicleUnlockStruct> unlockedRearSticker_;
		public IList<Black.Save.Vehicle.SaveVehiclePartsStruct> unlockedParts_;
		public int lastUnlockedBodyColorNum_;
		public int lastUnlockedInteriorColorNum_;
		public int lastUnlockedTireColorNum_;
		public int lastUnlockedSetStickerNum_;
		public int lastUnlockedLeftStickerNum_;
		public int lastUnlockedRightStickerNum_;
		public int lastUnlockedTopStickerNum_;
		public int lastUnlockedFrontStickerNum_;
		public int lastUnlockedRearStickerNum_;
		public int lastUnlockedPartsStickerNum_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveVehicleCustomizeStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Vehicle.SaveVehicleCustomizeStruct", 0, Black.Save.Vehicle.SaveVehicleCustomizeStruct.ObjectType, null, properties, 0, 200);
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

            fieldProperties = new PropertyContainer("Black.Save.Vehicle.SaveVehicleCustomizeStruct", null, -1995153951, 1857417584);
            
			
			
			return fieldProperties;
        }

		
    }
}