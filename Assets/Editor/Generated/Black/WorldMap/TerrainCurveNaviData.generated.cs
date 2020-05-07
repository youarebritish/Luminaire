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
            return fieldProperties;
        }

		
    }
}