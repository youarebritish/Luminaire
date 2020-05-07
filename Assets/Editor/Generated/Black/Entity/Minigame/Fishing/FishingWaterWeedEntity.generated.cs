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
            return fieldProperties;
        }

		
    }
}