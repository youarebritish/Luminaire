using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.WorldMap
{
    public partial class TerrainCurveDataData : SQEX.Luminous.Core.Object.Object
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int Magic_;
		public int Version_;
		public int CurveCount_;
		public IList<int> SegmentsCount_;
		public IList<int> InstancesCount_;
		public IList<bool> IsLoop_;
		public IList<char> CurveName_;
		public IList<float> LodLength_;
		public IList<int> CurveAttribute_;
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
		public IList<float> FlattenSmoothLeft_;
		public IList<int> ModelSetsCount_;
		public IList<int> ModelSetsIndex_;
		public IList<bool> AbsorbEnable_;
		public IList<bool> VisibleEnable_;
		public IList<int> SmoothType_;
		public IList<float> BezieLength_;
		public IList<int> EntityListCount_;
		public IList<int> EntityList_;
		public IList<int> CheckPosListCount_;
		public IList<float> CheckPosListX_;
		public IList<float> CheckPosListY_;
		public IList<float> CheckPosListZ_;
		public IList<bool> isBranch_;
		public IList<int> branchPointIndex_;
		public IList<int> branchPointCount_;
		public IList<int> branchSegmentCount_;
		public IList<int> segmentModelPattern0_;
		public IList<int> segmentModelPattern0ListCount_;
		public IList<int> segmentModelPattern0ListItemCount_;
		public IList<float> DefaultLeftLane_;
		public IList<float> MaxLeftLane_;
		public IList<float> ParkLane_;
		public IList<float> LimitSpeed_;
		public IList<int> CurveType_;
		public IList<bool> CanParking_;
		public IList<bool> IsForCollisionWall_;
		public IList<float> CollisionWallHeight_;
		public IList<float> CollisionWallHeight2_;
		public IList<float> CollisionWallWidth_;
		public IList<int> CollisionWallMask_;
		public IList<int> CollisionWallFlag_;
		public IList<int> CollisionWallFilter_;
		public IList<float> InstancePositionX_;
		public IList<float> InstancePositionY_;
		public IList<float> InstancePositionZ_;
		public IList<float> InstanceRotationX_;
		public IList<float> InstanceRotationY_;
		public IList<float> InstanceRotationZ_;
		public IList<float> InstanceScalingX_;
		public IList<float> InstanceScalingY_;
		public IList<float> InstanceScalingZ_;
		public IList<int> InstanceModelIndex_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TerrainCurveDataData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.WorldMap.TerrainCurveDataData", 0, Black.WorldMap.TerrainCurveDataData.ObjectType, null, properties, 0, 1072);
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

            fieldProperties = new PropertyContainer("Black.WorldMap.TerrainCurveDataData", base.GetFieldProperties(), 1536142193, -947275664);
            
			
			
			fieldProperties.AddProperty(new Property("Magic_", 1161525257, "unsigned int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("Version_", 319222456, "unsigned int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("CurveCount_", 1067008252, "unsigned int", 24, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("SegmentsCount_", 579988875, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 32, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("InstancesCount_", 3066499927, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 48, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("IsLoop_", 931696332, "SQEX.Ebony.Std.DynamicArray< bool, MEMORY_CATEGORY_MAP_CURVE >", 64, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("CurveName_", 2603215472, "SQEX.Ebony.Std.DynamicArray< char*, MEMORY_CATEGORY_MAP_CURVE >", 80, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("LodLength_", 687203489, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 96, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("CurveAttribute_", 752726097, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 112, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PointX0_", 3803321562, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 128, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PointX1_", 2729406851, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 144, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PointX2_", 3802924204, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 160, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PointX3_", 3802777109, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 176, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PointY0_", 886911429, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 192, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PointY1_", 1960826140, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 208, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PointY2_", 1960973235, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 224, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PointY3_", 887352714, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 240, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PointZ0_", 2073072100, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 256, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PointZ1_", 2072925005, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 272, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PointZ2_", 3147133906, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 288, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PointZ3_", 3146986811, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 304, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("BankSZ_", 2548507367, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 320, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("BankEZ_", 2354221313, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 336, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("FlattenWidth_", 1848347828, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 352, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("FlattenSmooth_", 2780509172, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 368, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("FlattenSmoothLeft_", 2282336127, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 384, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("ModelSetsCount_", 936913983, "SQEX.Ebony.Std.DynamicArray< int, MEMORY_CATEGORY_MAP_CURVE >", 400, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("ModelSetsIndex_", 1741050106, "SQEX.Ebony.Std.DynamicArray< int, MEMORY_CATEGORY_MAP_CURVE >", 416, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("AbsorbEnable_", 4015610616, "SQEX.Ebony.Std.DynamicArray< bool, MEMORY_CATEGORY_MAP_CURVE >", 432, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("VisibleEnable_", 3471382959, "SQEX.Ebony.Std.DynamicArray< bool, MEMORY_CATEGORY_MAP_CURVE >", 448, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("SmoothType_", 3419972120, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 464, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("BezieLength_", 834441401, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 480, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("EntityListCount_", 1334325486, "SQEX.Ebony.Std.DynamicArray< int, MEMORY_CATEGORY_MAP_CURVE >", 496, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("EntityList_", 4052587883, "SQEX.Ebony.Std.DynamicArray< int, MEMORY_CATEGORY_MAP_CURVE >", 512, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("CheckPosListCount_", 3920199883, "SQEX.Ebony.Std.DynamicArray< int, MEMORY_CATEGORY_MAP_CURVE >", 528, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("CheckPosListX_", 3933418110, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 544, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("CheckPosListY_", 3933271015, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 560, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("CheckPosListZ_", 711821072, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 576, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("isBranch_", 1165302206, "SQEX.Ebony.Std.DynamicArray< bool, MEMORY_CATEGORY_MAP_CURVE >", 592, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("branchPointIndex_", 790857096, "SQEX.Ebony.Std.DynamicArray< int, MEMORY_CATEGORY_MAP_CURVE >", 608, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("branchPointCount_", 1830983381, "SQEX.Ebony.Std.DynamicArray< int, MEMORY_CATEGORY_MAP_CURVE >", 624, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("branchSegmentCount_", 4241032638, "SQEX.Ebony.Std.DynamicArray< int, MEMORY_CATEGORY_MAP_CURVE >", 640, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("segmentModelPattern0_", 3539879946, "SQEX.Ebony.Std.DynamicArray< int, MEMORY_CATEGORY_MAP_CURVE >", 656, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("segmentModelPattern0ListCount_", 2266867481, "SQEX.Ebony.Std.DynamicArray< int, MEMORY_CATEGORY_MAP_CURVE >", 672, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("segmentModelPattern0ListItemCount_", 3829180390, "SQEX.Ebony.Std.DynamicArray< int, MEMORY_CATEGORY_MAP_CURVE >", 688, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("DefaultLeftLane_", 3805511186, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 704, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("MaxLeftLane_", 1454329027, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 720, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("ParkLane_", 1134177020, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 736, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("LimitSpeed_", 3548622816, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 752, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("CurveType_", 4264925081, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 768, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("CanParking_", 46833096, "SQEX.Ebony.Std.DynamicArray< bool, MEMORY_CATEGORY_MAP_CURVE >", 784, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("IsForCollisionWall_", 4182333545, "SQEX.Ebony.Std.DynamicArray< bool, MEMORY_CATEGORY_MAP_CURVE >", 800, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("CollisionWallHeight_", 1931324353, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 816, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("CollisionWallHeight2_", 3579461351, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 832, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("CollisionWallWidth_", 1311958646, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 848, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("CollisionWallMask_", 3458516928, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 864, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("CollisionWallFlag_", 440521006, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 880, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("CollisionWallFilter_", 2619497790, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 896, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("InstancePositionX_", 2085253776, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 912, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("InstancePositionY_", 1011339065, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 928, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("InstancePositionZ_", 1011883518, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 944, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("InstanceRotationX_", 432578005, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 960, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("InstanceRotationY_", 432725100, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 976, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("InstanceRotationZ_", 3654071875, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 992, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("InstanceScalingX_", 3684642650, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 1008, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("InstanceScalingY_", 2610727939, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 1024, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("InstanceScalingZ_", 3684245292, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 1040, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("InstanceModelIndex_", 4080237662, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 1056, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}