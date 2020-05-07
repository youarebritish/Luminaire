using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Common
{
    public partial class SaveCommonStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint presenceId_;
		public bool forbidSaveAnywhereFlag_;
		public int reserved_;
		public long reserved2_;
		public int noxScore_;
		public Black.Save.Multiplay.SavePlantMapDataStruct plantMapData_;
		public Black.Save.Common.SaveEpiScore ignis_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveCommonStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Common.SaveCommonStruct", 0, Black.Save.Common.SaveCommonStruct.ObjectType, null, properties, 0, 5008);
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

            fieldProperties = new PropertyContainer("Black.Save.Common.SaveCommonStruct", null, -1051156837, 1652488587);
            
			fieldProperties.AddProperty(new Property("presenceId_", 3492320450, "SQEX.Ebony.Std.Fixid", 0, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("forbidSaveAnywhereFlag_", 3485292166, "bool", 4, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserved_", 2083388678, "int", 8, 200, 50, Property.PrimitiveType.Int32, 0, (char)8));
			fieldProperties.AddProperty(new Property("reserved2_", 3587458470, "int64_t", 208, 400, 50, Property.PrimitiveType.Int64, 0, (char)8));
			fieldProperties.AddProperty(new Property("noxScore_", 4000410673, "uint32_t", 608, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("plantMapData_", 1555303457, "Black.Save.Multiplay.SavePlantMapDataStruct", 612, 4004, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ignis_", 824974638, "Black.Save.Common.SaveEpiScore", 4616, 388, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}