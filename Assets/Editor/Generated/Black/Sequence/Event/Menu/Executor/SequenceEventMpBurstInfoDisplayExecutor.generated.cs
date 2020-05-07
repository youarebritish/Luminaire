using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu.Executor
{
    public partial class SequenceEventMpBurstInfoDisplayExecutor : Black.Sequence.Event.Menu.SequenceEventUiEntityInputBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint elementId_;
		public float offsetHeight_;
		public float offsetX_;
		public float offsetY_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventMpBurstInfoDisplayExecutor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.Executor.SequenceEventMpBurstInfoDisplayExecutor", 0, Black.Sequence.Event.Menu.Executor.SequenceEventMpBurstInfoDisplayExecutor.ObjectType, null, properties, 0, 1128);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.Executor.SequenceEventMpBurstInfoDisplayExecutor", base.GetFieldProperties(), 2063433538, -267735563);
            
			
			
			return fieldProperties;
        }

		
    }
}