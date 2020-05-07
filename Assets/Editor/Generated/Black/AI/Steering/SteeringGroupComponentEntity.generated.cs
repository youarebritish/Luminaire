using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.Steering
{
    public partial class SteeringGroupComponentEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int type_;
		public float maxSpeed_;
		public float speed_;
		public float minSpeed_;
		public float desiredSideDistance_;
		public float desiredFrontDistance_;
		public float minDistance_;
		public int maxAgentsPerLine_;
		public float cohesionSteepness_;
		public float cohesionMinRadius_;
		public float cohesionMaxRadius_;
		public float cohesionWeight_;
		public float mahalaThreshold_;
		public float euclideanThreshold_;
		public int minTargetDelay_;
		public int maxTargetDelay_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SteeringGroupComponentEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.Steering.SteeringGroupComponentEntity", 0, Black.AI.Steering.SteeringGroupComponentEntity.ObjectType, null, properties, 0, 128);
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

            fieldProperties = new PropertyContainer("Black.AI.Steering.SteeringGroupComponentEntity", base.GetFieldProperties(), 1152478087, 479315012);
            
			
			
			return fieldProperties;
        }

		
    }
}