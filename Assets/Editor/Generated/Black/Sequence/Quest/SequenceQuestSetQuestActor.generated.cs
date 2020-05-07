using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Quest
{
    public partial class SequenceQuestSetQuestActor : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public uint questId_;
		public uint questActorUniqueId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceQuestSetQuestActor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Quest.SequenceQuestSetQuestActor", 0, Black.Sequence.Quest.SequenceQuestSetQuestActor.ObjectType, null, properties, 0, 568);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Quest.SequenceQuestSetQuestActor", base.GetFieldProperties(), 1224554022, 267602239);
            return fieldProperties;
        }

		
    }
}