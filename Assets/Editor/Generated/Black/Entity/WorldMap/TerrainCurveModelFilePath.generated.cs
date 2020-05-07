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
            
			
			
			fieldProperties.AddProperty(new Property("terrainCurveModelFilePath_", 1335158296, "Ebony.Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("terrainCurveAbsorbModelFilePath_", 3287407189, "Ebony.Base.String", 24, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("terrainCurveCollisionFilePath_", 1525502731, "Ebony.Base.String", 40, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("terrainCurveWeedingFilePath_", 2616470690, "Ebony.Base.String", 56, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("isBakable_", 2425300974, "bool", 72, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isFoliageCheckThrough_", 1457859362, "bool", 73, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}