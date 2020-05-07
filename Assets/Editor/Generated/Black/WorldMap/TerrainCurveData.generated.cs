using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.WorldMap
{
    public partial class TerrainCurveData : Black.WorldMap.TerrainCurveDataData
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int ModelSetCount_;
		public IList<char> ModelName_;
		public IList<int> ModelIndex0_;
		public IList<int> ModelIndex1_;
		public IList<int> ModelIndex2_;
		public IList<int> ModelIndex0Count_;
		public IList<float> ModelLength0_;
		public IList<float> ModelLength1_;
		public IList<float> ModelLength2_;
		public IList<float> OffsetX_;
		public IList<float> OffsetY_;
		public IList<bool> IsCollision_;
		public IList<bool> IsTransForm_;
		public IList<bool> IsStraight_;
		public IList<bool> IsYRotationOnly_;
		public IList<bool> IsForInstancing_;
		public IList<int> ModelSelectRate0_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TerrainCurveData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.WorldMap.TerrainCurveData", 0, Black.WorldMap.TerrainCurveData.ObjectType, null, properties, 0, 1344);
        }
		
        public override ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected override PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.WorldMap.TerrainCurveData", base.GetFieldProperties(), -557088140, 1693118458);
            
			fieldProperties.AddProperty(new Property("ModelSetCount_", 2776012714, "unsigned int", 1072, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ModelName_", 3715820698, "SQEX.Ebony.Std.DynamicArray< char*, MEMORY_CATEGORY_MAP_CURVE >", 1080, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("ModelIndex0_", 1895086943, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 1096, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("ModelIndex1_", 2969001654, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 1112, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("ModelIndex2_", 2968560369, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 1128, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("ModelIndex0Count_", 3133217290, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 1144, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("ModelLength0_", 1087526319, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 1160, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("ModelLength1_", 1087673414, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 1176, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("ModelLength2_", 13464513, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 1192, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("OffsetX_", 4261284939, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 1208, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("OffsetY_", 3187664418, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 1224, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("IsCollision_", 1592173312, "SQEX.Ebony.Std.DynamicArray< bool, MEMORY_CATEGORY_MAP_CURVE >", 1240, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("IsTransForm_", 1576752156, "SQEX.Ebony.Std.DynamicArray< bool, MEMORY_CATEGORY_MAP_CURVE >", 1256, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("IsStraight_", 1828070936, "SQEX.Ebony.Std.DynamicArray< bool, MEMORY_CATEGORY_MAP_CURVE >", 1272, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("IsYRotationOnly_", 3921939649, "SQEX.Ebony.Std.DynamicArray< bool, MEMORY_CATEGORY_MAP_CURVE >", 1288, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("IsForInstancing_", 81608569, "SQEX.Ebony.Std.DynamicArray< bool, MEMORY_CATEGORY_MAP_CURVE >", 1304, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("ModelSelectRate0_", 3626567629, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 1320, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}