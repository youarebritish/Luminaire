using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.WorldMap.Foliage
{
    public partial class FoliageDataEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string foliageFilePath_;
		public string foliageHighSpecFilePath_;
		public int cellNo_;
		public int cellX_;
		public int cellZ_;
		public bool useWorldPosition_;
		public float radius_;
		public bool radiusAutoCalc_;
		public bool radiusFromResourceEntity_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new FoliageDataEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.WorldMap.Foliage.FoliageDataEntity", 0, Black.Entity.WorldMap.Foliage.FoliageDataEntity.ObjectType, null, properties, 0, 480);
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

            fieldProperties = new PropertyContainer("Black.Entity.WorldMap.Foliage.FoliageDataEntity", base.GetFieldProperties(), -1519117694, -2028394665);
            
			
			
			return fieldProperties;
        }

		
    }
}