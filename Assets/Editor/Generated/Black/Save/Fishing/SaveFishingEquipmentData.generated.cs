using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Fishing
{
    public partial class SaveFishingEquipmentData
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint lureId_;
		public uint lineId_;
		public uint rodId_;
		public uint reelId_;
		public bool isLureEquipped_;
		public bool isLineEquipped_;
		public bool isRodEquipped_;
		public bool isReelEquipped_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveFishingEquipmentData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Fishing.SaveFishingEquipmentData", 0, Black.Save.Fishing.SaveFishingEquipmentData.ObjectType, null, properties, 0, 20);
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

            fieldProperties = new PropertyContainer("Black.Save.Fishing.SaveFishingEquipmentData", null, -1119235546, 1271549387);
            return fieldProperties;
        }

		
    }
}