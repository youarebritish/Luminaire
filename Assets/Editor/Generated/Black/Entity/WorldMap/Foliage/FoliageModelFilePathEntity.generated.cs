using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.WorldMap.Foliage
{
    public partial class FoliageModelFilePathEntity : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string foliageModelFilePath_;
		public string foliageHighModelFilePath_;
		public string foliageCollisionFilePath_;
		public string foliageHighCollisionFilePath_;
		public int foliageCategory_;
		public bool isBakable_;
		public bool shiftTarget_;
		public float shiftTargetOffset_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new FoliageModelFilePathEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.WorldMap.Foliage.FoliageModelFilePathEntity", 0, Black.Entity.WorldMap.Foliage.FoliageModelFilePathEntity.ObjectType, null, properties, 0, 88);
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

            fieldProperties = new PropertyContainer("Black.Entity.WorldMap.Foliage.FoliageModelFilePathEntity", base.GetFieldProperties(), -1290797530, 1679866869);
            
			
			
			fieldProperties.AddProperty(new Property("foliageModelFilePath_", 298963345, "Ebony.Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("foliageHighModelFilePath_", 16683725, "Ebony.Base.String", 24, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("foliageCollisionFilePath_", 3855733126, "Ebony.Base.String", 40, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("foliageHighCollisionFilePath_", 2605087282, "Ebony.Base.String", 56, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("foliageCategory_", 2559634797, "Black.Entity.WorldMap.Foliage.FoliageModelFilePathEntity.FOLIAGE_MODEL_CATEGORY", 72, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isBakable_", 2425300974, "bool", 76, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("shiftTarget_", 3922806351, "bool", 77, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("shiftTargetOffset_", 3369036358, "float", 80, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}