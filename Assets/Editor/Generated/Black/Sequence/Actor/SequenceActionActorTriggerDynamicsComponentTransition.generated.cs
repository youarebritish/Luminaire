using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorTriggerDynamicsComponentTransition : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValue_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inRigidBody_;
		public bool transitionAll_;
		public IList<Black.Entity.Data.CharacterEntry.RBTransitionEntry> nameList_;
		public int transitionType_;
		public int transitionNumber_;
		public int bahaviorOnSleeping_;
		public float sleepThreshold_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorTriggerDynamicsComponentTransition();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorTriggerDynamicsComponentTransition", 0, Black.Sequence.Actor.SequenceActionActorTriggerDynamicsComponentTransition.ObjectType, null, properties, 0, 592);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorTriggerDynamicsComponentTransition", base.GetFieldProperties(), 2013198221, -1870725620);
            return fieldProperties;
        }

		
    }
}