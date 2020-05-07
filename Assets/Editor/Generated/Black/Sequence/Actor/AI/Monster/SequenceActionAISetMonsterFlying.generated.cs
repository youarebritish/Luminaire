using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Monster
{
    public partial class SequenceActionAISetMonsterFlying : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin setActor_;
		public float moveSpeedMax_;
		public float moveSpeedMin_;
		public float vericalMoveSpeed_;
		public float moveAcceleration_;
		public float yawRotationSpeedMax_;
		public float yawAcceleration_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAISetMonsterFlying();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Monster.SequenceActionAISetMonsterFlying", 0, Black.Sequence.Actor.AI.Monster.SequenceActionAISetMonsterFlying.ObjectType, null, properties, 0, 488);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Monster.SequenceActionAISetMonsterFlying", base.GetFieldProperties(), 1175382303, 1848121167);
            return fieldProperties;
        }

		
    }
}