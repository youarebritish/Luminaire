using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.WorldMap.Foliage
{
    public partial class FoliageResourceEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.Entity.WorldMap.Foliage.FoliageModelFilePathEntity> foliageModelFilePaths_;
		public string decorationSetFilePath_;
		public string decorationSetHighFilePath_;
		public float radius_;
		public bool loadWhenFly_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new FoliageResourceEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.WorldMap.Foliage.FoliageResourceEntity", 0, Black.Entity.WorldMap.Foliage.FoliageResourceEntity.ObjectType, null, properties, 0, 168);
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

            fieldProperties = new PropertyContainer("Black.Entity.WorldMap.Foliage.FoliageResourceEntity", base.GetFieldProperties(), 15273958, -1769805089);
            
			
			
			return fieldProperties;
        }

		
    }
}