using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Area
{
    public partial class WorldPackage : Black.Entity.Area.LoadUnitPackage
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isWorldPackage_;
		public float CellSizeX_;
		public float CellSizeZ_;
		public int CellCountX_;
		public int CellCountZ_;
		public float LodDistance_;
		public string mapIDFilePath_;
		public string naviCurveFilePath_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new WorldPackage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Area.WorldPackage", 0, Black.Entity.Area.WorldPackage.ObjectType, null, properties, 0, 784);
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

            fieldProperties = new PropertyContainer("Black.Entity.Area.WorldPackage", base.GetFieldProperties(), 283728812, 1428133429);
            
			
			
			return fieldProperties;
        }

		
    }
}