using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Quest
{
    public partial class SequenceQuestCheckProgressInterval : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin true_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin false_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin questIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin startProgressIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin endProgressIdPin_;
		public uint questId_;
		public uint checkStartProgressId_;
		public uint checkEndProgressId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceQuestCheckProgressInterval();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Quest.SequenceQuestCheckProgressInterval", 0, Black.Sequence.Quest.SequenceQuestCheckProgressInterval.ObjectType, null, properties, 0, 744);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Quest.SequenceQuestCheckProgressInterval", base.GetFieldProperties(), 1405432782, 626682183);
            return fieldProperties;
        }

		
    }
}