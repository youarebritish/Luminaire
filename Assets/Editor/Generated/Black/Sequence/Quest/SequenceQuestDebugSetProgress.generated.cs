using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Quest
{
    public partial class SequenceQuestDebugSetProgress : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin questIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin progressIdPin_;
		public uint questId_;
		public uint settingProgressId_;
		public bool bRefreshCharacterEncyclopedia_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceQuestDebugSetProgress();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Quest.SequenceQuestDebugSetProgress", 0, Black.Sequence.Quest.SequenceQuestDebugSetProgress.ObjectType, null, properties, 0, 560);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Quest.SequenceQuestDebugSetProgress", base.GetFieldProperties(), -1624969271, -1162929161);
            return fieldProperties;
        }

		
    }
}