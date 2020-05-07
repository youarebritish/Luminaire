using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Quest
{
    public partial class SequenceQuestGetQuestActor : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin questActor_;
		public uint questId_;
		public uint questActorUniqueId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceQuestGetQuestActor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Quest.SequenceQuestGetQuestActor", 0, Black.Sequence.Quest.SequenceQuestGetQuestActor.ObjectType, null, properties, 0, 472);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Quest.SequenceQuestGetQuestActor", base.GetFieldProperties(), 1729264090, -1323789208);
            return fieldProperties;
        }

		
    }
}