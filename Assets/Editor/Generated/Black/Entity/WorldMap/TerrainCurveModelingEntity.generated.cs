using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.WorldMap
{
    public partial class TerrainCurveModelingEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string authoringFilePath_;
		public IList<Black.Entity.WorldMap.TerrainCurveModelFilePath> modelFilePaths_;
		public int curveCategory_;
		public bool isAbsorbable_;
		public string roadmaskDir_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TerrainCurveModelingEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.WorldMap.TerrainCurveModelingEntity", 0, Black.Entity.WorldMap.TerrainCurveModelingEntity.ObjectType, null, properties, 0, 608);
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

            fieldProperties = new PropertyContainer("Black.Entity.WorldMap.TerrainCurveModelingEntity", base.GetFieldProperties(), -716847453, -1455400666);
            
			
			
			fieldProperties.AddProperty(new Property("authoringFilePath_", 2904939276, "Ebony.Base.String", 384, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("modelFilePaths_", 2046157829, "SQEX.Ebony.Std.DynamicArray< Black.Entity.WorldMap.TerrainCurveModelFilePath* >", 400, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("curveCategory_", 1060782121, "Black.Entity.WorldMap.TerrainCurveModelingEntity.CURVE_CATEGORY", 416, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isAbsorbable_", 653953453, "bool", 420, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("roadmaskDir_", 1592846083, "Ebony.Base.String", 424, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}