using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Fishing
{
    public partial class SaveFishingStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int saveVersion;
		public int getFishCount;
		public IList<Black.Save.Fishing.SaveFishingGetFishData> getFishList;
		public int lineInfoCount;
		public IList<Black.Save.Fishing.SaveFishingLineData> lineInfoList;
		public Black.Save.Fishing.SaveFishingEquipmentData selectEquipment;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveFishingStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Fishing.SaveFishingStruct", 0, Black.Save.Fishing.SaveFishingStruct.ObjectType, null, properties, 0, 72);
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

            fieldProperties = new PropertyContainer("Black.Save.Fishing.SaveFishingStruct", null, 770892388, -283988830);
            
			
			
			return fieldProperties;
        }

		
    }
}