using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Quest
{
    public partial class SequenceEventQuestEndProgress : Black.Sequence.Quest.SequenceEventQuestProgressEventBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventQuestEndProgress();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Quest.SequenceEventQuestEndProgress", 0, Black.Sequence.Quest.SequenceEventQuestEndProgress.ObjectType, null, properties, 0, 480);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Quest.SequenceEventQuestEndProgress", base.GetFieldProperties(), 1063791238, 573346243);
            return fieldProperties;
        }

		
    }
}