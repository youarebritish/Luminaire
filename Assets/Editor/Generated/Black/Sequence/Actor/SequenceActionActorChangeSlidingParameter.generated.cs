using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorChangeSlidingParameter : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin set_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin reset_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public int slidingType_;
		public bool isMaxSlope_;
		public float maxSlope_;
		public bool isToFallTime_;
		public float toFallTime_;
		public bool isOverrideGravity_;
		public float overrideGravity_;
		public bool isFrictionSide_;
		public float frictionSide_;
		public bool isFrictionFront_;
		public float frictionFront_;
		public bool isAccelFront_;
		public float accelFront_;
		public bool isAccelBack_;
		public float accelBack_;
		public bool isAccelSide_;
		public float accelSide_;
		public bool isMinVelocity_;
		public float minVelocity_;
		public bool isWeakStopAngle_;
		public float weakStopAngle_;
		public bool isWeakStopTime_;
		public float weakStopTime_;
		public bool isWeakStopSpeed_;
		public float weakStopSpeed_;
		public bool isStrongStopAngle_;
		public float strongStopAngle_;
		public bool isPreSlideWalkForce_;
		public float PreSlideWalkForce_;
		public bool isPreSlideToSlideVelocity_;
		public float PreSlideToSlideVelocity_;
		public bool isPreSlideGravity_;
		public float PreSlideGravity_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorChangeSlidingParameter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorChangeSlidingParameter", 0, Black.Sequence.Actor.SequenceActionActorChangeSlidingParameter.ObjectType, null, properties, 0, 696);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorChangeSlidingParameter", base.GetFieldProperties(), -122323283, -717373188);
            
			
			
			return fieldProperties;
        }

		
    }
}