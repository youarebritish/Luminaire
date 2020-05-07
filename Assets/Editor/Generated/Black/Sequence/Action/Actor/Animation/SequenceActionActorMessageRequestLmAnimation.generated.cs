using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Animation
{
    public partial class SequenceActionActorMessageRequestLmAnimation : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin requestPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin motionIdPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin notAcceptedPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishedPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin failedActorListPin_;
		public uint motionId_;
		public float timeout_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorMessageRequestLmAnimation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Animation.SequenceActionActorMessageRequestLmAnimation", 0, Black.Sequence.Action.Actor.Animation.SequenceActionActorMessageRequestLmAnimation.ObjectType, null, properties, 0, 888);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Animation.SequenceActionActorMessageRequestLmAnimation", base.GetFieldProperties(), -1673518308, 794627505);
            return fieldProperties;
        }

		
    }
}