using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.WorldMap
{
    public partial class WorldMapPackageInfo : Black.Entity.EntityPackage
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float CellSizeX_;
		public float CellSizeZ_;
		public int CellCountX_;
		public int CellCountZ_;
		public float LodDistance_;
		public string mapIDFilePath_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new WorldMapPackageInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.WorldMap.WorldMapPackageInfo", 0, Black.Entity.WorldMap.WorldMapPackageInfo.ObjectType, null, properties, 0, 672);
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

            fieldProperties = new PropertyContainer("Black.Entity.WorldMap.WorldMapPackageInfo", base.GetFieldProperties(), -115184380, 1089834305);
            
			
			
			return fieldProperties;
        }

		
    }
}