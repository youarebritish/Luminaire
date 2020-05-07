using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Fishing
{
    public partial class SaveFishingLineData
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint lineId_;
		public float remainStammina_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveFishingLineData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Fishing.SaveFishingLineData", 0, Black.Save.Fishing.SaveFishingLineData.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.Save.Fishing.SaveFishingLineData", null, 4823593, -1631486267);
            return fieldProperties;
        }

		
    }
}