using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Fishing
{
    public partial class SaveFishingGetFishData
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint fishId_;
		public float getMaxSize_;
		public int getCount_;
		public uint lureId_Rec_;
		public int hour24_Rec_;
		public uint fishingSpotId_Rec_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveFishingGetFishData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Fishing.SaveFishingGetFishData", 0, Black.Save.Fishing.SaveFishingGetFishData.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.Save.Fishing.SaveFishingGetFishData", null, -512245723, 381596064);
            return fieldProperties;
        }

		
    }
}