using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Multiplayer.Quest
{
    public partial class SequenceMultiPlayerEndQuest : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin completePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin abortPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin succeededPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failedPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin questIdPin_;
		public uint questId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerEndQuest();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Multiplayer.Quest.SequenceMultiPlayerEndQuest", 0, Black.Sequence.Action.Multiplayer.Quest.SequenceMultiPlayerEndQuest.ObjectType, null, properties, 0, 752);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Multiplayer.Quest.SequenceMultiPlayerEndQuest", base.GetFieldProperties(), 1967504727, -1254916779);
            return fieldProperties;
        }

		
    }
}