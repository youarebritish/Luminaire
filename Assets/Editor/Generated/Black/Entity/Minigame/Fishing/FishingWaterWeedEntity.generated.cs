using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Minigame.Fishing
{
    public partial class FishingWaterWeedEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int shapeType_;
		public float boxEllipseWidth_;
		public float boxEllipseDepth_;
		public float circleRadius_;
		public float height_;
		public float sinkLureSuppressAppendRadius_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new FishingWaterWeedEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Minigame.Fishing.FishingWaterWeedEntity", 0, Black.Entity.Minigame.Fishing.FishingWaterWeedEntity.ObjectType, null, properties, 0, 304);
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

            fieldProperties = new PropertyContainer("Black.Entity.Minigame.Fishing.FishingWaterWeedEntity", base.GetFieldProperties(), -225016400, -705707179);
            
			fieldProperties.AddProperty(new Property("shapeType_", 520548747, "Black.Entity.Minigame.Fishing.FishingWaterWeedEntity.SHAPE_TYPE", 256, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("boxEllipseWidth_", 2631172881, "float", 260, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("boxEllipseDepth_", 3548261702, "float", 264, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("circleRadius_", 3455069560, "float", 268, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("height_", 2527956647, "float", 272, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sinkLureSuppressAppendRadius_", 4066406130, "float", 276, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}