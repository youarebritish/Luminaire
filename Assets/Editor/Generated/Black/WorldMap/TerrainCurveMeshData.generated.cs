using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.WorldMap
{
    public partial class TerrainCurveMeshData : SQEX.Luminous.Core.Object.Object
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int Magic_;
		public int Version_;
		public int MeshCount_;
		public IList<uint> RequireResourceList_;
		public IList<int> InstanceNodeIndex_;
		public IList<int> CurveIndex_;
		public IList<int> MeshDataCount_;
		public IList<float> InfoPositionX_;
		public IList<float> InfoPositionY_;
		public IList<float> InfoPositionZ_;
		public IList<int> BuiltMeshID_;
		public IList<int> VertexBuffer0Size_;
		public IList<int> VertexBuffer1Size_;
		public IList<int> VertexBuffer2Size_;
		public IList<int> IndexBufferSize_;
		public IList<float> BoundingBoxMaxX_;
		public IList<float> BoundingBoxMaxY_;
		public IList<float> BoundingBoxMaxZ_;
		public IList<float> BoundingBoxMinX_;
		public IList<float> BoundingBoxMinY_;
		public IList<float> BoundingBoxMinZ_;
		public IList<float> Vertex0Buffer_;
		public IList<float> Vertex1Buffer_;
		public IList<float> Vertex2Buffer_;
		public IList<int> IndexBuffer_;
		public IList<int> LightCount_;
		public IList<int> MetaInstanceNodeHash_;
		public IList<int> MetaMeshTagCount_;
		public IList<float> MetaMeshDataLODNear_;
		public IList<float> MetaMeshDataLODFar_;
		public IList<int> MetaMeshDataVertexDataCount_;
		public IList<int> MetaMeshDataVertexStride_;
		public IList<int> MetaMeshDataPosType_;
		public IList<int> MetaMeshDataPosOffset_;
		public IList<int> MetaMeshDataNrmType_;
		public IList<int> MetaMeshDataNrmOffset_;
		public IList<int> MetaMeshDataBinType_;
		public IList<int> MetaMeshDataBinOffset_;
		public IList<int> MetaMeshDataTanType_;
		public IList<int> MetaMeshDataTanOffset_;
		public IList<int> MetaMeshDataCol2Type_;
		public IList<int> MetaMeshDataCol2Offset_;
		public IList<int> LightNodeHash_;
		public IList<int> LightShadowOwnerIndex_;
		public IList<float> LightPosX_;
		public IList<float> LightPosY_;
		public IList<float> LightPosZ_;
		public IList<float> LightDirX_;
		public IList<float> LightDirY_;
		public IList<float> LightDirZ_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TerrainCurveMeshData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.WorldMap.TerrainCurveMeshData", 0, Black.WorldMap.TerrainCurveMeshData.ObjectType, null, properties, 0, 808);
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

            fieldProperties = new PropertyContainer("Black.WorldMap.TerrainCurveMeshData", base.GetFieldProperties(), -642649408, 1722043615);
            
			fieldProperties.AddProperty(new Property("Magic_", 1161525257, "unsigned int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("Version_", 319222456, "unsigned int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("MeshCount_", 1283188948, "unsigned int", 24, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("RequireResourceList_", 1136799597, "SQEX.Ebony.Std.DynamicArray< uint32_t, MEMORY_CATEGORY_MAP_CURVE >", 32, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("InstanceNodeIndex_", 923545303, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 48, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("CurveIndex_", 2159555869, "SQEX.Ebony.Std.DynamicArray< int, MEMORY_CATEGORY_MAP_CURVE >", 64, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("MeshDataCount_", 2572227276, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 80, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("InfoPositionX_", 904835115, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 96, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("InfoPositionY_", 1978749826, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 112, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("InfoPositionZ_", 1978308541, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 128, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("BuiltMeshID_", 2914091260, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 144, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("VertexBuffer0Size_", 1652438083, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 160, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("VertexBuffer1Size_", 435992230, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 176, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("VertexBuffer2Size_", 184854225, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 192, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("IndexBufferSize_", 3894286973, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 208, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("BoundingBoxMaxX_", 41133833, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 224, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("BoundingBoxMaxY_", 41280928, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 240, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("BoundingBoxMaxZ_", 3262627703, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 256, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("BoundingBoxMinX_", 2802701527, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 272, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("BoundingBoxMinY_", 1729184174, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 288, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("BoundingBoxMinZ_", 1728639721, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 304, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("Vertex0Buffer_", 3555068380, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 320, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("Vertex1Buffer_", 899327497, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 336, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("Vertex2Buffer_", 1331098222, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 352, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("IndexBuffer_", 4132111482, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 368, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("LightCount_", 3851587627, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 384, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("MetaInstanceNodeHash_", 969850436, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 400, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("MetaMeshTagCount_", 2760669279, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 416, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("MetaMeshDataLODNear_", 580933127, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 432, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("MetaMeshDataLODFar_", 229824362, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 448, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("MetaMeshDataVertexDataCount_", 3244312691, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 464, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("MetaMeshDataVertexStride_", 4201258239, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 480, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("MetaMeshDataPosType_", 3411710418, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 496, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("MetaMeshDataPosOffset_", 4066791523, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 512, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("MetaMeshDataNrmType_", 2766366233, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 528, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("MetaMeshDataNrmOffset_", 2436954864, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 544, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("MetaMeshDataBinType_", 3519942203, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 560, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("MetaMeshDataBinOffset_", 3541797738, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 576, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("MetaMeshDataTanType_", 1356960597, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 592, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("MetaMeshDataTanOffset_", 3509721716, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 608, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("MetaMeshDataCol2Type_", 2889223362, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 624, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("MetaMeshDataCol2Offset_", 2422361587, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 640, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("LightNodeHash_", 844395744, "SQEX.Ebony.Std.DynamicArray< unsigned int, MEMORY_CATEGORY_MAP_CURVE >", 656, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("LightShadowOwnerIndex_", 2216042299, "SQEX.Ebony.Std.DynamicArray< int, MEMORY_CATEGORY_MAP_CURVE >", 672, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("LightPosX_", 531339070, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 688, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("LightPosY_", 531191975, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 704, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("LightPosZ_", 1604812496, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 720, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("LightDirX_", 1723723303, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 736, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("LightDirY_", 1723870398, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 752, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("LightDirZ_", 1723429113, "SQEX.Ebony.Std.DynamicArray< float, MEMORY_CATEGORY_MAP_CURVE >", 768, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}