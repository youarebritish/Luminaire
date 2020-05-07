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
            return fieldProperties;
        }

		
    }
}