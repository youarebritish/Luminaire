using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu.Executor
{
    public partial class SequenceEventQuestInfoDisplayExecutor : Black.Sequence.Event.Menu.SequenceEventUiEntityInputBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint titleNew_;
		public uint titleUpdate_;
		public uint titleClear_;
		public uint titleFaild_;
		public uint txtExp_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventQuestInfoDisplayExecutor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.Executor.SequenceEventQuestInfoDisplayExecutor", 0, Black.Sequence.Event.Menu.Executor.SequenceEventQuestInfoDisplayExecutor.ObjectType, null, properties, 0, 1696);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.Executor.SequenceEventQuestInfoDisplayExecutor", base.GetFieldProperties(), -1188020009, 679842569);
            return fieldProperties;
        }

		
    }
}