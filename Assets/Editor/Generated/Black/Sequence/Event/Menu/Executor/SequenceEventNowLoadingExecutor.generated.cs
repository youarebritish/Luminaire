using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu.Executor
{
    public partial class SequenceEventNowLoadingExecutor : Black.Sequence.Event.Menu.SequenceEventUiEntityInputBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint nowLoadingMsgId_;
		public uint headLineMsgId_;
		public uint bodyMsgId_;
		public int maxloadedMegaByte_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventNowLoadingExecutor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.Executor.SequenceEventNowLoadingExecutor", 0, Black.Sequence.Event.Menu.Executor.SequenceEventNowLoadingExecutor.ObjectType, null, properties, 0, 1232);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.Executor.SequenceEventNowLoadingExecutor", base.GetFieldProperties(), 1959148519, -1840514075);
            return fieldProperties;
        }

		
    }
}