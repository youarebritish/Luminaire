using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI
{
    public partial class SequenceActionAIGetAroundActorCount : Black.Sequence.Actor.AI.SequenceActionAIBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueBasePosition_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueAroundCount_;
		public int actorType_;
		public float aroundRadius_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIGetAroundActorCount();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.SequenceActionAIGetAroundActorCount", 0, Black.Sequence.Actor.AI.SequenceActionAIGetAroundActorCount.ObjectType, null, properties, 0, 656);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.SequenceActionAIGetAroundActorCount", base.GetFieldProperties(), -1281663718, 1653449027);
            return fieldProperties;
        }

		
    }
}