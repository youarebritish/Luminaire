using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.Steering
{
    public partial class SteeringGroupConfigurationEntity : SQEX.Ebony.Framework.Entity.EntityGroup
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id_;
		public int inputBehavior_;
		public float repulsionSteepness_;
		public float repulsionCutoff_;
		public float repulsionWeight_;
		public float cohesionWeight_;
		public float separationWeight_;
		public float alignmentWeight_;
		public float inputWeight_;
		public float cohesionRange_;
		public float separationRange_;
		public float alignmentRange_;
		public float cohesionSteepness_;
		public float separationSteepness_;
		public float alignmentSteepness_;
		public float forceCutoff_;
		public float lookAheadDistance_;
		public float weightForKeepingDisance_;
		public float weightForCohesionToGroupCenter_;
		public float weightForDestination_;
		public float steepnessForKeepingDistance_;
		public float steepnessForCohesionToGroupCenter_;
		public float maxRangeForKeepingDistance_;
		public float maxRangeForCohesionToGroupCenter_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SteeringGroupConfigurationEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.Steering.SteeringGroupConfigurationEntity", 0, Black.AI.Steering.SteeringGroupConfigurationEntity.ObjectType, null, properties, 0, 304);
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

            fieldProperties = new PropertyContainer("Black.AI.Steering.SteeringGroupConfigurationEntity", base.GetFieldProperties(), 85591277, -1486417615);
            
			
			
			return fieldProperties;
        }

		
    }
}