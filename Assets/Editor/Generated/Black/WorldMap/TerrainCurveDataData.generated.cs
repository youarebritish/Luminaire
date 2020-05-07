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
            return fieldProperties;
        }

		
    }
}