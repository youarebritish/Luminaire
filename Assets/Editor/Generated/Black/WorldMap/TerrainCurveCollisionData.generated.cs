using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.WorldMap
{
    public partial class TerrainCurveCollisionData : SQEX.Luminous.Core.Object.Object
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int Magic_;
		public int Version_;
		public int CollisionCount_;
		public int BuiltMeshID_;
		public IList<int> CollisionType_;
		public IList<int> DrawableObjectID_;
		public IList<int> MCHIndex_;
		public IList<int> PhysXDataID_;
		public IList<int> VertexSize_;
		public IList<int> IndexSize_;
		public IList<int> AttributeSize_;
		public IList<float> BoundingBoxMinX_;
		public IList<float> BoundingBoxMinY_;
		public IList<float> BoundingBoxMinZ_;
		public IList<float> BoundingBoxMaxX_;
		public IList<float> BoundingBoxMaxY_;
		public IList<float> BoundingBoxMaxZ_;
		public IList<float> PositionX_;
		public IList<float> PositionY_;
		public IList<float> PositionZ_;
		public IList<float> PositionX2_;
		public IList<float> PositionY2_;
		public IList<float> PositionZ2_;
		public IList<float> WallWidth_;
		public IList<float> WallHeight_;
		public IList<float> WallHeight2_;
		public IList<int> WallMask_;
		public IList<int> WallFlag_;
		public IList<int> WallFilter_;
		public IList<float> VertexBuffer_;
		public IList<short> IndexBuffer_;
		public IList<short> AttributeBuffer_;
		public IList<char> PhysXData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TerrainCurveCollisionData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.WorldMap.TerrainCurveCollisionData", 0, Black.WorldMap.TerrainCurveCollisionData.ObjectType, null, properties, 0, 520);
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

            fieldProperties = new PropertyContainer("Black.WorldMap.TerrainCurveCollisionData", base.GetFieldProperties(), -430888362, 1158521870);
            
			
			
			return fieldProperties;
        }

		
    }
}