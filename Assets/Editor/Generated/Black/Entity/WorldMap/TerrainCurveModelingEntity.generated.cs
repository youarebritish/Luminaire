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
            return fieldProperties;
        }

		
    }
}