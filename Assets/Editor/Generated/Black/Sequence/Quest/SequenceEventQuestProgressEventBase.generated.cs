using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Quest
{
    public partial class SequenceEventQuestProgressEventBase : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin progressActivate_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin questIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin progressIdPin_;
		public uint questId_;
		public uint progressId_;
		public bool isCheckOtherProgressOnline_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventQuestProgressEventBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Quest.SequenceEventQuestProgressEventBase", 0, Black.Sequence.Quest.SequenceEventQuestProgressEventBase.ObjectType, null, properties, 0, 480);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Quest.SequenceEventQuestProgressEventBase", base.GetFieldProperties(), -544687415, -366693848);
            
			
			
			return fieldProperties;
        }

		
    }
}