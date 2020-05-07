using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu.Executor
{
    public partial class SequenceEventQuestSelectMenuExecutor : Black.Sequence.Event.Menu.SequenceEventUiEntityInputBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventQuestSelectMenuExecutor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.Executor.SequenceEventQuestSelectMenuExecutor", 0, Black.Sequence.Event.Menu.Executor.SequenceEventQuestSelectMenuExecutor.ObjectType, null, properties, 0, 1512);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.Executor.SequenceEventQuestSelectMenuExecutor", base.GetFieldProperties(), 1276246757, 1868047880);
            return fieldProperties;
        }

		
    }
}