using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorMove : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin vector_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finish_;
		public int move_target_;
		public float acceleration_time_;
		public float uniform_time_;
		public float deceleration_time_;
		public bool move_only_flag_;
		public bool move_3d_flag_;
		public bool velocity_clear_flag_;
		public bool overwrite_flag_;
		public bool overwrite_motion_;
		public float target_min_distance_;
		public float valueX_;
		public float valueY_;
		public float valueZ_;
		public float valueW_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorMove", 0, Black.Sequence.Actor.SequenceActionActorMove.ObjectType, null, properties, 0, 816);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorMove", base.GetFieldProperties(), -1415408207, -1480446136);
            
			
			
			return fieldProperties;
        }

		
    }
}