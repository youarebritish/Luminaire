using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorPointMove : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin landed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin canceled_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin pointActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin motionedActor_;
		public int requireCondition_;
		public int requireConditionLast_;
		public int lStickConditions_;
		public int lStickConditionsLast_;
		public float range0_;
		public float range1_;
		public float range2_;
		public float range3_;
		public float range4_;
		public float range5_;
		public float range6_;
		public float range7_;
		public float standbyTime_;
		public Black.Entity.TransformEntity entityPointer_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorPointMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorPointMove", 0, Black.Sequence.Actor.SequenceActionActorPointMove.ObjectType, null, properties, 0, 1064);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorPointMove", base.GetFieldProperties(), -1401077839, 406705140);
            return fieldProperties;
        }

		
    }
}