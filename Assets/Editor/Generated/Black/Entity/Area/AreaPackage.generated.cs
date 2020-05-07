using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Area
{
    public partial class AreaPackage : Black.Entity.Area.LoadUnitPackage
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float CellSizeX_;
		public float CellSizeZ_;
		public int CellCountX_;
		public int CellCountZ_;
		public float LodDistance_;
		public int MapId_;
		public IList<Black.Entity.Area.PackageLocationArrayItem> subMapShiftOffsets_;
		public UnityEngine.Vector4 AdjustPos_;
		public bool isTitle_;
		public int worldMapType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AreaPackage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Area.AreaPackage", 0, Black.Entity.Area.AreaPackage.ObjectType, null, properties, 0, 784);
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

            fieldProperties = new PropertyContainer("Black.Entity.Area.AreaPackage", base.GetFieldProperties(), 1653237061, -98813509);
            
			
			
			return fieldProperties;
        }

		
    }
}