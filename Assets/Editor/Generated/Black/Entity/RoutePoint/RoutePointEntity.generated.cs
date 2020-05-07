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
            
			
			
			return fieldProperties;
        }

		
    }
}