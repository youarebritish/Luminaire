using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor
{
    public partial class SequneceActionActorSetRotationMode : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin target_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin position_;
		public int rotation_mode_;
		public bool target_ucpc_flag_;
		public float rotation_velocity_max_;
		public float rotation_acceleration_;
		public float rotation_gap_;
		public float rotation_gap_time_random_;
		public float rotation_gap_interval_random_;
		public float rotation_shake_;
		public float rotation_shake_time_random_;
		public float rotation_shake_interval_random_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequneceActionActorSetRotationMode();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SequneceActionActorSetRotationMode", 0, Black.Sequence.Action.Actor.SequneceActionActorSetRotationMode.ObjectType, null, properties, 0, 696);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SequneceActionActorSetRotationMode", base.GetFieldProperties(), -1234218469, 184578133);
            return fieldProperties;
        }

		
    }
}