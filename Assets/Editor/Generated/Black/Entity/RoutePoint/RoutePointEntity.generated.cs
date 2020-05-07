using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.RoutePoint
{
    public partial class RoutePointEntity : Black.Entity.TransformGroupEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float radius_;
		public bool bAir_;
		public int pointType_;
		public float destinationPointRandomRange_;
		public int movementOverride_;
		public float moveSpeedOverride_;
		public float arrivalMoveSpeedOverride_;
		public bool isEnableDynamicRandomDestination_;
		public float destinationDistanceRatioMin_;
		public float destinationDistanceRatioMax_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new RoutePointEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.RoutePoint.RoutePointEntity", 0, Black.Entity.RoutePoint.RoutePointEntity.ObjectType, null, properties, 0, 304);
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

            fieldProperties = new PropertyContainer("Black.Entity.RoutePoint.RoutePointEntity", base.GetFieldProperties(), -1043113076, -1150238731);
            
			fieldProperties.AddProperty(new Property("radius_", 2286360452, "float", 224, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("bAir_", 1501790040, "bool", 228, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("pointType_", 3734080690, "Black.Entity.RoutePoint.RoutePointEntity.PointType", 232, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("destinationPointRandomRange_", 3344011830, "float", 236, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("movementOverride_", 2713163925, "Black.AI.Move.AIMovement", 240, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveSpeedOverride_", 524138768, "float", 244, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("arrivalMoveSpeedOverride_", 1685606087, "float", 248, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEnableDynamicRandomDestination_", 2658054585, "bool", 252, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("destinationDistanceRatioMin_", 1561586838, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("destinationDistanceRatioMax_", 907980292, "float", 260, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}