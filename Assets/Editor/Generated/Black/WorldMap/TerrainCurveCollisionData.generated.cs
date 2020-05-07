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
            
			
			
			fieldProperties.AddProperty(new Property("Magic_", 1161525257, "unsigned int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("Version_", 319222456, "unsigned int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("CollisionCount_", 1964324875, "unsigned int", 24, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("BuiltMeshID_", 2914091260, "unsigned int", 28, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("CollisionType_", 1537175416, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_COLLISION >", 32, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("DrawableObjectID_", 1370401626, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_COLLISION >", 48, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("MCHIndex_", 2104725882, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_COLLISION >", 64, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PhysXDataID_", 659059623, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_COLLISION >", 80, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("VertexSize_", 1305624435, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_COLLISION >", 96, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("IndexSize_", 1612502159, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_COLLISION >", 112, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("AttributeSize_", 1674395419, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_COLLISION >", 128, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("BoundingBoxMinX_", 2802701527, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_COLLISION >", 144, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("BoundingBoxMinY_", 1729184174, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_COLLISION >", 160, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("BoundingBoxMinZ_", 1728639721, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_COLLISION >", 176, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("BoundingBoxMaxX_", 41133833, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_COLLISION >", 192, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("BoundingBoxMaxY_", 41280928, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_COLLISION >", 208, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("BoundingBoxMaxZ_", 3262627703, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_COLLISION >", 224, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PositionX_", 2366528907, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_COLLISION >", 240, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PositionY_", 1293011554, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_COLLISION >", 256, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PositionZ_", 1292467101, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_COLLISION >", 272, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PositionX2_", 3789593257, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_COLLISION >", 288, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PositionY2_", 2411624474, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_COLLISION >", 304, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PositionZ2_", 146473307, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_COLLISION >", 320, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("WallWidth_", 1330021616, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_COLLISION >", 336, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("WallHeight_", 3838670231, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_COLLISION >", 352, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("WallHeight2_", 4133655437, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_COLLISION >", 368, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("WallMask_", 3022710514, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_COLLISION >", 384, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("WallFlag_", 3535179688, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_COLLISION >", 400, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("WallFilter_", 2702401608, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_COLLISION >", 416, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("VertexBuffer_", 3994585894, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_COLLISION >", 432, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("IndexBuffer_", 4132111482, "SQEX.Ebony.Std.DynamicArray< unsigned short, MEMORY_CATEGORY_MAP_COLLISION >", 448, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("AttributeBuffer_", 4008519630, "SQEX.Ebony.Std.DynamicArray< unsigned short, MEMORY_CATEGORY_MAP_COLLISION >", 464, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("PhysXData_", 3909817712, "SQEX.Ebony.Std.DynamicArray< unsigned char, MEMORY_CATEGORY_MAP_COLLISION >", 480, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}