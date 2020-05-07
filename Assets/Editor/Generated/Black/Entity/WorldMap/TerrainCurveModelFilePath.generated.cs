using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.WorldMap
{
    public partial class TerrainCurveModelFilePath : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string terrainCurveModelFilePath_;
		public string terrainCurveAbsorbModelFilePath_;
		public string terrainCurveCollisionFilePath_;
		public string terrainCurveWeedingFilePath_;
		public bool isBakable_;
		public bool isFoliageCheckThrough_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TerrainCurveModelFilePath();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.WorldMap.TerrainCurveModelFilePath", 0, Black.Entity.WorldMap.TerrainCurveModelFilePath.ObjectType, null, properties, 0, 80);
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

            fieldProperties = new PropertyContainer("Black.Entity.WorldMap.TerrainCurveModelFilePath", base.GetFieldProperties(), -755224478, -1009095835);
            return fieldProperties;
        }

		
    }
}