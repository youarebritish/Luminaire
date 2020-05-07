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
            
			fieldProperties.AddProperty(new Property("CellSizeX_", 1465403481, "float", 688, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("CellSizeZ_", 1465697671, "float", 692, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("CellCountX_", 695016913, "int", 696, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("CellCountZ_", 1769078719, "int", 700, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("LodDistance_", 3626182916, "float", 704, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("MapId_", 3193862913, "int", 708, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("subMapShiftOffsets_", 2152250522, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Area.PackageLocationArrayItem* >", 712, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("AdjustPos_", 689520673, "Luminous.Math.VectorA", 736, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("isTitle_", 3057926770, "bool", 752, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("worldMapType_", 4072004524, "Black.Entity.Area.AreaPackage.AreaWorldMapType", 756, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}