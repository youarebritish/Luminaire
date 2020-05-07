using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.WorldMap
{
    public partial class TerrainCurveNaviData : SQEX.Luminous.Core.Object.Object
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int Magic_;
		public int Version_;
		public IList<int> CurveCount_;
		public IList<int> SegmentsCount_;
		public IList<int> CurveAttribute_;
		public IList<float> CurveLength_;
		public IList<float> Weight_;
		public IList<int> ConnectionCountAtStart_;
		public IList<int> ConnectionCountAtEnd_;
		public IList<int> EdgeInfoAtStart_;
		public IList<int> EdgeInfoAtEnd_;
		public IList<int> ConnectedCurveID_;
		public IList<float> Angle_;
		public IList<float> RoughAngle_;
		public IList<bool> IsConnectToStartPos_;
		public IList<bool> IsRightSide_;
		public IList<float> PointX0_;
		public IList<float> PointX1_;
		public IList<float> PointX2_;
		public IList<float> PointX3_;
		public IList<float> PointY0_;
		public IList<float> PointY1_;
		public IList<float> PointY2_;
		public IList<float> PointY3_;
		public IList<float> PointZ0_;
		public IList<float> PointZ1_;
		public IList<float> PointZ2_;
		public IList<float> PointZ3_;
		public IList<float> BankSZ_;
		public IList<float> BankEZ_;
		public IList<float> FlattenWidth_;
		public IList<float> FlattenSmooth_;
		public IList<float> Length_;
		public IList<float> OffsetFromCurveStart_;
		public IList<float> DefaultLeftLane_;
		public IList<float> MaxLeftLane_;
		public IList<float> ParkLane_;
		public IList<float> LimitSpeed_;
		public IList<int> CurveType_;
		public IList<bool> CanParking_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TerrainCurveNaviData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.WorldMap.TerrainCurveNaviData", 0, Black.WorldMap.TerrainCurveNaviData.ObjectType, null, properties, 0, 632);
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

            fieldProperties = new PropertyContainer("Black.WorldMap.TerrainCurveNaviData", base.GetFieldProperties(), -865080503, 826699559);
            
			fieldProperties.AddProperty(new Property("Magic_", 1161525257, "unsigned int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("Version_", 319222456, "unsigned int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("CurveCount_", 1067008252, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 24, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("SegmentsCount_", 579988875, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 40, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("CurveAttribute_", 752726097, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 56, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("CurveLength_", 476778149, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 72, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("Weight_", 2897235698, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 88, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("ConnectionCountAtStart_", 2443305184, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 104, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("ConnectionCountAtEnd_", 3031358095, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 120, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("EdgeInfoAtStart_", 1966113568, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 136, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("EdgeInfoAtEnd_", 3341975503, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 152, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("ConnectedCurveID_", 527478683, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 168, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("Angle_", 3614758053, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 184, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("RoughAngle_", 1837165982, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 200, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("IsConnectToStartPos_", 4259050467, "SQEX.Ebony.Std.DynamicArray< bool, MEMORY_CATEGORY_MAP_CURVE >", 216, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("IsRightSide_", 3129933539, "SQEX.Ebony.Std.DynamicArray< bool, MEMORY_CATEGORY_MAP_CURVE >", 232, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PointX0_", 3803321562, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 248, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PointX1_", 2729406851, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 264, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PointX2_", 3802924204, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 280, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PointX3_", 3802777109, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 296, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PointY0_", 886911429, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 312, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PointY1_", 1960826140, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 328, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PointY2_", 1960973235, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 344, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PointY3_", 887352714, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 360, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PointZ0_", 2073072100, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 376, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PointZ1_", 2072925005, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 392, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PointZ2_", 3147133906, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 408, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PointZ3_", 3146986811, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 424, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("BankSZ_", 2548507367, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 440, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("BankEZ_", 2354221313, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 456, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("FlattenWidth_", 1848347828, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 472, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("FlattenSmooth_", 2780509172, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 488, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("Length_", 572654046, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 504, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("OffsetFromCurveStart_", 2959591972, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 520, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("DefaultLeftLane_", 3805511186, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 536, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("MaxLeftLane_", 1454329027, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 552, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("ParkLane_", 1134177020, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 568, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("LimitSpeed_", 3548622816, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 584, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("CurveType_", 4264925081, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 600, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("CanParking_", 46833096, "SQEX.Ebony.Std.DynamicArray< bool, MEMORY_CATEGORY_MAP_CURVE >", 616, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}