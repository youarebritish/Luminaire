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
            
			fieldProperties.AddIndirectlyProperty(new Property("selectEquipment.lureId_", 827371793, "SQEX.Ebony.Std.Fixid", 48, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selectEquipment.lineId_", 1173325641, "SQEX.Ebony.Std.Fixid", 52, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selectEquipment.rodId_", 1186274726, "SQEX.Ebony.Std.Fixid", 56, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selectEquipment.reelId_", 2246347467, "SQEX.Ebony.Std.Fixid", 60, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selectEquipment.isLureEquipped_", 4193796517, "bool", 64, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selectEquipment.isLineEquipped_", 1831844253, "bool", 65, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selectEquipment.isRodEquipped_", 315686626, "bool", 66, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selectEquipment.isReelEquipped_", 193737543, "bool", 67, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
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