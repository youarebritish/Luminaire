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
            
			fieldProperties.AddProperty(new Property("saveVersion", 2514249556, "uint32_t", 0, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("getFishCount", 4097949868, "uint32_t", 4, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("getFishList", 4061719721, "SQEX.Ebony.Std.DynamicArray< Black.Save.Fishing.SaveFishingGetFishData >", 8, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("lineInfoCount", 4196271586, "uint32_t", 24, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("lineInfoList", 1964978315, "SQEX.Ebony.Std.DynamicArray< Black.Save.Fishing.SaveFishingLineData >", 32, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("selectEquipment", 2343071295, "Black.Save.Fishing.SaveFishingEquipmentData", 48, 20, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}